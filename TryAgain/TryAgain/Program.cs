using System;


namespace SortApp

{
    class Program
    {
        static void Main(string[] args)
        {
            // Test test = new Test();
            int[] nums = { 0 };
            Console.WriteLine("Razmernost: ");
            int n = Int32.Parse(Console.ReadLine());
            nums = new int[n];




            SortsMethod num = new SortsMethod(nums);



            Console.ReadKey();
        }

    }

    class SortsMethod
    {

        public SortsMethod(int[] nums)
        {
            WriteNumbersValueOfArray(nums);

            BubbleSort(nums);
            

        }

        static void WriteNumbersValueOfArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Element {i}: ");
                nums[i] = Int32.Parse(Console.ReadLine()); ;
            }
        }
        static void BubbleSort(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        Swap(ref nums[i], ref nums[j]);
                    }
                }
            }
        }

        //static void QuickSort(int[] nums)
        //{



        //    int j = 0;
        //    int k = 0;

        //    static void Sort(int[] nums, int j, int k)
        //    {
        //        for (int i = nums.Length - 1; i - 1 < 0; )
        //        {
        //            if (nums[k] > nums[i]) { i--; j++; }
        //            else
        //            {

        //                Swap(ref nums[k], ref nums[i]);
        //                k++;
        //            }
        //    }
        //    for ()
        //    {

 
                


        //            for (; k < nums.Length - j;)
        //            {


        //                if (nums[k] < nums[i]) k++;
        //                else
        //                {
        //                    Swap(ref nums[k], ref nums[i]);

        //                    j++;
                            

        //                }
        //            }
        //        }

        //    }


        //}

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b =  temp;

        }
    }

  //  var quick_sort = function(array){ 
  //function partition(array, lo, hi)
  //  {
  //      var i = lo, j = hi + 1;
  //      while (true)
  //      {
  //          while (array[++i] < array[lo])
  //          {
  //              if (i == hi) break;
  //          }
  //          while (array[ — j] > array[lo])
  //          {
  //              if (j == lo) break;
  //          }
  //          if (i >= j) break;
  //          array.swap(i, j);
  //      }
  //      array.swap(lo, j);
  //      return j;
  //  }
  //  function sort(array, lo, hi)
  //  {
  //      if (hi <= lo) return;
  //      var j = partition(array, lo, hi);
  //      sort(array, lo, j - 1);
  //      sort(array, j + 1, hi);
  //  }
  //  sort(array, 0, array.length — 1);
 
  //return array;






}
