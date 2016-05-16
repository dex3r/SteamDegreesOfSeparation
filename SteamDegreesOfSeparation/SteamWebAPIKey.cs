using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamDegreesOfSeparation
{
	public class SteamWebAPIKey
	{
		public string Key { get; private set; }

		public SteamWebAPIKey(string key)
		{
			this.Key = key;
		}

		public bool IsValid()
		{
			return SteamAPIHandler.IsKeyValid(this);
		}

		public override bool Equals(object obj)
		{
			SteamWebAPIKey second = obj as SteamWebAPIKey;
			if (second == null)
			{
				return false;
			}

			return this.Key == second.Key;
		}

		public override int GetHashCode()
		{
			return Key.GetHashCode();
		}

		public override string ToString()
		{
			return Key;
		}
	}
}
