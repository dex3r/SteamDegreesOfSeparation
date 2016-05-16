using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamDegreesOfSeparation
{
	[Serializable]
	public sealed class SteamFriendsList
	{
		public SteamFriendsCollection friendslist;
	}

	[Serializable]
	public sealed class SteamFriendsCollection
	{
		public SteamFriendsEntry[] friends;
	}

	[Serializable]
	public sealed class SteamFriendsEntry
	{
		public string steamid;
	}
}
