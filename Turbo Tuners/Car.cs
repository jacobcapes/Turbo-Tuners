using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Turbo_Tuners
{
    class Car
    {
        // declare fields to use in the class
        public double xSpeed, ySpeed;
        public int x, y, width, height;//variables for the rectangle
        public Image car;//variable for the car's image
        public Rectangle carRec;//variable for a rectangle to place our image in
        public int rotationAngle; //rotationangle value
        public Matrix matrix; //public matrix declaration
        Point centre; // centre of car
        public int carRotated;
        int carRotate;

        public Car()
        {
            x = 10;
            y = 360;
            width = 30;
            height = 45;
            rotationAngle = 0;
            car = Properties.Resources.car1;
            carRec = new Rectangle(x, y, width, height);
            //giving values to assign speeds to the rotations
            xSpeed = 30 * (Math.Cos((carRotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((carRotate + 90) * Math.PI / 180));
        }
        public void drawCar(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(carRec.X + width / 2, carRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (carRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the car
            g.DrawImage(car, carRec);
        }
        public void MoveCar(string move)
        {
            if (carRec.Location.Y < 10) // is car within 10 of top side
            {

                y = 10;
                // carRec.Location = new Point(x, y);
            }
            if (carRec.Location.Y > 385) // is car within 385 of bottom side
            {

                y = 385;
                // spaceRec.Location = new Point(x, y);
            }
            if (carRec.Location.X > 647) // is car within 10 of left side
            {

                x = 647;
                // carRec.Location = new Point(x, y);
            }
            if (carRec.Location.X < 10) // is car within 10 of left side
            {

                x = 10;
                //carRec.Location = new Point(x, y);
            }
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;
            carRec.Location = new Point(x, y);//cars new location


        }
        public void Rotatecar(int carRotate)
        {
            //trigonometric funtions to deruive an x and y integer that can be used to move the car
            xSpeed = 10 * (Math.Cos((carRotate - 90) * Math.PI / 180));
            ySpeed = 10 * (Math.Sin((carRotate + 90) * Math.PI / 180));
        }

    }

}
