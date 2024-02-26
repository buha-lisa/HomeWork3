namespace hw3
{
    class Square
    {
        public void DrowSquare(int size, char side)
        {
            for (int i = 0; i < size; i++) 
            {
                Console.Write(side);
            }
            Console.Write('\n');
            for (int i = 0; i < size-2; i++)
            {
                Console.Write(side);
                for (int j = 1; j < size-1; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine(side);
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(side);
            }
        }
    }

    class Palindrome
    {
        public bool IfPalindrome(int num)
        {
            int n = num, reverse = 0, rem;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            if (num == reverse) { return true; }
            return false;
        }
    }

    class ArrayFilter
    {
        public void Filter(int[] original, int[] filter)
        {
            int[] result = new int[original.Length];
            for (int i = 0; i < original.Length;  i++) 
            {
                for (int j = 0; j < filter.Length; j++) 
                {
                    if (original[i] != filter[j])
                    {
                        result[i] = original[i];
                    }
                }
            }
            Console.WriteLine("\nResult array: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + ' ');
            }
        }
    }

    internal class homeWork3
    {
        public static void Task1() 
        {
            Square square = new Square();
            Console.Write("\nEnter the size of square: ");
            int.TryParse(Console.ReadLine(), out int size);
            Console.Write("Enter the side of square: ");
            char.TryParse(Console.ReadLine(), out char side);
            square.DrowSquare(size, side);
        }
        public static void Task2() 
        {
            Palindrome palindrome = new Palindrome();
            Console.Write("\nEnter the number to check: ");
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine(palindrome.IfPalindrome(num));
        }
        public static void Task3() 
        {
            ArrayFilter filter = new ArrayFilter();
            Console.Write("\nEnter the size of original array: ");
            int.TryParse(Console.ReadLine(), out int size1);
            int[] original = new int[size1];
            Console.WriteLine("Enter array: ");
            for (int i = 0; i < original.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out original[i]);
            }

            Console.Write("\nEnter the size of filter array: ");
            int.TryParse(Console.ReadLine(), out int size2);
            int[] filt = new int[size2];
            Console.WriteLine("Enter array: ");
            for (int i = 0; i < filt.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out filt[i]);
            }

            Console.WriteLine("\nOriginal array: ");
            for (int i = 0; i < original.Length; i++)
            {
                Console.Write(original[i] + ' ');
            }
            Console.WriteLine("\nFilter array: ");
            for (int i = 0; i < filt.Length; i++)
            {
                Console.Write(filt[i] + ' ');
            }
            filter.Filter(original, filt);

        }
    }
}
