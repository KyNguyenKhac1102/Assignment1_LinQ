using System;
using System.Linq;
using System.Collections.Generic;


namespace as1
{
    class Program
    {
        static List<intern> internList = new List<intern>{
            new intern{FirstName = "Ky", 
                        LastName = "Nguyen Khac", 
                        Gender = "Male", 
                        DateOfBirth = new DateTime(1999, 11, 12),
                        PhoneNumber = "0222.222.222",
                        BirthPlace = "Ha Noi",
                        Age = 18,
                        IsGraduated = false},
            new intern{FirstName = "Trang",
                        LastName = "Huyen Nguyen",
                        Gender = "Female",
                        DateOfBirth = new DateTime(2002, 05, 21),
                        PhoneNumber = "0222.222.222",
                        BirthPlace = "Hai Phong",
                        Age = 18,
                        IsGraduated = false},
            new intern{FirstName = "Tuan",
                        LastName = "Trinh Dat",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1994, 01, 15),
                        PhoneNumber = "0222.222.222",
                        BirthPlace = "Bac Ninh",
                        Age = 18,
                        IsGraduated = false},
            new intern{FirstName = "Cong",
                        LastName = "Nguyen Van",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1996, 08, 12),
                        PhoneNumber = "0222.222.222",
                        BirthPlace = "Ha Noi",
                        Age = 18,
                        IsGraduated = false},
            new intern{FirstName = "Phuoc",
                        LastName = "Hoang Nhat",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1998, 06, 18),
                        PhoneNumber = "0222.222.222",
                        BirthPlace = "Bac Ninh",
                        Age = 18,
                        IsGraduated = false},
            new intern{FirstName = "Long",
                        LastName = "Thang Bao",
                        Gender = "Male",
                        DateOfBirth = new DateTime(2000, 07, 12),
                        PhoneNumber = "0222.222.222",
                        BirthPlace = "Binh Duong",
                        Age = 18,
                        IsGraduated = false},
        };
        
        static void Print(List<intern> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.FullName());
            }
        }

        static void PrintStringList(List<string> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintMaleMembers(List<intern> list)
        {
            List<intern> returns = list.Where(x => x.Gender == "Male").ToList();
            Print(returns);
        }

        public static void PrintOldestAgeOne(List<intern> list)
        {

            List<intern> results = list.Where(x => x.Age == list.Max(x => x.Age)).ToList();
            intern result = results.First();

            Console.WriteLine(result.FullName() + " (" + result.Age + ")");
        }


        public static void PrintFullName(List<intern> list)
        {
            List<string> results = list.Select(x => x.FullName()).ToList();

            PrintStringList(results);
        }

        public static void PrintSplitMembersByYears(List<intern> list)
        {
            var l1 = list.Where(x => x.DateOfBirth.Year == 2000).ToList();
            var l2 = list.Where(x => x.DateOfBirth.Year > 2000).ToList();
            var l3 = list.Where(x => x.DateOfBirth.Year < 2000).ToList();

            Console.WriteLine("List of members born in 2000 is: ");
            Print(l1);
            Console.WriteLine("List of members birth year greater than 2000 is: ");
            Print(l2);
            Console.WriteLine("List of members birth year lesser than 2000 is: ");
            Print(l3);
        }

        public static void PrintFristBornHaNoi(List<intern> list, string location)
        {
            var results = list.Where(x => x.BirthPlace.Equals(location, StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine(results.First().FullName());
        }
        public static void createInternList()
        {
        }
        static void Main(string[] args)
        {
            createInternList();
            Console.WriteLine("1.List of Male members is: ");
            PrintMaleMembers(internList);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("2.The first oldest members is: ");
            PrintOldestAgeOne(internList);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("3.Full Name of all members: ");
            PrintFullName(internList);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("4.");
            PrintSplitMembersByYears(internList);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("5.The first member born in Ha Noi is: ");
            PrintFristBornHaNoi(internList, "HA NOI");
        }
    }
}