namespace Sinlgeton_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lunch MyOrder = Lunch.getInstance();
            MyOrder.setLunchOrder("Ham and cheese bread");
            
            Lunch MyOrder2 = Lunch.getInstance();
            MyOrder2.setLunchOrder("Mayo on bread");


            Lunch MyOrder3= Lunch.getInstance();
            Console.WriteLine(MyOrder3.getLunchOrder());

        }
    }
}      