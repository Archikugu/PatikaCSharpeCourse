using System;
using System.Collections.Generic;

namespace ToDoConsoleApp
{
    internal partial class Program
    {
        public class Board
        {
            public Dictionary<BoardLine, List<Card>> Lines { get; }

            public Board()
            {
                Lines = new Dictionary<BoardLine, List<Card>>
        {
            { BoardLine.TODO, new List<Card>() },
            { BoardLine.IN_PROGRESS, new List<Card>() },
            { BoardLine.DONE, new List<Card>() }
        };
            }
        }

        static void ListBoard(Board board)
        {
            foreach (var line in board.Lines)
            {
                Console.WriteLine(line.Key.ToString());
                Console.WriteLine("************************");
                foreach (var card in line.Value)
                {
                    Console.WriteLine($"Başlık: {card.Title}");
                    Console.WriteLine($"İçerik: {card.Content}");
                    Console.WriteLine($"Atanan Kişi: {card.AssignedMemberID}");
                    Console.WriteLine($"Büyüklük: {card.Size}");
                    Console.WriteLine();
                }
            }
        }
    }
}