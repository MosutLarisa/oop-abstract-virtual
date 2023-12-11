namespace OopAbstractVirtual
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public static void Print()
        {
            Console.WriteLine("Printing from Shape");
        }
    }
}
