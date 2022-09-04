/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for(int i = m-- + n-- - 1; i >= 0 && n >= 0; i--) {
            nums1[i] = (m < 0)
                ? nums2[n--]
                : (nums1[m] > nums2[n])
                    ? nums1[m--]
                    : nums2[n--];
        }
    }
}
// @lc code=end
