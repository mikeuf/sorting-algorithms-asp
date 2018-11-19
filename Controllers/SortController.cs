﻿using System;
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

public SortController(SortModelContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sort(string OriginalNumbers, string SortType)
        {
            var algos = from a in _context.Algorithms
                        where a.AlgorithmName == "Bubble Sort"
                            orderby a.AlgorithmID
                            select a;

            if ((OriginalNumbers == null) || !ValidateForm(ref OriginalNumbers))
            {
                return View("ValidationError");
            }

          //  ViewBag.AlgoName = _context.Algorithm.Select(x => x.AlgorithmName == "Bubble Sort").ToList();

         //   ViewBag.AlgoName = _context.Algorithm.First();

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