using System.Runtime.Intrinsics.X86;

namespace TaxCalcu1
{
    class Program
    {
        public static void Main(string[] args)
        {
       
            Console.Write(" Enter your monthly salary: ");
            TaxCompute compute = new TaxCompute(Convert.ToDouble(Console.ReadLine()));

            //Display
            Console.WriteLine(compute.getOuput());
           
        }


    }

   
   
}