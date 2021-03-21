using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHome_HW
{
    class House
    {
        private Team team;

        private List<Basement> basement;
        private List<Walls> wall;
        private List<Window> window;
        private List<Door> door;
        private List<Roof> roof;
        public House()
        {
            team = new Team();
            basement = new List<Basement>(1);
            wall = new List<Walls>(4);
            window = new List<Window>(4);
            door = new List<Door>(1);
            roof = new List<Roof>(1);
        }
        public void AddBasement(uint width, uint length, Basement.Type type)
        {
            basement.Add(new Basement(width, length, type));
        }
        public void AddWall(uint width, uint length)
        {
            wall.Add(new Walls(width, length));
        }
        public void AddWindow(uint width, uint length)
        {
            window.Add(new Window(width, length));
        }
        public void AddDoor(uint width, uint length, Door.Type type)
        {
            door.Add(new Door(width, length, type));
        }
        public void AddRoof(uint width, uint length, uint height)
        {
            roof.Add(new Roof(width, length, height));
        }
        public void Zvit()
        {
            team.PrintInfoAbout();
            foreach (var item in roof)
            {
                item.PrintInfoAbout();
            }
            foreach (var item in window)
            {
                item.PrintInfoAbout();
            }
            foreach (var item in door)
            {
                item.PrintInfoAbout();
            }
            foreach (var item in wall)
            {
                item.PrintInfoAbout();
            }
            foreach (var item in basement)
            {
                item.PrintInfoAbout();
            }
        }
        public void BuildHouse()
        {
            {
                Console.WriteLine("Roof : ");
                Console.Write("Enter height : "); uint height = uint.Parse(Console.ReadLine());
                Console.Write("Enter width : "); uint width = uint.Parse(Console.ReadLine());
                Console.Write("Enter length : "); uint length = uint.Parse(Console.ReadLine());

                AddRoof(width, length, height);
            }
            Console.WriteLine("Window : ");
            for (int i = 0; i < 4; i++)
            {
                {
                    Console.Write("Enter width : "); uint width = uint.Parse(Console.ReadLine());
                    Console.Write("Enter length : "); uint length = uint.Parse(Console.ReadLine());

                    AddWindow(width, length);
                }
            }
            {
                Console.WriteLine("Door : ");
                Console.Write("Enter width : "); uint width = uint.Parse(Console.ReadLine());
                Console.Write("Enter length : "); uint length = uint.Parse(Console.ReadLine());
                Console.Write("Enter type : "); uint type = uint.Parse(Console.ReadLine());

                AddDoor(width, length, (Door.Type)type);
            }
            {
                Console.WriteLine("Basement : ");
                Console.Write("Enter width : "); uint width = uint.Parse(Console.ReadLine());
                Console.Write("Enter length : "); uint length = uint.Parse(Console.ReadLine());
                Console.Write("Enter type : "); uint type = uint.Parse(Console.ReadLine());

                AddBasement(width, length, (Basement.Type)type);
            }
            for (int i = 0; i < 4; i++)
            {
                {
                    Console.WriteLine("Wall : ");
                    Console.Write("Enter width : "); uint width = uint.Parse(Console.ReadLine());
                    Console.Write("Enter length : "); uint length = uint.Parse(Console.ReadLine());

                    AddWall(width, length);
                }
            }
            Finish();
        }
        private void Finish()
        {
            Console.WriteLine("House building finished!");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j < 2 * i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
