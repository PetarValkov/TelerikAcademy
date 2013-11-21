using System;
using System.Threading;
using System.Collections.Generic;

class FallingRocks
{
    class Dwarf
    {
        private int dwarfCol;
        private int dwarfRow;

        public Dwarf()
        {
            dwarfCol = Console.WindowWidth / 2;
            dwarfRow = Console.WindowHeight + 4;
        }

        public void DrawDwarf()
        {
            Console.SetCursorPosition(dwarfCol, dwarfRow);
            Console.WriteLine("(0)");
            Console.SetCursorPosition(80, 1);
        }

        public int DwarfRow
        {
            get
            {
                return dwarfRow;
            }
        }

        public int DwarfCol
        {
            get
            {
                return dwarfCol;
            }
        }
        
        public void MoveDwarf(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.RightArrow)
            {
                if (dwarfCol < 80)
                {
                    dwarfCol++;
                }
            }
            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (dwarfCol > 0)
                {
                    dwarfCol--;
                }
            }
        }
    }

    class Rocks
    {
        private int rockCol;
        private int rockRow;
        private string symbol;



        public Rocks()
        {
            rockCol = 0;
            rockRow = 0;
            symbol = "*";
        }

        public Rocks(int row, int col, string charSymbol)
        {
            rockCol = col;
            rockRow = row;
            symbol = charSymbol;
        }

        public int RockRow
        {
            get
            {
                return rockRow;
            }
            set
            {
                rockRow = value;
            }
        }

        public int RockCol
        {
            get
            {
                return rockCol;
            }
        }

        public string RockSymbol
        {
            get
            {
                return symbol;
            }
            set
            {
                symbol = value;
            }
        }

        public void DrawRock(int row, int col, string symbol)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }
    }

    static void Main(string[] args)
    {
        Dwarf dwarf = new Dwarf();
        Rocks rock = new Rocks();
        List<Rocks> rocks = new List<Rocks>();
        Random randomGenerator = new Random();
        string[] arrayRock;
        arrayRock = new string[] { "+", "*", "-", "#", "$", "%", "^", "&", "@", "+++", "---" };
        int points = 0;

        Console.WindowHeight = 30;
        Console.BufferHeight = 30;

        Console.WindowWidth = 100;
        Console.BufferWidth = 100;

        while (true)
        {
            Console.Clear();
            dwarf.DrawDwarf();

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                dwarf.MoveDwarf(key);
            }

            rocks.Add(new Rocks(0,randomGenerator.Next(0,80),arrayRock[randomGenerator.Next(0,10)]));

            
            rocks.RemoveAll(i => i.RockRow == Console.WindowHeight);
            
            foreach (var Rock in rocks)
            {
                Rock.DrawRock(Rock.RockRow,Rock.RockCol, Rock.RockSymbol);
            }

            foreach (var Rock in rocks)
            {
                Rock.RockRow++;

                if (Rock.RockRow == Console.WindowHeight)
                {
                    
                     points += 10;
                }
            }

            foreach (var Rock in rocks)
            {
                if ((Rock.RockCol == dwarf.DwarfCol && Rock.RockRow == dwarf.DwarfRow) ||
                    (Rock.RockCol == dwarf.DwarfCol + 1 && Rock.RockRow == dwarf.DwarfRow) ||
                    (Rock.RockCol == dwarf.DwarfCol + 2 && Rock.RockRow == dwarf.DwarfRow))
                {
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                    Console.WriteLine("GAME OVER");

                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 1);
                    Console.WriteLine("Your score is: {0}",points);
                    Environment.Exit(1);
                }
            }

            Console.SetCursorPosition(78, 0);
            Console.WriteLine("Your points are: {0}",points);
            Thread.Sleep(150);
        }
    }
}

