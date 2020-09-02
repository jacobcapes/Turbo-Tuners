using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Turbo_Tuners
{
    public partial class Form1 : Form
    {
       
        int score = 0; 
        Graphics g; //declare a graphics object called g so we can draw on the Form
        Random rand = new Random();
        int count = 20;
        Car car = new Car(); //create an instance of the Spaceship Class called spaceship
        bool turnLeft, turnRight;
        int x1 = 20, y1 = 20;// starting position of planet
        bool up;
        string move;
        Rectangle checkRec = new Rectangle(0, 0, 30, 30);
        Image checkpointImage = Properties.Resources.fuel1;
        public Form1()
        {
            InitializeComponent();
            checkRec = new Rectangle(x1, y1, 30, 30);//spaceship's rectangle
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });
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
            if (score == 5)
            {
                tmrCountdown.Interval = 800;

            }
            if (score == 10)
            {
                tmrCountdown.Interval = 600;
            }
            if (score == 10)
            {
                tmrCountdown.Interval = 400;
            }





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

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            
            lblScore.Text = score.ToString();//display score on the form 
            
            if (checkRec.IntersectsWith(car.carRec))
            {
             
                score += 1;
                count ++;
                lblScore.Text = score.ToString();
                checkRec.Y = rand.Next(240);
                checkRec.X = rand.Next(240);
            }
            
       

       
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            count--;//decrease count by 1
            LblTime.Text = count.ToString();//display count in LblTime

            if (count == 0)
            {

                tmrCountdown.Stop();
                
    
                MessageBox.Show("Game Over!");
            }

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            score = 0;
            lblScore.Text = score.ToString();
            count = int.Parse(LblTime.Text);// pass lives entered from textbox to lives variable
            tmrCar.Enabled = true;
            tmrCountdown.Enabled = true;
            tmrCheck.Enabled = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the Form control
            g = e.Graphics;
            g.DrawImage(checkpointImage, checkRec);
            //Draw the spaceship
            car.drawCar(g);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Use the left, right and up arrow keys to move and rotate the car. \n Make sure to collect as much fuel as possible before the time run out\n Every fuel collected slows down the timer\n Enter you name and click Start to begin", "Game Instructions");
            txtName.Focus();
        }
    }
}
