using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace SortingAlgorithms.Models
{
    public class SortModel {
        public string OriginalNumbers { get; set; }
        public string SortedNumbers { get; set; }
        public string SortType { get; set; }
        public IEnumerable<Algorithm> Algorithms { get; set; }
    }

    //public class SortModel
    //{
    //    public string OriginalNumbers { get; set; }
    //    public string SortType { get; set; }
    //}

    public class SortModelContext : DbContext
    {

        public SortModelContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Algorithm> Algorithm { get; set; }

    }

    public class Algorithm
    {

        [Key]
        public int AlgorithmID { get; set; }
        public string AlgorithmName { get; set; }
        public string RunTime { get; set; }
        public string SpaceComplexity { get; set; }
        public string AdditionalNotes { get; set; }
    }
}