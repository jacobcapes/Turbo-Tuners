using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turbo_Tuners
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g so we can draw on the Form
        Car car = new Car(); //create an instance of the Spaceship Class called spaceship
        Checkpoint checkpoint = new Checkpoint();
        bool turnLeft, turnRight;
        int x1 = 20, y1 = 20;// starting position of planet
        bool up;
        string move;
        Rectangle area;
        public Form1()
        {
            InitializeComponent();
            area = new Rectangle(x1, y1, 30, 30);//spaceship's rectangle	
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void tmrCar_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                car.rotationAngle += 5;
            }
            if (turnLeft)
            {
                car.rotationAngle -= 5;
            }
            if (up) // if left arrow key pressed
            {
                move = "up";
                car.MoveCar(move);
                car.Rotatecar(car.rotationAngle);
            }
            panel1.Invalidate();
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
            if (e.KeyData == Keys.Up) { up = false; }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }
            if (e.KeyData == Keys.Up) { up = true; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the Form control
            g = e.Graphics;
            checkpoint.drawCheck(g);
            //Draw the spaceship
            car.drawCar(g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
