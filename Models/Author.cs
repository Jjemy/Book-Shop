﻿using System;
using Ecommerce.Data.Base;

namespace Ecommerce.Models
{
	public class Author:IEntityBase
	{
		public int ID { get; set; }
		public string? FullName { get; set; }
        public string? Bio { get; set; }
		public string? ImageURL { get; set; }

		public virtual IEnumerable<Book>? Books { get; set; }
		public virtual Publisher? Publisher { get; set; }
	}
}

