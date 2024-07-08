/*
LEETCODE CHALLENGE: Median of Two Sorted Arrays
LINK: https://leetcode.com/problems/median-of-two-sorted-arrays
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)). 

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.
Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
*/

double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int[] combinedArr = [.. nums1, .. nums2];
    Array.Sort(combinedArr);

    double medianVal;
    if (combinedArr.Length % 2 == 0)
    {
        int[] medianIdxArr = {(combinedArr.Length/2), (combinedArr.Length / 2)-1 };
        medianVal = (combinedArr[medianIdxArr[0]] + combinedArr[medianIdxArr[1]])/2.0;
    }
    else
    {
        medianVal = combinedArr[(combinedArr.Length-1)/2];
    }
    return medianVal;
}

int[] arr1 = { 1, 2 };
int[] arr2 = {3, 4};   

Console.WriteLine(FindMedianSortedArrays(arr1, arr2));
