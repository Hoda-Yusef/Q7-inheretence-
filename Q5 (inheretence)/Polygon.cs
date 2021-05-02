//Hoda Khier + Yusef Aborokn 44/5
using System;
using System.Collections.Generic;
using System.Text;

namespace Q5__inheretence_
{
    class Polygon
    {
        private string color;
        private int thick;
        private Point[] polygon_points=new Point[5];
        private int numOfPoints;

        
        public Polygon()//הגדרת בנאי
        {
            
            this.numOfPoints = 0;
            this.polygon_points[numOfPoints] = new Point(0, 0);
            this.color = "black";
            this.thick = 1;

        }

        public override bool Equals(object obj)
        {
            if(obj is Polygon)
            {
                Polygon poly;
                poly = (Polygon)obj;

                if (this.scope_polygon() == poly.scope_polygon())
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        public string ToString_polygon()//שיטה מחזירה מחרוזת של כל הנקודות במצולע
        {
            string points="Point 0 ("+this.polygon_points[0].getX()+","+ this.polygon_points[0].getY()+")";

            
            for(int i=1;i<5;i++)
            {
                points = points+"\nPoint "+i+" (" + this.polygon_points[i].getX() + "," + this.polygon_points[i].getY() + ")";
            }
            
            return points;
        }

        public float scope_polygon()//שיטה לחישוב היקף של מצולע
        {
            float scope_total=0;

            for(int i=0;i<4;i++)
            {
                scope_total += (float)Math.Sqrt((this.polygon_points[i].getX() - this.polygon_points[i + 1].getX()) * (this.polygon_points[i].getX() - this.polygon_points[i + 1].getX()) + (this.polygon_points[i].getY() - this.polygon_points[i + 1].getY() * (this.polygon_points[i].getY() - this.polygon_points[i + 1].getY())));
                
            }

            return scope_total;
        }

        public void move_points_polygon(int x,int y)//שיטה להזזת מצולע
        {
            for(int i=0;i<5;i++)
            {
                this.polygon_points[i].setX(x+this.polygon_points[i].getX());
                this.polygon_points[i].setY(y + this.polygon_points[i].getY());
            }
        }


        //setters and getters
        public void set_polygonX(int x)
        {
            this.polygon_points[numOfPoints] = new Point(0, 0);
            this.polygon_points[numOfPoints].setX(x);
        }

        public int get_polygonX(int num)
        {
            return this.polygon_points[num].getX();
        }

        public void set_polygonY(int y)
        {
            this.polygon_points[numOfPoints].setY(y);
        }

        public int get_polygonY(int num)
        {
            return this.polygon_points[num].getY();
        }

        public void set_numOfPoints(int num)
        {
            this.numOfPoints = num;
        }

        public int get_numOfPoints()
        {
            return this.numOfPoints;
        }








    }

    


    



}
