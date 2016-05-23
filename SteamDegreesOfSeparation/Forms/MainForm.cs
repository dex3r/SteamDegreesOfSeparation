using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoreLinq;
using SteamDegreesOfSeparation.Properties;

namespace SteamDegreesOfSeparation
{
	public partial class MainForm : Form
	{
		private SteamAPIHandler steamApiHandler = new SteamAPIHandler();
		private SteamFriendsQuarry currentQuary;
		private int lastProcessedUsersCount;

		public MainForm()
		{
			InitializeComponent();

			ulong seedID;
			ulong.TryParse(Settings.Default.SeedUserSteamID, out seedID);

			currentQuary = new SteamFriendsQuarry(steamApiHandler, seedID);

			if (Settings.Default.SteamAPIKeys != null)
			{
				lbSteamAPIKeys.Items.AddRange(Settings.Default.SteamAPIKeys.Cast<object>().ToArray());
			}

			tbSeedUserSteamID.Text = Settings.Default.SeedUserSteamID;
			nupQuarryThreadsToUse.Value = Settings.Default.QuarryThreadsCount;

			RefreshSteamAPIKeys();
		}

		private void bAddSteamAPIKey_Click(object sender, EventArgs e)
		{
			lbSteamAPIKeys.Items.Add(tbSteamAPIKeyInput.Text);

			SaveSettings();
			RefreshSteamAPIKeys();
		}

		public void SaveSettings()
		{
			Settings settings = Settings.Default;

			settings.SteamAPIKeys = new System.Collections.Specialized.StringCollection();
			settings.SteamAPIKeys.AddRange(lbSteamAPIKeys.Items.Cast<string>().ToArray());

			settings.SeedUserSteamID = tbSeedUserSteamID.Text;

			settings.QuarryThreadsCount = (int)nupQuarryThreadsToUse.Value;

			settings.Save();
		}

		private void RefreshSteamAPIKeys()
		{
			List<SteamWebAPIKey> newKeys = new List<SteamWebAPIKey>();

			foreach (var item in lbSteamAPIKeys.Items)
			{
				string str = item.ToString();

				newKeys.Add(new SteamWebAPIKey(str));
			}

			steamApiHandler.SetKeys(newKeys);
		}

		private void tbSeedUserSteamID_Leave(object sender, EventArgs e)
		{
			SaveSettings();
			currentQuary.SetSeedSteamID(ulong.Parse(Settings.Default.SeedUserSteamID));
		}

		private void bSteamAPIKeysRemove_Click(object sender, EventArgs e)
		{
			lbSteamAPIKeys.Items.Clear();
			SaveSettings();
		}

		private void tUpdateFriendsQuarryStats_Tick(object sender, EventArgs e)
		{
			lProcessedUsers.Text = currentQuary.ProcessedUsers.ToString();

			int processedUsersDelta = currentQuary.ProcessedUsers - lastProcessedUsersCount;
			lastProcessedUsersCount = currentQuary.ProcessedUsers;
			double processedUserPerSec = (double)processedUsersDelta / ((double)tUpdateFriendsQuarryStats.Interval / 1000);
			lProcessedUsersPerSecond.Text = processedUserPerSec.ToString();

			lSeenUsers.Text = currentQuary.SeenUsersCount.ToString();
			lPrivateProfilesFound.Text = currentQuary.PrivateProfilesFound.ToString();
		}

		private void bQuarryStart_Click(object sender, EventArgs e)
		{
			if (TryPerformQuarryOperation(() => currentQuary.Start(), "Quarry could not be started:"))
			{
				tUpdateFriendsQuarryStats.Start();
				pQuarrySettings.Enabled = false;
			}
		}

		private bool TryPerformQuarryOperation(Action quarryOperation, string errorMessage)
		{
			DialogResult result;

			do
			{
				try
				{
					quarryOperation();
					return true;
				}
				catch (Exception ex)
				{
					result = MessageBox.Show(errorMessage + "\n" + ex.Message, "Quarry request error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				}
			} while (result == DialogResult.Retry);

			return false;
		}

		private void bQuarryPause_Click(object sender, EventArgs e)
		{
			if (TryPerformQuarryOperation(() => currentQuary.Pause(), "Quarry could not be paused:"))
			{
				tUpdateFriendsQuarryStats.Stop();
			}
		}

		private void nupQuarryThreadsToUse_ValueChanged(object sender, EventArgs e)
		{
			currentQuary.SetTargetThreadsAmount((int)nupQuarryThreadsToUse.Value);
		}

		private void bQuarryStop_Click(object sender, EventArgs e)
		{
			if (TryPerformQuarryOperation(() => currentQuary.Stop(), "Quarry could not be stopped"))
			{
				pQuarrySettings.Enabled = true;
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}
	}
}
