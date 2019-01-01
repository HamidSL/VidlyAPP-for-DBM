﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VidlyApp.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext() : base("name = MovieDbContext")
        {
        }

        public DbSet<Movies> Movies { get; set; }


    }
}