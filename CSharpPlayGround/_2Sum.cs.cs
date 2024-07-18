namespace CSharpPlayGround;

public class _2Sum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (dict.ContainsKey(complement))
            {
                return new int[] { dict[complement], i };
            }
            dict[nums[i]] = i;
        }
        return new int[] { -1, -1 };
    }
}
