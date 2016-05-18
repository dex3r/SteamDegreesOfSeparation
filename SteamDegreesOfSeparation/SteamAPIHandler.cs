using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

		public SteamAPIHandler()
		{
			webAPIKeys = new HashSet<SteamWebAPIKey>();
		}

		public bool AddKey(SteamWebAPIKey key)
		{
			return webAPIKeys.Add(key);
		}

		public SteamFriendsList GetFriends(ulong targetUserSteamID)
		{

		}

		public static bool IsKeyValid(SteamWebAPIKey key)
		{
			throw new NotImplementedException();
		}
	}
}
