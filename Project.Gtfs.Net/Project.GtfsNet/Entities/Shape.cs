﻿// The MIT License (MIT)

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

namespace Project.GtfsNet.Entities
{
	/// <summary>
	/// Represents rules for drawing lines on a map to represent a transit organization's routes.
	/// </summary>
	/// <remarks>
	/// Copied from
	/// https://github.com/OsmSharp/GTFS/blob/master/GTFS/Entities/Shape.cs
	/// </remarks>
	public class Shape : Entity, IEqualityComparer<Shape>
	{
		/// <summary>
		/// Gets or sets an ID that uniquely identifies a shape.
		/// </summary>
		[Required]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets a shape point's latitude with a shape ID. The field value must be a valid WGS 84 latitude. Each row in shapes.txt represents a shape point in your shape definition.
		/// </summary>
		[Required]
		public double Latitude { get; set; }

		/// <summary>
		/// Gets or sets a shape point's longitude with a shape ID. The field value must be a valid WGS 84 longitude value from -180 to 180. Each row in shapes.txt represents a shape point in your shape definition.
		/// </summary>
		[Required]
		public double Longitude { get; set; }

		/// <summary>
		/// Gets or sets the sequence order along the shape. The values for shape_pt_sequence must be non-negative integers, and they must increase along the trip. 
		/// </summary>
		[Required]
		public int Sequence { get; set; }

		/// <summary>
		/// Gets or sets the distance traveled along a shape from the first shape point.
		/// </summary>
		public double? DistanceTraveled { get; set; }

		public bool Equals(Shape x, Shape y)
		{
			return AreEqual(x, y);
		}

		public int GetHashCode(Shape obj)
		{
			return ComputeHashCode(obj);
		}
	}
}
