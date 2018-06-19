using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMajors.Models
{
	public class Enrolled
	{
		public int Id { get; set; }
		public int StudentId { get; set; }
		public int ClassId { get; set; }
		public string Grade { get; set; }

		public Enrolled() { }
	}
}