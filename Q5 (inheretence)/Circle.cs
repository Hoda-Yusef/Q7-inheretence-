//Hoda Khier + Yusef Aborokn 44/5
using System;
using System.Collections.Generic;
using System.Text;

namespace Q5__inheretence_
{
    class Circle
    {
        private string color;
        private int thick;
        private Point center_point;
        private float radius;

        //הגדרת בנאי
        public Circle(float radius,int thick,int centerX,int centerY,string color)
        {
            this.radius = radius;
            this.thick = thick;
            this.center_point = new Point(centerX, centerY);
            this.color = color;
        }

        //הגדרת בנאי
        public Circle()
        {
            this.radius = 0;
            this.thick = 0;
            this.center_point = new Point(0, 0);
            this.color = "black";
        }

        public override bool Equals(object obj)
        {
            if (obj is Circle)
            {
                Circle C;
                C = (Circle)obj;

                if (this.radius == C.radius)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }


        public float scope_calculator()//חישוב היקף של מעגל
        {
            return (float)(2 * 3.14 * this.radius);
        }

        public float area_calculator()//חישוב שטח של מעגל
        {
            return (float)(3.14 * this.radius * this.radius);
        }

        public Boolean check_point_on_line(int x,int y)//בדיקה אם נקודה נמצאת במעגל
        {
            if ((float)Math.Sqrt((center_point.getX() - x) * (center_point.getX() - x) + (center_point.getY() - y) * (center_point.getY() - y)) == this.radius)
            {
                return true;
            }
            else
                return false;
        }


        //SETTERS AND GETTERS
        public void set_radius(float radius)
        {
            this.radius = radius;
        }

        public float get_radius()
        {
            return this.radius;
        }

        public void set_centerX(int x)
        {
            this.center_point.setX(x);
        }

        public int get_centerX()
        {
            return this.center_point.getX();
        }

        public void set_centerY(int y)
        {
            this.center_point.setY(y);
        }

        public int get_centerY()
        {
            return this.center_point.getY();
        }

        public void set_thick(int thick)
        {
            this.thick = thick;
        }

        public int get_thick()
        {
            return this.thick;
        }

        public void set_color(string color)
        {
            this.color = color;
        }

        public string get_color()
        {
            return this.color;
        }
    }
}
