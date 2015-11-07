# GTFS.Net
General Transit Feed Specification ([GTFS](https://developers.google.com/transit/gtfs/)) data parser

## How to Install
Install-Package [GtfsNet](https://www.nuget.org/packages/GtfsNet)

## Example
1. Create a parser
2. parse specified folder location ("feeds/subway" in the example below)
3. Optional step: Validate the feed according to [GTFS specification]{https://developers.google.com/transit/gtfs/reference).
```c#
  GtfsFeedParser parser = new GtfsFeedParser();
  GtfsFeed feed = parser.Parse("feeds/subway");
  // Optional step
  GtfsFeedValidator validator = new GtfsFeedValidator();
  validator.Validate(feed);
```


## Note
This is not a fork of [OsmSharp/GTFS](https://github.com/OsmSharp/GTFS). 
This project uses some part of that project (Entities) therefore not compatible

