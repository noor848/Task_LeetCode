public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {


        Dictionary<char, char> charcters = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!charcters.ContainsKey(s[i]))
                charcters.Add(s[i], t[i]);
        }



        for (int i = 0; i < s.Length; i++)
        {
            char value;
            charcters.TryGetValue(s[i], out value);
            if (t[i] != value)
            {
                return false;
            }
        }




        Dictionary<char, char> c2 = new Dictionary<char, char>();

        for (int i = 0; i < t.Length; i++)
        {
            if (!c2.ContainsKey(t[i]))
                c2.Add(t[i], s[i]);
        }


        bool vv = true;
        for (int i = 0; i < t.Length; i++)
        {
            char v2;
            c2.TryGetValue(t[i], out v2);
            if (s[i] != v2)
            {
                return false;
            }
        }




        return true;







    }
}