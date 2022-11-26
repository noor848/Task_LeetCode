public class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {

        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> counts = new List<int>();

        if (s.Length > 0 && string.IsNullOrEmpty(s.Trim()))
        {
            return 1;
        }
        if (s.Length == 1)
        {
            return 1;
        }
        s = s.Trim();
        if (!string.IsNullOrEmpty(s))
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int k = i; k < s.Length; k++)
                {

                    if (!dict.ContainsKey(s[k]))
                    {
                        dict.Add(s[k], k);
                    }
                    else
                    {
                        counts.Add(dict.Count);
                        dict.Clear();
                        break;
                    }


                }

            }
            return counts.Max();
        }
        return 0;
    }


    public static void Main()
    {
        Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
    }

        
}