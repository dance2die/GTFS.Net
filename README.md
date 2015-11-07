# GTFS.Net
General Transit Feed Specification ([GTFS](https://developers.google.com/transit/gtfs/)) data parser

## How to Install
Install via [NuGet](https://www.nuget.org/packages/GtfsNet).
```
  Install-Package GtfsNet
```
## Example
1. Create a parser
2. parse specified folder location ("feeds/subway" in the example below)
3. ***Optional*** step: Validate the feed according to [GTFS specification](https://developers.google.com/transit/gtfs/reference).
```c#
  GtfsFeedParser parser = new GtfsFeedParser();
  GtfsFeed feed = parser.Parse("feeds/subway");
  // Optional step
  GtfsFeedValidator validator = new GtfsFeedValidator();
  validator.Validate(feed);
```

## Implementation detail
* Both `Parser` and `Validator` are implemented using a [**Visitor**](https://en.wikipedia.org/wiki/Visitor_pattern) Design Pattern.
* [GtfsFeedParser](https://github.com/dance2die/GTFS.Net/blob/master/Project.Gtfs.Net/Project.GtfsNet/Parsers/GtfsFeedParser.cs) is created as a facade for [GtfsFeedParserVisitor](https://github.com/dance2die/GTFS.Net/blob/master/Project.Gtfs.Net/Project.GtfsNet/Visitors/GtfsFeedParserVisitor.cs) because calling GtfsFeedParserVisitor instance directly makes the caller's code harder to read.
* [GtfsFeedValidator](https://github.com/dance2die/GTFS.Net/blob/master/Project.Gtfs.Net/Project.GtfsNet/GtfsFeedValidator.cs) is also a facade for two different validators.
  1. [RequiredFileVisitor](https://github.com/dance2die/GTFS.Net/blob/master/Project.Gtfs.Net/Project.GtfsNet/Visitors/RequiredFileVisitor.cs): Check if all required `files` are parsed in a feed.
  2. [RequiredFieldVisitor](https://github.com/dance2die/GTFS.Net/blob/master/Project.Gtfs.Net/Project.GtfsNet/Visitors/RequiredFieldVisitor.cs): Check if all required `fields` in each file are parsed in a feed

## Note
This is not a fork of [OsmSharp/GTFS](https://github.com/OsmSharp/GTFS). 
This project uses some part of that project (Entities) therefore not compatible

