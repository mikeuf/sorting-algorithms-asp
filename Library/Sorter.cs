using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.Controllers;

namespace SortingAlgorithms
{
    /// <summary>
    /// Contains several common sorting algorithms that can be used
    /// </summary>
    public class Sorter
    {
        // accumulates a string with each iteration of the sort for display
        public string EachIteration { get; set; }

        /// <summary>
        /// updates the current list of iterations for display
        /// </summary>
        /// <param name="nums">Nums.</param>
        internal void PrintList(ref List<int> nums)
        {
            EachIteration += string.Join(",", nums);
            EachIteration += Environment.NewLine;
        }

        internal void BubbleSort(ref List<int> nums)
        {
            // outer loops ascends through the vector
            for (int i = (nums.Count - 1); i > 0; --i)
            {
                // inner loop ascends to the current outer loop index
                for (int j = 0; j < i; ++j)
                {
                    // if the value on the left is larger than the right, swap them
                    // since we start on the left, we check to the right to avoid going out of bounds
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                    PrintList(ref nums);
                }
            }
        }

        internal void SelectionSort(ref List<int> nums)
        {
            int minIdx = 0;
            for (int i = 0; i < (nums.Count); ++i)
            {
                // set the minimum index to the current outer loop index
                minIdx = i;
                // now check the remaining subset,
                for (int j = i + 1; j < (nums.Count); ++j)
                {
                    // compare the current min value to each remaining value and set the min index to the lowest found
                    if (nums[minIdx] > nums[j])
                    {
                        minIdx = j;
                    }
                }
                // swap the new min value with the current position of the outer loop (i)
                int temp = nums[i];
                nums[i] = nums[minIdx];
                nums[minIdx] = temp;
                PrintList(ref nums);
            }
        }

        internal void InsertionSort(ref List<int> nums)
        {
            // outer loop ascends the array
            for (int i = 1; i < nums.Count; ++i)
            {
                // inner loop starts at current i location
                // decrement until it hits zero or the left (-1) element is bigger than the right
                for (int j = i; (j > 0) && (nums[j - 1] > nums[j]); --j)
                {
                    // swap the larger left value with the smaller right value, so the bigger value is to the right
                    int temp = nums[j];
                    nums[j] = nums[j - 1];
                    nums[j - 1] = temp;
                }
                PrintList(ref nums);
            }
        }

        internal void MergeSort(ref List<int> A)
        {
            PrintList(ref A);
            // stub overload function to allow for one argument calls
            List<int> B = new List<int>();
            MergeSort(ref A, ref B, 0, A.Count - 1);
        }

        internal void MergeSort(ref List<int> A, ref List<int> B, int p, int r)
        {
            if (p < r)
            { // if the current array is not a singleton
                int q = (p + r) / 2; // get the midpoint
                MergeSort(ref A, ref B, p, q); // process the left partition
                MergeSort(ref A, ref B, q + 1, r); // process the right partition
                Merge(ref A, ref B, p, q, r); // combine partitions into one sorted set
            }
        }

