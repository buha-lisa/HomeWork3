namespace hw3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the task:  ");
            int.TryParse(Console.ReadLine(), out int task);
            switch (task)
            {
                case 1: 
                    homeWork3.Task1(); 
                    break;
                case 2: 
                    homeWork3.Task2(); 
                    break;
                case 3:
                    homeWork3.Task3();
                    break;
            }
        }
    }
}
