using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SteamDegreesOfSeparation
{
	public class UsersDataManager
	{
		public string DataDirectoryPath { get; private set; }
		public UsersDataManagerMode CurrentMode { get; private set; }

		private int currentFileNumber;
		private string fileNamePrefix = "usersData_part";

		private UsersDataManager()
		{

		}

		public static UsersDataManager CreateManager(string dataDirectoryPath)
		{
			var newObject = new UsersDataManager();

			newObject.DataDirectoryPath = dataDirectoryPath;

			return newObject;
		}

		public HashSet<UserData> ReadAllToHashSet()
		{

		}

		public Dictionary<ulong, ulong[]> ReadAllToDictionary()
		{

		}

		public int GetCount()
		{

		}

		public int GetFilesCount()
		{

		}

		public void WriteUsers(IReadOnlyCollection<UserData> users)
		{

		}

		public void SwitchModes()
		{

		}

		private UsersDataManagerMode DetectMode()
		{
			DirectoryInfo di = new DirectoryInfo(DataDirectoryPath);

			if (!di.Exists)
			{
				return UsersDataManagerMode.XML;
			}

			var allFiles = di.GetFiles();
			int xmlFilesCount = allFiles.Count(x => x.Extension.Equals("xml", StringComparison.OrdinalIgnoreCase));
			int datFilesCount = allFiles.Count(x => x.Extension.Equals("dat", StringComparison.OrdinalIgnoreCase));

			if (xmlFilesCount > 0 && datFilesCount == 0)
			{
				return UsersDataManagerMode.XML;
			}
			else if (xmlFilesCount == 0 && datFilesCount > 0)
			{
				return UsersDataManagerMode.Binary;
			}
			else if (xmlFilesCount == 0 && datFilesCount == 0)
			{
				return UsersDataManagerMode.XML;
			}
			else
			{
				Trace.WriteLine("Could not determine UsersDataManagerMode based on files extensions. Assuming XML mode.");
				return UsersDataManagerMode.XML;
				//TODO: Try to repair the database since its probabily broken due to interrupted mode switching.
			}
		}

		private HashSet<UserData> ReadFile(int fileNumber)
		{
			string fileName = fileNamePrefix + fileNumber + "." + GetFileExtension(CurrentMode);
			string filePath = Path.Combine(DataDirectoryPath, fileName);

			if (CurrentMode == UsersDataManagerMode.XML)
			{
				return ReadXMLFile(filePath);
			}
			else
			{
				return ReadBinaryFile(filePath);
			}
		}

		private HashSet<UserData> ReadBinaryFile(string path)
		{

		}

		private HashSet<UserData> ReadXMLFile(string path)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(HashSet<UserData>));
		}

		private string GetFileExtension(UsersDataManagerMode mode)
		{
			if (mode == UsersDataManagerMode.XML)
			{
				return "xml";
			}
			else
			{
				return "dat";
			}
		}
	}

	public enum UsersDataManagerMode
	{
		XML,
		Binary,
	}
}
