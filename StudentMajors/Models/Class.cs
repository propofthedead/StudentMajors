﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMajors.Models
{
	public class Class
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int? MajorId { get; set; }

		public Class() { }
	}
}