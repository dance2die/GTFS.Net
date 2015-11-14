using System;
using System.IO;
using System.Linq;
using GtfsNet.Parsers;
using GTFS;
using GTFS.IO;
using MongoDB.Bson;
using MongoDB.Driver;

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

		private static async void WriteToMongoDb()
		{
			var feed = GetGTfsFeed(Paths.GOOD_FEED_PATH);
			//feed.ToJson();

			var client = new MongoClient("mongodb://localhost:27017");
			var database = client.GetDatabase("test");
			var collection = database.GetCollection<BsonDocument>("x");

			var document = new BsonDocument
			{
				{ "name", "MongoDB" },
				{ "type", "Database" },
				{ "count", 1 },
				{ "info", new BsonDocument
						  {
							  { "x", 203 },
							  { "y", 102 }
						  }}
			};

			await collection.InsertOneAsync(document);

			// generate 100 documents with a counter ranging from 0 - 99
			var documents = Enumerable.Range(0, 100).Select(counter => new BsonDocument("counter", counter));

			await collection.InsertManyAsync(documents);

			var count = await collection.CountAsync(new BsonDocument());

			Console.WriteLine(count);
		}

		private static GtfsFeed GetGTfsFeed(string feedPath)
		{
			return new GtfsFeedParser().Parse(feedPath);
		}

		private static void TestGtfs()
		{
			// create the reader.
			var reader = new GTFSReader<GTFSFeed>(strict: false);

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
