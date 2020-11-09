﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidzyCodeFirst.Models;

namespace VidzyCodeFirst
{
	public class VidzyDbContext : DbContext
	{
		public DbSet<Video> Videos { get; set; }
		public DbSet<Genre> Genres { get; set; }
	}
}
