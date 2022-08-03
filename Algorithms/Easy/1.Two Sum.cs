public class Solution
{    
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
            }
        }
        return null;
    }
}
/*
Runtime: 161 ms, faster than 92.78% of C# online submissions for Two Sum.
Memory Usage: 44 MB, less than 20.62% of C# online submissions for Two Sum.
*/