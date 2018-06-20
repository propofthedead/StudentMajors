using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMajors.Models
{
	public class ClassesForStudent
	{
		public Student student { get; set; }
		public IEnumerable<Class> classes { get; set; }

		public ClassesForStudent() { }
	}
}