namespace ExampleClassLibrary
{
    public class HelloWorldPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
