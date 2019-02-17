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

        int playerX = 0;
        int playerO = 0;

        bool isMenu1PanelOpen = false;
        bool isMenu2PanelOpen = false;

        int x, y;
        bool mouseDown = false;

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.ForeColor = Color.Gray; // X koloru szarego
                    button.Text = "X";  //przypisz X do danego boxa
                    player++;   
                    turns++;
                }
                else
                {
                    button.ForeColor = Color.White; // O koloru bialego
                    button.Text = "O";  //przypisz O do danego boxa
                    player++;
                    turns++;
                }
                display(); // wywolanie zmiany aktualnego gracza

                if (checkDraw() == true)
                {
                    MessageBox.Show("Remis");

                }
                if (checkWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("Wygrana gracza X");
                        playerX++;
                        playerXscore.Text = playerX.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Wygrana gracza O");
                        playerO++;
                        playerOscore.Text = playerO.ToString();
                    }
                    DisableBox();

                }
            }

            bool checkDraw() // sprawdzenie wypełnienia boxów, jesli wszystkie są juz wypełnione ogłasza się remis
            {
                if (turns == 25)
                    return true;
                else
                    return false;
            }

            #region checkWinner()
        
            bool checkWinner()  // instrujce warunkowe sprawdzające wygraną, aby wygrać należy posiadac 4 boxy takiego samego tekstu ( X lub O ) oraz muszą znajdowac sie w jednej lini (pionowo, poziono lub na skos) 
            {
                //poziom
                if ((box1.Text == box2.Text) && (box2.Text == box3.Text) && (box3.Text == box4.Text) && box1.Text != "")
                {
                    box1.BackColor = Color.Green; box2.BackColor = Color.Green; box3.BackColor = Color.Green; box4.BackColor = Color.Green;
                    return true;
                }
                else if ((box2.Text == box3.Text) && (box3.Text == box4.Text) && (box4.Text == box5.Text) && box2.Text != "")
                {
                    box2.BackColor = Color.Green; box3.BackColor = Color.Green; box4.BackColor = Color.Green; box5.BackColor = Color.Green;

                    return true;
                }
                else if ((box6.Text == box7.Text) && (box7.Text == box8.Text) && (box8.Text == box9.Text) && box6.Text != "")
                {
                    box6.BackColor = Color.Green; box7.BackColor = Color.Green; box8.BackColor = Color.Green; box9.BackColor = Color.Green;
                    return true;
                }
                else if ((box7.Text == box8.Text) && (box8.Text == box9.Text) && (box9.Text == box10.Text) && box7.Text != "")
                {
                    box7.BackColor = Color.Green; box8.BackColor = Color.Green; box9.BackColor = Color.Green; box10.BackColor = Color.Green;
                    return true;
                }
                else if ((box11.Text == box12.Text) && (box12.Text == box13.Text) && (box13.Text == box14.Text) && box11.Text != "")
                {
                    box11.BackColor = Color.Green; box12.BackColor = Color.Green; box13.BackColor = Color.Green; box14.BackColor = Color.Green;
                    return true;
                }
                else if ((box12.Text == box13.Text) && (box13.Text == box14.Text) && (box14.Text == box15.Text) && box12.Text != "")
                {
                    box12.BackColor = Color.Green; box13.BackColor = Color.Green; box14.BackColor = Color.Green; box15.BackColor = Color.Green;
                    return true;
                }
                else if ((box16.Text == box17.Text) && (box17.Text == box18.Text) && (box18.Text == box19.Text) && box16.Text != "")
                {
                    box16.BackColor = Color.Green; box17.BackColor = Color.Green; box18.BackColor = Color.Green; box19.BackColor = Color.Green;
                    return true;
                }
                else if ((box17.Text == box18.Text) && (box18.Text == box19.Text) && (box19.Text == box20.Text) && box17.Text != "")
                {
                    box17.BackColor = Color.Green; box18.BackColor = Color.Green; box19.BackColor = Color.Green; box20.BackColor = Color.Green;
                    return true;
                }
                else if ((box21.Text == box22.Text) && (box22.Text == box23.Text) && (box23.Text == box24.Text) && box21.Text != "")
                {
                    box21.BackColor = Color.Green; box22.BackColor = Color.Green; box23.BackColor = Color.Green; box24.BackColor = Color.Green;
                    return true;
                }
                else if ((box22.Text == box23.Text) && (box23.Text == box24.Text) && (box24.Text == box25.Text) && box22.Text != "")
                {
                    box22.BackColor = Color.Green; box23.BackColor = Color.Green; box24.BackColor = Color.Green; box25.BackColor = Color.Green;
                    return true;
                }
                //pion
                else if ((box1.Text == box6.Text) && (box6.Text == box11.Text) && (box11.Text == box16.Text) && box1.Text != "")
                {
                    box1.BackColor = Color.Green; box6.BackColor = Color.Green; box11.BackColor = Color.Green; box16.BackColor = Color.Green;
                    return true;
                }
                else if ((box6.Text == box11.Text) && (box11.Text == box16.Text) && (box16.Text == box21.Text) && box6.Text != "")
                {
                    box6.BackColor = Color.Green; box11.BackColor = Color.Green; box16.BackColor = Color.Green; box21.BackColor = Color.Green;
                    return true;
                }
                else if ((box2.Text == box7.Text) && (box7.Text == box12.Text) && (box12.Text == box17.Text) && box2.Text != "")
                {
                    box2.BackColor = Color.Green; box7.BackColor = Color.Green; box12.BackColor = Color.Green; box17.BackColor = Color.Green;
                    return true;
                }
                else if ((box7.Text == box12.Text) && (box12.Text == box17.Text) && (box17.Text == box22.Text) && box7.Text != "")
                {
                    box7.BackColor = Color.Green; box12.BackColor = Color.Green; box17.BackColor = Color.Green; box22.BackColor = Color.Green;
                    return true;
                }
                else if ((box3.Text == box8.Text) && (box8.Text == box13.Text) && (box13.Text == box18.Text) && box3.Text != "")
                {
                    box3.BackColor = Color.Green; box8.BackColor = Color.Green; box13.BackColor = Color.Green; box18.BackColor = Color.Green;
                    return true;
                }
                else if ((box8.Text == box13.Text) && (box13.Text == box18.Text) && (box18.Text == box23.Text) && box8.Text != "")
                {
                    box8.BackColor = Color.Green; box13.BackColor = Color.Green; box18.BackColor = Color.Green; box23.BackColor = Color.Green;
                    return true;
                }
                else if ((box4.Text == box9.Text) && (box9.Text == box14.Text) && (box14.Text == box19.Text) && box4.Text != "")
                {
                    box4.BackColor = Color.Green; box9.BackColor = Color.Green; box14.BackColor = Color.Green; box19.BackColor = Color.Green;
                    return true;
                }
                else if ((box9.Text == box14.Text) && (box14.Text == box19.Text) && (box19.Text == box24.Text) && box9.Text != "")
                {
                    box9.BackColor = Color.Green; box14.BackColor = Color.Green; box19.BackColor = Color.Green; box24.BackColor = Color.Green;
                    return true;
                }
                else if ((box5.Text == box10.Text) && (box10.Text == box15.Text) && (box15.Text == box20.Text) && box5.Text != "")
                {
                    box5.BackColor = Color.Green; box10.BackColor = Color.Green; box15.BackColor = Color.Green; box20.BackColor = Color.Green;
                    return true;
                }
                else if ((box10.Text == box15.Text) && (box15.Text == box20.Text) && (box20.Text == box25.Text) && box10.Text != "")
                {
                    box10.BackColor = Color.Green; box15.BackColor = Color.Green; box20.BackColor = Color.Green; box25.BackColor = Color.Green;
                    return true;
                }

                //skosy
                else if ((box1.Text == box7.Text) && (box7.Text == box13.Text) && (box13.Text == box19.Text) && box1.Text != "")
                {
                    box1.BackColor = Color.Green; box7.BackColor = Color.Green; box13.BackColor = Color.Green; box19.BackColor = Color.Green;
                    return true;
                }
                else if ((box7.Text == box13.Text) && (box13.Text == box19.Text) && (box19.Text == box25.Text) && box7.Text != "")
                {
                    box7.BackColor = Color.Green; box13.BackColor = Color.Green; box19.BackColor = Color.Green; box25.BackColor = Color.Green;
                    return true;
                }
                else if ((box6.Text == box12.Text) && (box12.Text == box18.Text) && (box18.Text == box24.Text) && box6.Text != "")
                {
                    box6.BackColor = Color.Green; box12.BackColor = Color.Green; box18.BackColor = Color.Green; box24.BackColor = Color.Green;
                    return true;
                }
                else if ((box2.Text == box8.Text) && (box8.Text == box14.Text) && (box14.Text == box20.Text) && box2.Text != "")
                {
                    box2.BackColor = Color.Green; box8.BackColor = Color.Green; box14.BackColor = Color.Green; box20.BackColor = Color.Green;
                    return true;
                }
                else if ((box5.Text == box9.Text) && (box9.Text == box13.Text) && (box13.Text == box17.Text) && box5.Text != "")
                {
                    box5.BackColor = Color.Green; box9.BackColor = Color.Green; box13.BackColor = Color.Green; box17.BackColor = Color.Green;
                    return true;
                }
                else if ((box9.Text == box13.Text) && (box13.Text == box17.Text) && (box17.Text == box21.Text) && box9.Text != "")
                {
                    box9.BackColor = Color.Green; box13.BackColor = Color.Green; box17.BackColor = Color.Green; box21.BackColor = Color.Green;
                    return true;
                }
                else if ((box4.Text == box8.Text) && (box8.Text == box12.Text) && (box12.Text == box16.Text) && box4.Text != "")
                {
                    box4.BackColor = Color.Green; box8.BackColor = Color.Green; box12.BackColor = Color.Green; box16.BackColor = Color.Green;
                    return true;
                }
                else if ((box10.Text == box14.Text) && (box14.Text == box18.Text) && (box18.Text == box22.Text) && box10.Text != "")
                {
                    box10.BackColor = Color.Green; box14.BackColor = Color.Green; box18.BackColor = Color.Green; box22.BackColor = Color.Green;
                    return true;
                }
                else
                    return false;

            }
            #endregion
            // instrujce warunkowe sprawdzające wygraną, aby wygrać należy posiadac 4 boxy takiego samego tekstu ( X lub O ) oraz muszą znajdowac sie w jednej lini (pionowo, poziono lub na skos) 


        }

        private void NewGame(object sender, EventArgs e)
        {

            ResetBoxes();
            EnableBox();
            turns = 0;
            //update
        }

        private void Exit(object sender, EventArgs e)
        {
        this.Close(); // zamknij 
        }

        void DisableBox()
        {
            box1.Enabled = box2.Enabled = box3.Enabled = box4.Enabled = box5.Enabled =
            box6.Enabled = box7.Enabled = box8.Enabled = box9.Enabled = box10.Enabled =
            box11.Enabled = box12.Enabled = box13.Enabled = box14.Enabled = box15.Enabled =
            box16.Enabled = box17.Enabled = box18.Enabled = box19.Enabled = box20.Enabled =
            box21.Enabled = box22.Enabled = box23.Enabled = box24.Enabled = box25.Enabled = false; // dezaktywowanie boxów 
        }

        void EnableBox()
        {
            box1.Enabled = box2.Enabled = box3.Enabled = box4.Enabled = box5.Enabled =
            box6.Enabled = box7.Enabled = box8.Enabled = box9.Enabled = box10.Enabled =
            box11.Enabled = box12.Enabled = box13.Enabled = box14.Enabled = box15.Enabled =
            box16.Enabled = box17.Enabled = box18.Enabled = box19.Enabled = box20.Enabled =
            box21.Enabled = box22.Enabled = box23.Enabled = box24.Enabled = box25.Enabled = true; // aktywowanie boxów 

        }

        void ResetBoxes()
        {
            box1.Text = box2.Text = box3.Text = box4.Text = box5.Text =
            box6.Text = box7.Text = box8.Text = box9.Text = box10.Text =
            box11.Text = box12.Text = box13.Text = box14.Text = box15.Text =
            box16.Text = box17.Text = box18.Text = box19.Text = box20.Text =
            box21.Text = box22.Text = box23.Text = box24.Text = box25.Text = ""; // wyczyszczenie zapełniomych boxów

            box1.BackColor = box2.BackColor = box3.BackColor = box4.BackColor = box5.BackColor =
            box6.BackColor = box7.BackColor = box8.BackColor = box9.BackColor = box10.BackColor =
            box11.BackColor = box12.BackColor = box13.BackColor = box14.BackColor = box15.BackColor =
            box16.BackColor = box17.BackColor = box18.BackColor = box19.BackColor = box20.BackColor =
            box21.BackColor = box22.BackColor = box23.BackColor = box24.BackColor = box25.BackColor = Color.FromArgb(0, 180, 235); // przypisanie wszystkim boxom koloru startowego
        }



        public void display()
        {
            if (player % 2 == 0)
            {
                DisplayPlayers.Text = "X"; // zmiana aktualnego gracza

            }
            else
            {
                DisplayPlayers.Text = "O"; // zmiana aktualnego gracza

            }
        }

        private void OptionPanel_Paint(object sender, PaintEventArgs e)
        {
            //Panel Opcji
        }

        private void Option_Click(object sender, EventArgs e)
        {
            timer1.Start(); // timer menu
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isMenu1PanelOpen) // jesli button zostanie kliknięty w celu zamknięcia, wtedy zsuń menu Language. Tutaj zachodzi również opcja zsunięcia menu Language jesli jest otwarta
            {
                OptionPanel.Width -= 20;
                LanguagePanel.Width -= 20;
                if (OptionPanel.Width == 0 && LanguagePanel.Width == 0)
                {
                    timer1.Stop();
                    isMenu1PanelOpen = false;
                    isMenu2PanelOpen = false;
                }

            }
            else if (!isMenu1PanelOpen) //  jesli button zostanie kliknięty w celu otwarcia, wtedy rozsuń menu Language
            {
                OptionPanel.Width += 20;
                if (OptionPanel.Width == 200)
                {
                    timer1.Stop();
                    isMenu1PanelOpen = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gra Kółko i Krzyżyk  jest grą strategiczną, rozgrywaną przez dwóch graczy, " +
                "najczęściej na kartce papieru, w tym przypadku na komputerze. " +
                "W standardowej wersji 3x3 gracze zajmują pola na przemian dążąc do objęcia trzech pól w jednej linii" +
                "(pionowo, poziomo lub na skos) przy jednoczesnym uniemożliwieniu tego samego swojemu przeciwnikowi. " +
                "Pole raz zajęte, nie może zmienić swojego właściciela aż do zakończenia gry. W poniższym przypadku " +
                "rozpatrywaniu poddana zostanie wersja gry z polem 5x5, kiedy to wygrana następuje po objęciu czterech pól w jednej linii.  " +
                "\n\nPraca wykonana przez Adam Żur & Krzysztof Wcisło. 2019"); //Info
        }


        private void language_Click(object sender, EventArgs e)
        {
            timer2.Start(); // timer menu
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isMenu2PanelOpen == true)
            {

                LanguagePanel.Width -= 20; // jesli button zostanie kliknięty w celu zamknięcia, wtedy zsuń menu Language
                if (LanguagePanel.Width == 0)
                {
                    timer2.Stop();
                    isMenu2PanelOpen = false;
                }

            }
            else if (!isMenu2PanelOpen) //  jesli button zostanie kliknięty w celu otwarcia, wtedy rozsuń menu Language
            {
                LanguagePanel.Width += 20;
                if (LanguagePanel.Width == 200)
                {
                    timer2.Stop();
                    isMenu2PanelOpen = true;
                }
            }
        }

        private void resetGame_Click(object sender, EventArgs e) 
        {
            playerXscore.Text = "0";  // przypisanie wartości 0 dla wyniku gracza X
            playerOscore.Text = "0";  // przypisanie wartości 0 dla wyniku gracza O
            playerX = 0;
            playerO = 0;

            ResetBoxes();
            EnableBox();
            turns = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Język Polski
            button26.Text = "Nowa Gra";
            Option.Text = "Opcje";
            button32.Text = "Wyjście";
            label2.Text = "Gracz X";
            label3.Text = "Gracz O";
            label1.Text = "Aktualny Gracz:";
            resetGame.Text = "Zresetuj Stan Gry";
            language.Text = "Język";
            button3.Text = "Informacje";
            button2.Text = "Angielski";
            button1.Text = "Polski";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Język Angielski
            button26.Text = "New Game";
            Option.Text = "Options";
            button32.Text = "Exit";
            label2.Text = "Player X";
            label3.Text = "Player O";
            label1.Text = "Current player:";
            resetGame.Text = "Reset Game";
            language.Text = "Language";
            button3.Text = "Info";
            button2.Text = "English";
            button1.Text = "Polish";
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown)
                return;
            Form formatka = ((Form)sender);
            formatka.SetDesktopLocation(formatka.DesktopLocation.X - (x - e.X), formatka.DesktopLocation.Y - (y - e.Y));
        }
    }

}
