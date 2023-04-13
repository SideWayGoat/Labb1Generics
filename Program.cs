using System.Linq;

namespace Labb1Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxCollection = new BoxCollection
            {
                new Box(10, 10, 10),
                new Box(10, 10, 10),
                new Box(5, 6, 7),
                new Box(12, 6, 8),
                new Box(3, 4, 3)
            };


            DisplayBoxes(boxCollection);

            var check = boxCollection.Contains(boxCollection[2]) ? "The box exists " : "The box does not exist ";
            Console.WriteLine(check);
            boxCollection.Remove(boxCollection[3]);
            Console.WriteLine("---- After Remove ----");
            DisplayBoxes(boxCollection);


            Console.ReadKey();
        }
        public static void DisplayBoxes(BoxCollection boxes)
        {
            Console.WriteLine("--- Boxes that exsist in this moment ---");
            foreach (Box box in boxes)
            {
                Console.WriteLine($"The box with Height: {box.Height} Width: {box.Width} and Lenght: {box.Length} has volume: {box.Volume} cm3");
            }
        }
    }
}