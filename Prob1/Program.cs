public class Solution
{

    public static  double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {

        int n = nums1.Length;
        int m = nums2.Length;

        int[] arr = new int[n + m];

        int k = 0;
        for (int i = 0; i < n; i++)
        {
            arr[k++] = nums1[i];
        }


        for (int i = 0; i < m; i++)
            arr[k++] = nums2[i];




        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
            Console.WriteLine(arr[i]);

        if ((n + m) % 2 == 0)
        {
            double v1 = arr[(n + m) / 2 - 1];
            double v2 = arr[((n + m) / 2)];
            return (v1 + v2) / 2;
        }



        return arr[((n + m) / 2)];

    }

    public static void Main()
    {
        int []arr ={1,2,3};
        int[] arr2 = { 1 };
        Console.WriteLine(FindMedianSortedArrays(arr, arr2));
    }

}
