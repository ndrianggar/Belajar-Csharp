using System;
using System.Collections.Generic;
using System.Linq;

namespace Method_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myComrade = {"1. Abbad bin Bisyr bin Waqash","2. Al Abbas bin Ubadah bin Nahdhah","3. Al Abbas bin Abdul Muthalib","4. Abdullah bin Abbas","5. Abdullah bin Abdullah bin Ubay bin Salul",
                                    "6. Abdullah bin Abu Bakar",
                                    "7. Abdullah bin Amr bin Haram",
                                    "8. Abdullah bin Amr bin Ash",
                                    "9. Abdullah bin Jahsy",
                                    "10. Abdullah bin Jubair",
                                    "11. Abdullah bin Hudzafah As Sahmi",
                                    "12. Abdullah bin Mas’ud",
                                    "13. Abdullah bin Rawahah",
                                    "14. Abdullah bin Salam",
                                    "15. Abdullah bin Umar bin Khattab",
                                    "16. Abdullah bin Al Za’bari",
                                    "17. Abdullah bin Zaid",
                                    "18. Abdullah bin Zubair",
                                    "19. Abdullah Dzul Bijadain",
                                    "20. Abdurrahman bin Abu Bakar"
                                };
            List<int> numbers = new List<int>() { 4, 3, 5, 6, 7, 8, 8, 8, 99, 9, 9, 99977, 77, 7, 878 };

            object[] mix = { "string", "d", new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 4, 3, 2 }, "dd" };
            //List<Warrior> wariors = new List<Warrior>();


            var addNumbers = from n in numbers
                             where n % 2 == 1
                             select n;

            var addNumberss = numbers.Where(n => (n % 2 == 1));

            Console.WriteLine(string.Join(", ", addNumbers));
        }
    }
}
