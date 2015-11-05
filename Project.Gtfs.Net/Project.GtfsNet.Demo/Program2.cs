using System;
using System.IO;
using GTFS;
using GTFS.IO;
using Project.GtfsNet.Parsers;

namespace Project.GtfsNet.Demo
{
	public class Program2
	{
		public static void Main(string[] args)
		{
			TestGtfsNet();
			TestGtfs();

			Console.WriteLine("Press ENTER to continue...");
			Console.Read();
		}

		private static void TestGtfsNet()
		{
			GtfsFeedParser parser = new GtfsFeedParser();
			GtfsFeed feed = parser.Parse(Paths.GOOD_FEED_PATH);
		}

		private static void TestGtfs()
		{
			// create the reader.
			var reader = new GTFSReader<GTFSFeed>(strict:false);

			// execute the reader.
			var feed = reader.Read(new GTFSDirectorySource(new DirectoryInfo(Paths.GOOD_FEED_PATH)));
		}
	}

	public static class Paths
	{
		public const string GOOD_FEED_PATH = "feeds/subway";
		public const string BAD_FEED_PATH = "feeds/missingRequiredFiles";
		public const string NON_EXISTING_FEED_PATH = "feeds";
	}

}
