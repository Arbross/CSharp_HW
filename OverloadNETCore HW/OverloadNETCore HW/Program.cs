using System;

namespace OverloadNETCore_HW
{
    class Program
    {
        static void Main()
        {
            Vector vec = new Vector(0.0, 5.0);
            Vector new_vec = new Vector(0.0, 6.0);
            Console.WriteLine(vec.ToString());
            vec.X = 1;
            vec.Y = 6;
            vec.GetHashCode();
            Console.WriteLine(vec.X);
            Console.WriteLine(vec.Y);
            Console.WriteLine(vec.ToString());
            vec.X++;
            vec.Y++;
            Console.WriteLine(vec.ToString());
            Console.WriteLine($"To double : {(double)vec}");
            Console.WriteLine((double)vec.X);
            vec = -vec;
            Console.WriteLine(vec.ToString());

            Console.WriteLine($"X : {vec[0]}");
            Console.WriteLine($"Y : {vec[1]}");

            Console.WriteLine($"X(by string) : {vec["x"]}");
            Console.WriteLine($"Y(by string) : {vec["y"]}");

            vec++;
            vec++;
            vec--;
            Console.WriteLine($"Vector from ++, ++ and -- : {vec.ToString()}");

            new_vec += vec;
            Console.WriteLine($"New vec + : {new_vec.ToString()}");
            new_vec -= vec;
            Console.WriteLine($"New vec - : {new_vec.ToString()}");
            new_vec *= 3.0;
            Console.WriteLine($"New vec * on num : {new_vec.ToString()}");
            new_vec *= vec;
            Console.WriteLine($"New vec * on vec : {new_vec.ToString()}");
            
            if (vec == new_vec)
            {
                Console.WriteLine("Great!");
            }
            else if (vec != new_vec)
            {
                Console.WriteLine("Isn't great.");
            }

            Console.WriteLine(vec == 0.1);
            Console.WriteLine(vec != 0.1);
            // new_vec = vec;
            Console.WriteLine(vec.Equals(new_vec));
        }
    }
}
