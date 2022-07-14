public class Solution
{   public static  double FindMedianSortedArrays(int[] nums1, int[] nums2)
        int n = nums1.Length;
        int m = nums2.Length;
        int[] arr = new int[n + m];
        int k = 0;
        arr=Concat(nums1,nums2);
        if ((n + m) % 2 == 0){
            double median1 = arr[(n + m) / 2 - 1];
            double median2 = arr[((n + m) / 2)];
            return (median1 + median2) / 2;
        }
        return arr[((n + m) / 2)];
    }

    public static void Main(string args[])
    {
        int []arr ={1,2,3};
        int[] arr2 = { 1 };
        Console.WriteLine(FindMedianSortedArrays(arr, arr2)); 

    }

}
