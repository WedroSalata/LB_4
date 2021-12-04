using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace LB_4
{
    abstract class Shape
    {
        protected int _type;
        protected float _x;
        protected float _y;
        protected float _side1;
        protected float _side2;
        protected int _colorN;
        protected Color _color;
        protected float _area;
        protected Shape()
        {

        }
        // перегрузку
        protected Shape(int type, float x, float y, float width, float heigth, int color)
        {

        }

        public static float operator +(Shape c1, Shape c2)
        {
            return c1._area + c2._area;
        }
        public static float operator -(Shape c1, Shape c2)
        {
            return c1._area - c2._area;
        }
        public static bool operator <(Shape c1, Shape c2)
        {
            return c1._area < c2._area;
        }
        public static bool operator >(Shape c1, Shape c2)
        {
            return c1._area > c2._area;
        }
        public static Shape operator ++(Shape c1)
        {
            c1._x += 10;
            return c1;
        }
        public static Shape operator --(Shape c1)
        {
            c1._x -= 10;
            return c1;
        }
        public float GetX()
        {
            return _x;
        }
        public float GetY()
        {
            return _y;
        }
        public float GetSide1()
        {
            return _side1;
        }
        public float GetSide2()
        {
            return _side2;
        }
        public int GetColor()
        {
            return _colorN;
        }
        public int GetTyp()
        {
            return _type;
        }
        public float GetArea()
        {
            return _area;
        }

        abstract public void Draw(PictureBox pictBox);

    }
}
