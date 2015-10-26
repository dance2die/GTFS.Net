// The MIT License (MIT)

// Copyright (c) 2014 Ben Abelshausen

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project.GtfsNet.Enums;

namespace Project.GtfsNet.Entities
{
	/// <summary>
	/// Represents a rules for making connections at transfer points between routes.
	/// </summary>
	/// <remarks>
	/// Copied from
	/// https://github.com/OsmSharp/GTFS/blob/master/GTFS/Entities/Transfer.cs
	/// </remarks>
	public class Transfer : Entity, IEqualityComparer<Transfer>
	{
		/// <summary>
		/// Gets or sets a stop or station where a connection between routes begins.
		/// </summary>
		[Required]
		public string FromStopId { get; set; }

		/// <summary>
		/// Gets or sets a stop or station where a connection between routes ends.
		/// </summary>
		[Required]
		public string ToStopId { get; set; }

		/// <summary>
		/// Gets or sets the type of connection for the specified (from_stop_id, to_stop_id) pair.
		/// </summary>
		[Required]
		public TransferType TransferType { get; set; }

		/// <summary>
		/// Gets or sets the amount of time that must be available in an itinerary to permit a transfer between routes at these stops.
		/// </summary>
		public string MinimumTransferTime { get; set; }

		public bool Equals(Transfer x, Transfer y)
		{
			return AreEqual(x, y);
		}

		public int GetHashCode(Transfer obj)
		{
			return ComputeHashCode(obj);
		}
	}
}
