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

namespace SteamDegreesOfSeparation
{
	public partial class MainForm : Form
	{
		private SteamAPIHandler steamApiHandler = new SteamAPIHandler();

		public MainForm()
		{
			InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
