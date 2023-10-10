namespace ExampleClassLibrary
{
    public class GuidPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine(Guid.NewGuid());
        }
    }
}