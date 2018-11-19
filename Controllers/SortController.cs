using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SortingAlgorithms.Controllers;

namespace SortingAlgorithms.Models
{
    public class SortController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sort(string OriginalNumbers, string SortType)
        {
            if ((OriginalNumbers == null) || !ValidateForm(ref OriginalNumbers)) 
            {
                return View("ValidationError"); 
            }

            List<int> nums = OriginalNumbers.Split(',').Select(int.Parse).ToList();

            ViewBag.OriginalNumbers = OriginalNumbers;

            if ((OriginalNumbers != null) && (SortType != null))
            {
                Sorter theSorter = new Sorter();

                switch (SortType)
                {
                    case "Bubble Sort":
                        theSorter.BubbleSort(ref nums);
                        ViewBag.EachIteration = theSorter.EachIteration;
                        break;
                    case "Selection Sort":
                        theSorter.SelectionSort(ref nums);
                        ViewBag.EachIteration = theSorter.EachIteration;
                        break;
                    case "Insertion Sort":
                        theSorter.InsertionSort(ref nums);
                        ViewBag.EachIteration = theSorter.EachIteration;
                        break;
                    case "Merge Sort":
                        theSorter.MergeSort(ref nums);
                        ViewBag.EachIteration = theSorter.EachIteration;
                        break;
                    case "Quick Sort":
                        theSorter.QuickSort(ref nums);
                        ViewBag.EachIteration = theSorter.EachIteration;
                        break;
                    default:
                        break;

                }
            }

            ViewBag.SortType = SortType;
            ViewBag.SortedNumbers = string.Join(",", nums);

            return View();
        }

        private bool ValidateForm (ref string OriginalNumbers) {

            var regexContainsNumbersDelimitedByCommas = @"^\d+,{1}(\d+|,{1})*\d+$";
            Match match = Regex.Match(OriginalNumbers, regexContainsNumbersDelimitedByCommas);

            if (!match.Success)
            {
                return false;
            }

            return true;
        }




    }
}
