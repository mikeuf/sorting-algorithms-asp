using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SortingAlgorithms.Models
{
    public class SortModel
    {
        public string OriginalNumbers { get; set; }
        public string UnsortedNumbers { get; set; }
        public string SortType { get; set; }

    }
}
