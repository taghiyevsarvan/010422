using System;

namespace _010422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Name = "varli ata kasib ata",
                AuthorName = "robert kiyosaki",
                PageCount = 188    

            };

            Book book2 = new Book()
            {
                Name = "59 saniye",
                AuthorName = "Ricard Vayzman",
                PageCount = 320
            };

            Book book3 = new Book()
            {
                Name = "Sefiiler",
                AuthorName = "Vuktor Huqo",
                PageCount = 450
            };

            Library library1 = new Library();
            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);


            Console.WriteLine("==========MENU=========");
            Console.WriteLine("1-FindAllBooksByName\n2-RemoveAllBookByName\n3-SearchBooks\n4-FindAllBooksByPageCountRange\n5-RemoveByCode");
            Console.Write("Seciminiz: ");
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================");
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Axtarilacaq kitablarin adi: ");
                    string findName = Console.ReadLine();
                    ;
                    foreach (var item in library1.FindAllBooksByName(findName))
                    {
                        Console.WriteLine($"No:{item.No} Name:{item.Name} AuthorName:{item.AuthorName} Page Count:{item.PageCount} ");
                    }
                    break;
                    
                case 2:
                    Console.WriteLine("Silinecek kitablarin adin daxil edin:");
                    string removName = Console.ReadLine();
                    library1.RemoveAllBookByName(removName);
                    break;
                case 3:
                    Console.WriteLine("Axtarilacaq kitablarin adi");
                    //Search Metodun yaza bilmedim deye bu hisse qaldi
                    break;
                case 4:
                    Console.Write("Min: ");
                    int minVal = int.Parse(Console.ReadLine());
                    Console.Write("Max: ");
                    int maxVal = int.Parse(Console.ReadLine());

                    foreach (var item in library1.FindAllBooksByPageCountRange(minVal,maxVal))
                    {
                        Console.WriteLine($"No:{item.No} Name:{item.Name} AuthorName:{item.AuthorName} Page Count:{item.PageCount} ");
                    }
                    break;
                case 5:
                    Console.Write("Silinecek kitab No deyeri: ");
                    int noVal = int.Parse(Console.ReadLine());
                    library1.RemoveByCode(noVal);
                    break;
                default:
                    break;
            }



        }
    }
}
