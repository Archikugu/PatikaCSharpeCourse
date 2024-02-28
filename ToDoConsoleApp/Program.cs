using System;
using System.Collections.Generic;

namespace ToDoConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, TeamMember> teamMembers = new Dictionary<int, TeamMember>
        {
            { 1, new TeamMember(1, "Ahmet") },
            { 2, new TeamMember(2, "Mehmet") },
            { 3, new TeamMember(3, "Ayşe") }
        };


            Board defaultBoard = new Board();
            defaultBoard.Lines[BoardLine.TODO].Add(new Card("Başlık1", "İçerik1", 1, Size.M));
            defaultBoard.Lines[BoardLine.IN_PROGRESS].Add(new Card("Başlık2", "İçerik2", 2, Size.S));
            defaultBoard.Lines[BoardLine.DONE].Add(new Card("Başlık3", "İçerik3", 3, Size.XL));

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:

                            ListBoard(defaultBoard);
                            break;
                        case 2:

                            AddCard(defaultBoard, teamMembers);
                            break;
                        case 3:

                            RemoveCard(defaultBoard);
                            break;
                        case 4:
                            MoveCard(defaultBoard);
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı seçin.");
                }
            }
        }
    }
}