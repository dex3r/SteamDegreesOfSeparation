using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SteamDegreesOfSeparation
{
	public sealed class SteamAPIHandler
	{
		public IReadOnlyCollection<SteamWebAPIKey> Keys
		{
			get
			{
				return webAPIKeys;
			}
		}

		private HashSet<SteamWebAPIKey> webAPIKeys;
		private ThreadLocal<WebClient> webClient;
		private JsonSerializerSettings JsonSettings;

		public SteamAPIHandler()
		{
			webAPIKeys = new HashSet<SteamWebAPIKey>();

			webClient = new ThreadLocal<WebClient>(() =>
			{
				var wc = new WebClient();
				wc.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);

				return wc;
			});

			JsonSettings = new JsonSerializerSettings();
			JsonSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
		}

		public bool AddKey(SteamWebAPIKey key)
		{
			return webAPIKeys.Add(key);
		}

		public void SetKeys(IEnumerable<SteamWebAPIKey> keys)
		{
			webAPIKeys.Clear();

			foreach (var key in keys)
			{
				webAPIKeys.Add(key);
			}
		}

		/// <summary>
		/// This method is thread safe.
		/// </summary>
		/// <param name="targetUserSteamID"></param>
		/// <returns></returns>
		public SteamFriendsList GetFriends(ulong targetUserSteamID)
		{
			SteamWebAPIKey key = GetRandomKey();

			string request = GenerateGetFriendsRequest(targetUserSteamID, key.Key);
			string friendslistResult;

			try
			{
				friendslistResult = webClient.Value.DownloadString(request);
			}
			catch (WebException ex)
			{
				Debug.WriteLine(ex.ToString());

				return null;
			}

			SteamFriendsList friendsList = JsonConvert.DeserializeObject<SteamFriendsList>(friendslistResult, JsonSettings);
			IEnumerable<SteamFriendsEntry> friends = friendsList.friendslist.friends;

			return friendsList;
		}

		private string GenerateGetFriendsRequest(ulong steamID, string key)
		{
			string a = "http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key=";
			string b = "&steamid=";
			string c = "&relationship=friend";

			return a + key + b + steamID + c;
		}

		public SteamWebAPIKey GetRandomKey()
		{
			return webAPIKeys.ElementAt(StaticRandom.Rand.Next(webAPIKeys.Count));
		}

		public static bool IsKeyValid(SteamWebAPIKey key)
		{
			throw new NotImplementedException();
		}
	}
}
