public class Solution
{
    public int PivotIndex(int[] nums)
    {

        int left = 0, right = 0;
        int pivot = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            pivot = i;
            left = 0; right = 0;
            int j = i;
            while (j < nums.Length)
            {

                if (j + 1 < nums.Length)
                {
                    right += nums[j + 1];

                }
                j++;

            }


            j = i;
            while (j > 0)
            {


                if ((i - 1) >= 0)
                {
                    left += nums[j - 1];
                }
                j--;

            }
            if (left == right) return pivot;
        }

        return -1;
    }
}