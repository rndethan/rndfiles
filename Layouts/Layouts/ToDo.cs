﻿using System;
using Parse;

namespace Layouts
{
	public class ToDo
	{
		public string ObjectId { get; set; }
		public string ItemDescription { get; set; }
		public DateTime? createdAt { get; set; }
		public DateTime? updatedAt { get; set; }

		public ToDo ()
		{
		}
	}
}

