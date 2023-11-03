using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_WK7
{

    /// <summary>
    ///  (use /// and it will automatically create a summary
    /// </summary>


    // you can make abstract static librarys which allow for all functions to be accessible, but the library cant be declared as an object
    //example as bellow. 

    public struct CustomVector
    {
        public float X = 0;
        public float Y = 0;
        public CustomVector(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
    public struct CustomPoint
    {
        public float X = 0;
        public float Y = 0;
        public CustomPoint(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    internal class Vector
    {
        public float X;
        public float Y;
    }
    internal class Object
    {
        public Vector Location = new();
        public Vector Movement = new();

        public float objectRadius = 5.0f;

        public float X;
        public float Y;

        //default 
        public Object()
        {

        }

    }

    internal abstract class MathLibrary
    {

        static public float PI = MathF.PI;


        static public CustomVector newVector(float x, float y)
        {
            CustomVector Vector2 = new CustomVector(x, y);
            return Vector2;
        }


        static public CustomVector newVector(CustomPoint point1, CustomPoint point2)
        {
            float X = point2.X - point1.X;
            float Y = point2.Y - point1.Y;
            CustomVector returningVector = new(X, Y);
            return returningVector;
        }

        //takes values of degrees
        static public CustomVector newVector(float Degrees)
        {
            //default scaled to 1. use scaling later to adjust scale of vector
            float Magnitude = 1.0f;
            float Radians = Degrees * PI / 180;
            float X = Magnitude * MathF.Cos(Radians);
            float Y = Magnitude * MathF.Sin(Radians);
            return new CustomVector(X, Y);
        }


        static public CustomVector addVectorsTogether(CustomVector v1 = new(), CustomVector v2 = new(), CustomVector v3 = new(), CustomVector v4 = new())
        {
            float X = v1.X + v2.X + v3.X + v4.X;
            float Y = v1.Y + v2.Y + v3.Y + v4.Y;

            CustomVector returningVector = new(X, Y);
            return returningVector;
        }
        static public float Magnitude(CustomVector vector1)
        {
            float magnitude = MathF.Sqrt((vector1.X * vector1.X) + (vector1.Y * vector1.Y));
            return magnitude;
        }


        static public CustomVector NormalizedVector(float x, float y)
        {
            return NormalizedVector(new(x, y));
        }
        static public CustomVector NormalizedVector(CustomVector vector1)
        {
            float magnitude = Magnitude(vector1);
            float X = vector1.X / magnitude;
            float Y = vector1.Y / magnitude;
            CustomVector VectorNormy = new CustomVector(X, Y);
            return VectorNormy;
        }

        static public CustomVector scaleVector(CustomVector vector, float scale)
        {
            float X = vector.X * scale;
            float Y = vector.Y * scale;

            // create vector and return
            CustomVector returningVector = new(X, Y);
            return returningVector;
        }


        static public float Collision(Object object1, Object object2)
        {
            CustomVector distance = newVector(new CustomPoint(object1.Location.X, object1.Location.Y), new CustomPoint(object2.Location.X, object2.Location.Y));

            float actualdistance = Magnitude(distance);

            float distanceBeforeCollision = object1.objectRadius + object2.objectRadius;

            float collision = distanceBeforeCollision - actualdistance;

            return collision;

        }



    }






}
