using System;


namespace SortApp
{
    class TylerTheCreator
    {
  
        //public TylerTheCreator(int n, int[] nums) : this(n = Int32.Parse(Console.ReadLine()), a = new nums[n]) { }



        //public void WriteArrayLength()
        //{

        //}
        public TylerTheCreator()
        {
            Console.WriteLine("If you want create a random array(with 10 elements) ,pls write 'rand' \t If you want create a yourself array, press Enter");
            string a = "rand";
            string c = Console.ReadLine();
            if (a == c) CreateRandomArray();
            else
            {
                CreateArray();
            }
            
            
        }

        public void CreateRandomArray()
        {
            int n = 10;
            int[] nums = new int[n];
            Random a = new Random();
            for (int i = 0; i < n; i++)
            {
                nums[i] = a.Next(10);
            }
            DisplayOnConsole con = new DisplayOnConsole(nums);

        }

        public void CreateArray()
        {
            int[] nums = { 0 };
            Console.WriteLine("Length: ");
            int n = Int32.Parse(Console.ReadLine());
            nums = new int[n];
            WriteYourValuesOfArray(nums);

            

        }
        public void WriteYourValuesOfArray(int[] nums)
        {
            

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Element {i}: \t");
                nums[i] = Int32.Parse(Console.ReadLine()); ;
                
            }
        }

    }
}
