//Hoda Khier + Yusef Aborokn 44/5
using System;
using System.Collections.Generic;
using System.Text;

namespace Q5__inheretence_
{
    class Point
    {
        private int x;
        private int y;


        public Point(int x,int y)//הגדרת בנאי
        {
            this.x = x;
            this.y = y;
        }


        //SETTERS AND GETTERS
        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }
    }
}
