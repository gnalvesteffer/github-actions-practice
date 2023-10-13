namespace ExampleClassLibrary
{
    public class DatePrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}