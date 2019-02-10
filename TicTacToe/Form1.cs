using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char player = 'X';
        public int turns = 0;
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }



        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if (checkDraw() == true)
                {
                    MessageBox.Show("Remis");

                }
                if (checkWinner() == true)
                {
                    MessageBox.Show("Wygrana");
                    DisableBox();

                }
            }

            bool checkDraw()
            {
                if (turns == 25)
                    return true;
                else
                    return false;
            }

            bool checkWinner()
            {
                //poziom
                if ((box1.Text == box2.Text) && (box2.Text == box3.Text) && (box3.Text == box4.Text) && box1.Text != "")
                    return true;
                else if ((box2.Text == box3.Text) && (box3.Text == box4.Text) && (box4.Text == box5.Text) && box2.Text != "")
                    return true;
                else if ((box6.Text == box7.Text) && (box7.Text == box8.Text) && (box8.Text == box9.Text) && box6.Text != "")
                    return true;
                else if ((box7.Text == box8.Text) && (box8.Text == box9.Text) && (box9.Text == box10.Text) && box7.Text != "")
                    return true;
                else if ((box11.Text == box12.Text) && (box12.Text == box13.Text) && (box13.Text == box14.Text) && box11.Text != "")
                    return true;
                else if ((box12.Text == box13.Text) && (box13.Text == box14.Text) && (box14.Text == box15.Text) && box12.Text != "")
                    return true;
                else if ((box16.Text == box17.Text) && (box17.Text == box18.Text) && (box18.Text == box19.Text) && box16.Text != "")
                    return true;
                else if ((box17.Text == box18.Text) && (box19.Text == box20.Text) && (box20.Text == box21.Text) && box17.Text != "")
                    return true;
                else if ((box21.Text == box22.Text) && (box22.Text == box23.Text) && (box23.Text == box24.Text) && box21.Text != "")
                    return true;
                else if ((box22.Text == box23.Text) && (box23.Text == box24.Text) && (box24.Text == box25.Text) && box22.Text != "")
                    return true;
                //pion
                else if ((box1.Text == box6.Text) && (box6.Text == box11.Text) && (box11.Text == box16.Text) && box1.Text != "")
                    return true;
                else if ((box6.Text == box11.Text) && (box11.Text == box16.Text) && (box16.Text == box21.Text) && box6.Text != "")
                    return true;
                else if ((box2.Text == box7.Text) && (box7.Text == box12.Text) && (box12.Text == box17.Text) && box2.Text != "")
                    return true;
                else if ((box7.Text == box12.Text) && (box12.Text == box17.Text) && (box17.Text == box22.Text) && box7.Text != "")
                    return true;
                else if ((box3.Text == box8.Text) && (box13.Text == box18.Text) && (box18.Text == box23.Text) && box3.Text != "")
                    return true;
                else if ((box8.Text == box13.Text) && (box13.Text == box18.Text) && (box18.Text == box23.Text) && box8.Text != "")
                    return true;
                else if ((box4.Text == box9.Text) && (box9.Text == box14.Text) && (box14.Text == box19.Text) && box4.Text != "")
                    return true;
                else if ((box9.Text == box14.Text) && (box14.Text == box19.Text) && (box19.Text == box24.Text) && box9.Text != "")
                    return true;
                else if ((box5.Text == box10.Text) && (box10.Text == box15.Text) && (box15.Text == box20.Text) && box5.Text != "")
                    return true;
                else if ((box10.Text == box15.Text) && (box15.Text == box20.Text) && (box20.Text == box25.Text) && box10.Text != "")
                    return true;

                //skosy
                else if ((box1.Text == box7.Text) && (box7.Text == box13.Text) && (box13.Text == box19.Text) && box1.Text != "")
                    return true;
                else if ((box7.Text == box13.Text) && (box13.Text == box19.Text) && (box19.Text == box25.Text) && box7.Text != "")
                    return true;
                else if ((box6.Text == box12.Text) && (box12.Text == box18.Text) && (box18.Text == box24.Text) && box6.Text != "")
                    return true;
                else if ((box2.Text == box8.Text) && (box8.Text == box14.Text) && (box14.Text == box20.Text) && box2.Text != "")
                    return true;
                else if ((box5.Text == box9.Text) && (box9.Text == box13.Text) && (box13.Text == box17.Text) && box5.Text != "")
                    return true;
                else if ((box9.Text == box13.Text) && (box13.Text == box17.Text) && (box17.Text == box21.Text) && box9.Text != "")
                    return true;
                else if ((box4.Text == box8.Text) && (box8.Text == box12.Text) && (box12.Text == box16.Text) && box4.Text != "")
                    return true;
                else if ((box10.Text == box14.Text) && (box14.Text == box18.Text) && (box18.Text == box22.Text) && box10.Text != "")
                    return true;
                else
                    return false;

            }
        }

        private void NewGame(object sender, EventArgs e)
        {

            ResetBoxes();
            EnableBox();
            turns = 0;
            //update
            
        }

        private void Options(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        void DisableBox()
        {
            box1.Enabled = box2.Enabled = box3.Enabled = box4.Enabled = box5.Enabled =
            box6.Enabled = box7.Enabled = box8.Enabled = box9.Enabled = box10.Enabled =
            box11.Enabled = box12.Enabled = box13.Enabled = box14.Enabled = box15.Enabled =
            box16.Enabled = box17.Enabled = box18.Enabled = box19.Enabled = box20.Enabled =
            box21.Enabled = box22.Enabled = box23.Enabled = box24.Enabled = box25.Enabled = false;
        }

        void EnableBox()
        {
            box1.Enabled = box2.Enabled = box3.Enabled = box4.Enabled = box5.Enabled =
            box6.Enabled = box7.Enabled = box8.Enabled = box9.Enabled = box10.Enabled =
            box11.Enabled = box12.Enabled = box13.Enabled = box14.Enabled = box15.Enabled =
            box16.Enabled = box17.Enabled = box18.Enabled = box19.Enabled = box20.Enabled =
            box21.Enabled = box22.Enabled = box23.Enabled = box24.Enabled = box25.Enabled = true;
        }

        void ResetBoxes()
        {
            box1.Text = box2.Text = box3.Text = box4.Text = box5.Text =
            box6.Text = box7.Text = box8.Text = box9.Text = box10.Text =
            box11.Text = box12.Text = box13.Text = box14.Text = box15.Text =
            box16.Text = box17.Text = box18.Text = box19.Text = box20.Text =
            box21.Text = box22.Text = box23.Text = box24.Text = box25.Text = "";
        }

    }
}
