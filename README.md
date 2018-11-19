# Sorting Algorithms with ASP.NET Core MVC
This is a web app that allows you to enter a set of numbers and choose from several different sorting algorithms to view the results.

## Table of Contents
**[How to Run this Program](#how-to-run-this-program)**  
**[Overview](#overview)**<br /> 

## How to Run this Program
You should be able to access this program directly from the following URL:<br />
http://159.203.176.44/
<br /><br />
As of this writing, there is no domain registered.<br />

## Overview
This program allows you to choose from the following sorting algorithms:
* Bubble Sort
* Selection Sort
* Insertion Sort
* Merge Sort
* Quick Sort

Once numbers have been entered and a sort has been selected, SortController peforms a form validation check using regex. If the set passes the check, it is parsed into a list which is sent, by reference, to Library/Sorter.cs, which performs the actual algorithms. It also keeps track of each iteration so the user can see each step of the process.

**Figure 1 - Insertion Sort**
![Insertion Sort](https://github.com/mikeuf/sorting-algorithms-asp/blob/master/1-insertion-sort.jpg "Insertion Sort")

**Figure 2 - Validation Error**
![Validation Error](https://github.com/mikeuf/sorting-algorithms-asp/blob/master/2-validation-error.jpg "Validation Error")
