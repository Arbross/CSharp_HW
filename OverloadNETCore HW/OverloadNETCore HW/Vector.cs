using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OverloadNETCore_HW
{
    public class Vector
    {
        private double x;
        private double y;
        public double X
        {
            get => x;
            set => x = value;
        }
        public double Y
        {
            get => y;
            set => y = value;
        }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Vector() : this(0.0f, 0.0f) { }
        public override string ToString()
        {
            return $"X(first) : {X}, Y(second) : {Y}, Length : {CountVectorLength()}";
        }
        public double CountVectorLength()
        {
            return Math.Sqrt((Math.Pow(X, 2)) + (Math.Pow(Y, 2)));
        }
        public static Vector operator +(Vector one, Vector two)
        {
            return new Vector((one.X + two.X), (one.Y + two.Y));
        }
        public static Vector operator -(Vector one, Vector two)
        {
            return new Vector((one.X - two.X), (one.Y - two.Y));
        }
        public static Vector operator *(Vector one, double num)
        {
            return new Vector((one.X * num), (one.Y * num));
        }
        public static double operator *(Vector one, Vector two)
        {
            return (one.X * one.Y) + (two.Y * two.X);
        }
        public static bool operator ==(Vector one, Vector two)
        {
            if (ReferenceEquals(one, two))
            {
                return true;
            }
            if (one is null)
            {
                return false;
            }
            return one.Equals(two);
        }
        public static bool operator !=(Vector one, Vector two)
        {
            return !(one == two);
        }
        public override bool Equals(object obj)
        {
            Vector tmp = obj as Vector;

            if (tmp == null)
            {
                return false;
            }
            return this.X == tmp.X && this.Y == tmp.Y;
        }
        public override int GetHashCode()
        {
            return ((double)this.X / Y).ToString().GetHashCode();
        }
        public static explicit operator double(Vector one)
        {
            return (double)one.CountVectorLength();
        }
        public static implicit operator Vector(double value)
        {
            return new Vector(value, 0);
        }
        public static Vector operator ++(Vector one)
        {
            return new Vector(one.X + 1, one.Y + 1);
        }
        public static Vector operator --(Vector one)
        {
            return new Vector(one.X - 1, one.Y - 1);
        }
        public static Vector operator -(Vector one)
        {
            return new Vector(-one.X, -one.Y);
        }
        public static bool operator true(Vector one)
        {
            return one.X > 0.0 && one.Y > 0.0;
        }
        public static bool operator false(Vector one)
        {
            return one.X == 0.0 && one.Y == 0.0;
        }
        private bool IsValidIndex(int index) => index >= 0 && index <= 1;
        public double this[int index]
        {
            get
            {
                if (!IsValidIndex(index))
                {
                    throw new Exception($"Invalid index. ({index})");
                }
                if (index == 0)
                {
                    return X;
                }
                else
                {
                    return Y;
                }
            }
            set
            {
                if (!IsValidIndex(index))
                {
                    throw new Exception($"Invalid index. ({index})");
                }
                if (index == 0)
                {
                    X = value;
                }
                else
                {
                    Y = value;
                }
            }
        }
        public double this[string index]
        {
            get
            {
                if (index.ToLower() == "x")
                {
                    return X;
                }
                else if (index.ToLower() == "y")
                {
                    return Y;
                }
                throw new Exception($"Invalid index. ({index ?? "null"})");
            }
        }
    }
}