        internal void Merge(ref List<int> A, ref List<int> B, int p, int q, int r)
        {

            // Summary:
            // This function makes a copy of the original array (A) to a temp array (B).
            // The arrays are logically partitioned into left and right halves.
            // The smallest element is copied to left side of the original array (A).
            //
            // Partitions:
            // A[p/lFront..lBack][q+1/rFront..rBack]]
            //
            //  B = A; // merge sorts use at least one extra array to assist with sorting

            // merge sorts use at least one extra array to assist with sorting
            // Using the Clear() and AddRange() to force a deep copy of the array
            // This is probably not super peformant, but it keeps things simple for now
            B.Clear();
            B.AddRange(A);

            int lFront = p; // first element of "left" subset
            int lBack = q; // last element of "left" subset
            int rFront = q + 1; // first element of "right" subset
            int rBack = r; // last element of "right" subset. Duplicated from existing "r" for readability

            while (lFront <= lBack && rFront <= rBack)
            {  // These are comparing indices, not the actual values.
                if (B[lFront] < B[rFront])
                { // Notice that this comparison is only looking at array B.
                    A[p] = B[lFront];  // Copy from the *left* partition, on array B, to current position on array A.
                    ++lFront;  // The more this gets incremented, the fewer "leftovers" are copied later.
                }
                else
                {
                    A[p] = B[rFront];  // Copy from the *right* partition, on array B, to current position on array A
                    ++rFront; // Notice that this is a different index than what gets incremented in the first condition.
                }
                ++p;
            }

            // Copy any remaining elements from the left partition, only.
            // Don't copy from the right partition because they are already there since
            // we are just overwriting elements over the A.
            int leftovers = q - lFront; // leftovers may be negative if the subset is only 
                                        // one element and lFront was incremented in the while loop.
                                        // A negative value prevents any further copying.
            for (int i = 0; i <= leftovers; ++i)
            {  // A[p+1] is one more from where the while loop left off.
                A[p + i] = B[lFront + i];  // if lFront was not incremented, this will copy 
                                           // elements starting from B[0]
            }
            PrintList(ref A);
        }


        internal void QuickSort(ref List<int> nums)
        {
            PrintList(ref nums);
            // overload stub function to allow for single argument calls
            QuickSort(ref nums, 0, nums.Count - 1);
        }

        internal void QuickSort(ref List<int> A, int p, int r)
        {
            if (p < r)
            {  //  partition until there is only one element left
                int q = Partition(ref A, p, r);
                QuickSort(ref A, p, q - 1);  // sort left subset, excluding the pivot
                QuickSort(ref A, q + 1, r);  // sort right subset, excluding the pivot
            }
        }

        internal int Partition(ref List<int> A, int p, int r)
        {
            // Summary:
            // This function sorts the array into two partitions:
            // 1. (Left) Elements that are less-than-or-equal to the pivot.
            // 2. (Right) Elements that are greater than the pivot.
            //
            // Variables:
            // p = front/beginning of the array
            // r = back/end of the array, initial pivot location
            // i = index for the smaller numbers
            // j = index that scans the entire array (except for the pivot).
            //
            // Partitions:
            // A[[p..r-1][pivot/r]] is the subset layout at the beginning
            // A[[lower numbers][higher numbers][pivot]] is the desired logical layout while sorting
            // A[[p..i][i+1..j][pivot/r]] is how the i and j align with the subsets while sorting
            // Lower numbers will be placed within [p..i] on the left
            // Higher numbers will be placed within [i+1..j] on the right
            // The pivot is initially placed at far-right [r].
            //
            // The function ultimately sets the pivot such that (Lower numbers) <= Pivot < (Higher numbers)
            // A[[lower numbers][pivot][higher numbers]] is how it will look after it is sorted, and pivot swapped
            // A[[p..i][pivot(i+1)][j..r-1][r]] at the end, the pivot is swapped with the first large number (i + 1)
            // The end result is that the pivot should be >= all numbers to the left and < all numbers to the right
            // The pivot is then returned to the caller
            int i = p - 1; // set i to just before the beginning of the partition, allowing for upcoming increments
            for (int j = p; j < r; ++j)
            {  // scan, starting from left up to the pivot (on the right)
                if (A[j] <= A[r])
                {  // find small numbers, swap them with A[i] so smaller elements are all on the left
                    ++i;
                    int temp2 = A[i];
                    A[i] = A[j];
                    A[j] = temp2;
                }
            }
            int temp = A[i + 1];
            A[i + 1] = A[r];
            A[r] = temp;
            //   std::swap(A[i + 1], A[r]); // swap the pivot with the first large number
            // now the pivot is to the right of the smaller numbers and to the left of the larger ones
            PrintList(ref A);
            return i + 1; // return the pivot
        }


    }
}
