using System;

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

    class Website
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Descrip { get; set; }
        public string Ip { get; set; }
        public Website(string name, string url, string descrip, string ip) 
        {
            Name = name;
            Url = url;
            Descrip = descrip;
            Ip = ip;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Url:  {Url}");
            Console.WriteLine($"Descrip:\n{Descrip}");
            Console.WriteLine($"Ip:   {Ip}");
        }

    }

    class Magazine
    { 
        public string Name { get; set; }
        public string FoundYear { get; set; }
        public string Descript { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public Magazine(string name, string year, string descrip, string phone, string email) 
        {
            Name=name;
            FoundYear = year;
            Descript = descrip;
            PhoneNum = phone;
            Email = email;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:\t\t\t{Name}");
            Console.WriteLine($"Year of foundation:\t{FoundYear}");
            Console.WriteLine($"Descrip:\t\t{Descript}");
            Console.WriteLine($"Phone number:\t\t{PhoneNum}");
            Console.WriteLine($"Email:\t\t\t{Email}");
        }
    }

    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }   
        public string Descript { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public Shop(string name, string address, string descrip, string phone, string email)
        {
            Name = name;
            Address = address;
            Descript = descrip;
            PhoneNum = phone;
            Email = email;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:\t\t{Name}");
            Console.WriteLine($"Address:\t{Address}");
            Console.WriteLine($"Descrip:\t{Descript}");
            Console.WriteLine($"Phone number:\t{PhoneNum}");
            Console.WriteLine($"Email:\t\t{Email}");
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
        public static void Task4() 
        {
            Console.Write("Enter name of website:  ");
            string Name = Console.ReadLine();
            Console.Write("Enter url of website:  ");
            string Url = Console.ReadLine();
            Console.Write("Enter description of website:  ");
            string Descrip = Console.ReadLine();
            Console.Write("Enter ip of website:  ");
            string Ip = Console.ReadLine();

            Website website = new Website(Name, Url, Descrip, Ip);
            website.ShowInfo();
        }
        public static void Task5() 
        {
            Console.Write("Enter name of magazine:  ");
            string Name = Console.ReadLine();
            Console.Write("Enter year of foundation:  ");
            string Year = Console.ReadLine();
            Console.Write("Enter description of magazine:  ");
            string Descrip = Console.ReadLine();
            Console.Write("Enter phone number of magazine:  ");
            string Phone = Console.ReadLine();
            Console.Write("Enter email of magazine:  ");
            string Email = Console.ReadLine();

            Magazine magazine = new Magazine(Name, Year, Descrip, Phone, Email);
            magazine.ShowInfo();
        }
        public static void Task6() 
        {
            Console.Write("Enter name of shop:  ");
            string Name = Console.ReadLine();
            Console.Write("Enter address of shop:  ");
            string Address = Console.ReadLine();
            Console.Write("Enter description of shop:  ");
            string Descrip = Console.ReadLine();
            Console.Write("Enter phone number of shop:  ");
            string Phone = Console.ReadLine();
            Console.Write("Enter email of shop:  ");
            string Email = Console.ReadLine();

            Shop shop = new Shop(Name, Address, Descrip, Phone, Email);
            shop.ShowInfo();
        }
    }
}
