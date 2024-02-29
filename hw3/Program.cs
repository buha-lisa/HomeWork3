namespace hw3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the task(1-6):  ");
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
                case 4:
                    homeWork3.Task4();
                    break;
                case 5:
                    homeWork3.Task5();
                    break;
                case 6:
                    homeWork3.Task6();
                    break;
                default: 
                    Console.WriteLine("Task is incorrect!"); 
                    break;
            }
        }
    }
}
