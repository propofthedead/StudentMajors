using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMajors.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int? MajorId { get; set; }
		public int Sat { get; set; }

		public Student() { }
	}
}