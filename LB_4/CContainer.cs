using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_4
{
    class CContainer
    {
        private PictureBox pictBox;
        private List<Shape> shapes;
        public CContainer(PictureBox _pictBox)
        {
            pictBox = _pictBox;
            shapes = new List<Shape>();
        }
        // Малювання всіх елементів контейнеру
        //public Shape this[int i]
        //{
        //    get { return shapes[i]; }
        //}
        public void Draw()
        {
            for (int index = 0; index < shapes.Count; index++)
            {
                shapes[index].Draw(pictBox);
            }
        }
        // Отримання кількості елементів у контейнері
        public int GetLength()
        {
            return shapes.Count;
        }
        public List<Shape> GetList()
        {
            return shapes;
        }
        public string ToString(int index)
        {
            string out1 = Convert.ToString(shapes[index].GetTyp()) + " " + Convert.ToString(shapes[index].GetX()) + " " + Convert.ToString(shapes[index].GetY()) + " "
                + Convert.ToString(shapes[index].GetSide1()) + " " + Convert.ToString(shapes[index].GetSide2()) + " " + Convert.ToString(shapes[index].GetColor());
            return out1;
        }
        public float GetArea(int index)
        {
            return shapes[index].GetArea();
        }
        // Додавання нового об'єкта у контейнер, на задану позицію.
        public void AddAt(int type, float x, float y, float width, float heigth, int color, int index)
        {
            if (type == -1) { type = 0; }
            Shape ob;
            switch (type)
            {
                case 0:
                    ob = new Rectangle(type, x, y, width, heigth, color);
                    shapes.Insert(index, ob);
                    break;
                case 1:
                    ob = new Circle(type, x, y, width, heigth, color);
                    shapes.Insert(index, ob);
                    break;
                case 2:
                    ob = new SixAngle(type, x, y, width, heigth, color);
                    shapes.Insert(index, ob);
                    break;
            }
        }
        // Додавання нового об'єкта до контейнеру, на останнє місце.
        public void Add(int type, float x, float y, float width, float heigth, int color)
        {
            AddAt(type, x, y, width, heigth, color, shapes.Count);
        }
        // Видалення об'єкту з контейнера
        public void Remove(int index)
        {
            shapes.RemoveAt(index);
        }
        public float PlusArea(int index1, int index2)
        {
            return shapes[index1] + shapes[index2];
        }
        public float SubsArea(int index1, int index2)
        {
            return shapes[index1] - shapes[index2];
        }
      
        public int EqualArea(int index1, int index2)
        {
            if (shapes[index1] < shapes[index2])
            {
                return -1;
            }
            else if (shapes[index1] > shapes[index2])
            {
                return 1;
            }
            else return 0;
        }
        public void Incriment(int index)
        {
            shapes[index]++;
        }
        public void Decrement(int index)
        {
            shapes[index]--;
        }

    }
}
