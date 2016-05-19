using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamDegreesOfSeparation
{
	public enum QuarryStatus
	{
		Invalid = -1,
		Unknown = 0,

		Stopped = 1,
		WarmingUp,
		Started,
		Paused,
	}
}
