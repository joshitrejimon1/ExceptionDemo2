namespace ExceptionDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inside Main");
            try 
            {
                F1();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("Back IN Main");
        }

        private static void F1()
        {
            Console.WriteLine("Inside F1");
            F2();
            Console.WriteLine("back in F1");// will not get executed 
        }

        private static void F2()
        {
            Console.WriteLine("inde F2");
            int n1 = 10, n2 = 0, result = 0;

            result=n1/n2;
            Console.WriteLine("hellow");
        }
    }
}