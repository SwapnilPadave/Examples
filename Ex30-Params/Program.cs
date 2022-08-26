using System;

namespace Ex30_Params
{

    //class Params
    //{
    //    public static int Add(params int[] list)
    //    {
    //        int Total = 0;
    //        foreach(int i in list)
    //        {
    //            Total += i;
    //        }
    //        return Total;
    //    }
    //    static void Main(string[] args)
    //    {
    //        int y = Add(2, 4, 6, 8, 10, 12, 14, 16);
    //        Console.WriteLine(y);
    //    }
    //}    

    class Params
    {
        public void result(params object[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main()
        {
            Params p = new Params();
            p.result("Swapnil", "p", "Swapnil 2.0", "101");
        }
    }
}
