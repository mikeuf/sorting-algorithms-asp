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
        private readonly SortModelContext _context;

        /// <summary>
        /// Set up the database context 
        /// </summary>
        /// <param name="context">Context.</param>
        public SortController(SortModelContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Uses the value provided by the drop-down box in the view to determine
        /// which sorting algorithm to use. After the sort, it passes a data
        /// model object to the view with results.
        /// </summary>
        /// <returns>The sort.</returns>
        /// <param name="OriginalNumbers">Original numbers.</param>
        /// <param name="SortType">Sort type.</param>
        public IActionResult Sort(string OriginalNumbers, string SortType)
        {
            if ((OriginalNumbers == null) || !ValidateForm(ref OriginalNumbers))
            {
                return View("ValidationError");
            }

            // populates the a new list based on a comma-separated string
            List<int> nums = OriginalNumbers.Split(',').Select(int.Parse).ToList();

            if ((OriginalNumbers != null) && (SortType != null))
            {
                // choose a sort based on the user selection
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

            // create a model object, fill it with results and pass to the view
            SortModel sortResults = new SortModel();
            // queries database based on the SortType that was selected
            sortResults.Algorithms = from a in _context.Algorithm
                               where a.AlgorithmName == SortType
                               select a;

            if (sortResults.Algorithms == null)
            {
                return NotFound();
            }

            sortResults.OriginalNumbers = OriginalNumbers;
            // create comma-separated string by concatenating the list items
            sortResults.SortedNumbers = string.Join(",", nums);
            sortResults.SortType = SortType;

            return View(sortResults);
        }

        /// <summary>
        /// Performs a quick validation check using regex to ensure that the form
        /// contains only integers and commas. 
        /// </summary>
        /// <returns><c>true</c>, if form was validated, <c>false</c> otherwise.</returns>
        /// <param name="OriginalNumbers">Original numbers.</param>
        private bool ValidateForm(ref string OriginalNumbers)
        {

            var regexContainsNumbersDelimitedByCommas = @"^\d+,{1}(\d+,{1})*\d+$";
            Match match = Regex.Match(OriginalNumbers, regexContainsNumbersDelimitedByCommas);

            if (!match.Success)
            {
                return false;
            }

            return true;
        }
    }
}