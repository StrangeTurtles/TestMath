using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public float Distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
        }
        public float DistanceSqr(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (diffX * diffX + diffY * diffY + diffZ * diffZ);
        }
        

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }
        public static Vector3 operator *(float rhs, Vector3 lhs)
        {
            return new Vector3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }
        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        }
        public Vector3 Normalize()
        {
            float m = Magnitude();
            x /= m;
            y /= m;
            z /= m;
            return this;
        }
        public float Dot(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }
        public Vector3 Cross(Vector3 rhs)
        {
            return new Vector3(
            y * rhs.z - z * rhs.y,
            z * rhs.x - x * rhs.z,
            x * rhs.y - y * rhs.x);
        }
        public float AngleBetween(Vector3 other)
        {

            Vector3 a = Normalize();
            Vector3 b = other.Normalize();


            float d = a.Dot(b);


            return (float)Math.Acos(d);
        }
        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.m1 * rhs.x) + (lhs.m4 * rhs.y) + (lhs.m7 * rhs.z),
                        (lhs.m2 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m8 * rhs.z),
                        (lhs.m3 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m9 * rhs.z));
        }

        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
