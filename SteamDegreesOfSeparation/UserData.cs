using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SteamDegreesOfSeparation
{
	[Serializable]
	[XmlRoot("D")]
	public sealed class UserData
	{
		[XmlElement("I")]
		public ulong SteamID;

		[XmlElement(ElementName = "F", IsNullable = false)]
		public HashSet<ulong> Friends;
	}
}
