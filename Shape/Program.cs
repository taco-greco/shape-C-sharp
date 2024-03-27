// See https://aka.ms/new-console-template for more information

using Shape;
class Program
{
    static void Main(string[] args)
    {
        Form[] shapes = new Form[]
        {
            new Square {Side = 4 }
        };
        
        foreach (var shape in shapes) 
        {
            double area = shape.Area();
            Console.WriteLine(area);    
        }

    }
}