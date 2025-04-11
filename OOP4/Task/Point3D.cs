﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Point3D :IComparable<Point3D> ,  ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x , int y , int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D(int x , int y) : this(x , y , 0) { }

        public Point3D() : this(0, 0, 0) { }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public static bool operator ==(Point3D P1 , Point3D P2)
        {
            if (ReferenceEquals(P1, null) || ReferenceEquals(P2, null))
                return ReferenceEquals(P1, P2);

            return P1.X == P2.X && P1.Y == P2.Y && P1.Z == P2.Z;

        }

        public static bool operator !=(Point3D P1, Point3D P2)
        {
            return !(P1 == P2);

        }
        public override bool Equals(object? obj)
        {
           if(obj is Point3D P)
            {
                return this == P;

            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X,Y,Z);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public int CompareTo(Point3D other)
        {
            if(X == other.X)
            {
                return Y.CompareTo(other.Y);
            }
            return X.CompareTo(other.X);
        }


    }
}
