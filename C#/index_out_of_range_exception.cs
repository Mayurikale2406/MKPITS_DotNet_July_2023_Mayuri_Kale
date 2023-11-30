using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] arr = new int[3];
            arr[0] = 22;
            arr[1] = 33;
            arr[2] = 44;
            try
            {
                for(int i=0;i<=2;i++)
                {
                    Console.WriteLine("arr : "  + arr[i]);
                }
            }
            catch(IndexOutOfRangeException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("finally block executing");
            }
            Console.WriteLine("bye");
        }
    }
}