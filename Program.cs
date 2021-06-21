using System;
using System.Linq;
using System.Collections.Generic;


namespace as1
{
    class Program
    {
        static List<intern> internList = new List<intern>();

        static void Print(List<intern> list){
            foreach(var i in list){
                Console.WriteLine(i.FullName());
            }
        }

        static void PrintStringList(List<string> list){
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintMaleMembers(List<intern> list){
            List<intern> returns = list.Where(x => x.Gender == "Male").ToList();
            Print(returns);
        }

        public static void PrintOldestAgeOne(List<intern> list){
            
            List<intern> results = list.Where(x => x.Age == list.Max(x => x.Age)).ToList();
            intern result = results.First();

            Console.WriteLine(result.FullName() + " (" + result.Age + ")");
        }


        public static void PrintFullName(List<intern> list){
            List<string> results = list.Select(x => x.FullName()).ToList();

            PrintStringList(results);
        }

        public static void PrintSplitMembersByYears(List<intern> list){
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

        public static void PrintFristBornHaNoi(List<intern> list, string location){
            var results = list.Where(x => x.BirthPlace.Equals(location, StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine(results.First().FullName()); 
        }
        public static void createInternList(){
            

            intern kyNguyen = new intern("Ky", "Nguyen Khac", "Male", new DateTime(1999, 11, 12), "0222.222.222", "Ha Noi", 18, false);
            intern trangHuyen = new intern("Trang", "Nguyen Huyen", "Female", new DateTime(2002, 05, 21), "0222.222.222", "Hai Phong", 18, false);
            intern tuanDat = new intern("Tuan", "Trinh Dat", "Male", new DateTime(1994, 01, 15), "0222.222.222", "Bac Ninh", 18, false);
            intern congVan = new intern("Cong", "Nguyen Van", "Male", new DateTime(1996, 08, 12), "0222.222.222", "Ha Noi", 18, false);
            intern nhatHoang = new intern("Phuoc", "Hoang Nhat", "Male", new DateTime(1998, 06, 18), "0222.222.222", "Bac Ninh", 18, false);
            intern baoLong = new intern("Long", "Thang Bao", "Male", new DateTime(2000, 07, 12), "0222.222.222", "Binh Duong", 18, false);

            internList.Add(kyNguyen);
            internList.Add(trangHuyen);
            internList.Add(tuanDat);
            internList.Add(congVan);
            internList.Add(nhatHoang);
            internList.Add(baoLong);
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
