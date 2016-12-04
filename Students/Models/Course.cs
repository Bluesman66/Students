﻿using System.Collections.Generic;

namespace Students.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Student> Students { get; set; }

		public Course()
		{
			Students = new List<Student>();
		}
	}
}