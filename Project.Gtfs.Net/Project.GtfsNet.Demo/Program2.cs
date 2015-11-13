using System;
using System.IO;
using GtfsNet.Parsers;
using GTFS;
using GTFS.IO;

namespace GtfsNet.Demo
{
	public class Program2
	{
		public static void Main()
		{
			//TestGtfsNet();
			//TestGtfs();

			WriteToMongoDb();

			Console.WriteLine("Press ENTER to continue...");
			Console.Read();
		}

		private static void WriteToMongoDb()
		{
			var feed = GetGTfsFeed(Paths.GOOD_FEED_PATH);
			//feed.ToJson();
		}

		private static GtfsFeed GetGTfsFeed(string feedPath)
		{
			return new GtfsFeedParser().Parse(feedPath);
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
