using System.Collections.Generic;
using System;

namespace ToDoConsoleApp
{
    internal partial class Program
    {
        public class Card
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public int AssignedMemberID { get; set; }
            public Size Size { get; set; }

            public Card(string title, string content, int assignedMemberID, Size size)
            {
                Title = title;
                Content = content;
                AssignedMemberID = assignedMemberID;
                Size = size;
            }
        }
        static void AddCard(Board board, Dictionary<int, TeamMember> teamMembers)
        {
            Console.WriteLine("Başlık Giriniz:");
            string title = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz:");
            string content = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5):");
            int sizeChoice;
            if (!int.TryParse(Console.ReadLine(), out sizeChoice) || sizeChoice < 1 || sizeChoice > 5)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı seçin.");
                return;
            }
            Size size = (Size)(sizeChoice - 1);
            Console.WriteLine("Kişi Seçiniz:");
            int memberId;
            if (!int.TryParse(Console.ReadLine(), out memberId) || !teamMembers.ContainsKey(memberId))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir takım üyesi ID'si seçin.");
                return;
            }
            int assignedMemberID = memberId;

            board.Lines[BoardLine.TODO].Add(new Card(title, content, assignedMemberID, size));
        }

        static void RemoveCard(Board board)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();

            bool cardRemoved = false;
            foreach (var line in board.Lines)
            {
                var cardToRemove = line.Value.Find(card => card.Title == title);
                if (cardToRemove != null)
                {
                    line.Value.Remove(cardToRemove);
                    cardRemoved = true;
                }
            }

            if (!cardRemoved)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
            }
        }

        static void MoveCard(Board board)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();

            Card cardToMove = null;
            foreach (var line in board.Lines)
            {
                cardToMove = line.Value.Find(card => card.Title == title);
                if (cardToMove != null)
                {
                    break;
                }
            }

            if (cardToMove == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
                return;
            }

            Console.WriteLine($"Bulunan Kart Bilgileri:\nBaşlık: {cardToMove.Title}, İçerik: {cardToMove.Content}, Atanan Kişi: {cardToMove.AssignedMemberID}, Büyüklük: {cardToMove.Size}");

            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");

            int lineChoice;
            if (int.TryParse(Console.ReadLine(), out lineChoice) && Enum.IsDefined(typeof(BoardLine), lineChoice - 1))
            {
                BoardLine newLine = (BoardLine)(lineChoice - 1);
                board.Lines[newLine].Add(cardToMove);
                Console.WriteLine("Kart başarıyla taşındı.");
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            }
        }
    }
}