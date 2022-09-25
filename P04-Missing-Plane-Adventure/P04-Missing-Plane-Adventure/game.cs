using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P04_Missing_Plane_Adventure
{
    public partial class GameWindow : Form
    {
        //Class Level Varibles
        public static int islandX, islandY;
        private Random rnd;
        public static int guesses;
        public static Label guessesLabel;
        public static Label distanceLabel;
        public static bool won = false;
        public static Button playB;
        public static Button quitB;
        public static Label wonL;
        private static Pregame_Form originForm;


        public GameWindow(int passedSize, Pregame_Form origin)
        {
            InitializeComponent();
            PictureBox[,] grid = createGrid(passedSize, this);
            rnd = new Random();
            islandX = rnd.Next(passedSize);
            islandY = rnd.Next(passedSize);
            guesses = 0;
            guessesLabel = guessCountLabel;
            distanceLabel = distanceIslandLabel;
            playB = playButton;
            quitB = quitButton;
            wonL = wonLabel;
            originForm = origin;
        }

        public static PictureBox[,] createGrid(int size, GameWindow self)
        {
            PictureBox[,] result = new PictureBox[size, size];
            int margin = 10;
            int tileSize = ((self.Height - (size * margin) - 50) / (size + 1));
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i,j] = new PictureBox
                    {
                        Name = $"{i},{j}",
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(margin + (tileSize * i) + (margin * i), 50 + (tileSize * j) + (margin * j)),
                        Image = Image.FromFile("C:/Users/Zach's Desktop/Documents/code/CMPS_4143_P04-Missing-Plane-Adventure/P04-Missing-Plane-Adventure/P04-Missing-Plane-Adventure/assets/cloud.jpg"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    result[i,j].Click += (s, e) => {
                        if (!won)
                        {
                            PictureBox actuallyUsefulVarible = (PictureBox)s;
                            string[] coords = actuallyUsefulVarible.Name.Split(',');
                            tileClicked(Int32.Parse(coords[0]), Int32.Parse(coords[1]), result);
                        } 
                    };
                    self.Controls.Add(result[i, j]);
                }
            }
            return result;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            originForm.Visible = true;
            this.Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            originForm.Close();
        }

        private static void tileClicked(int x, int y, PictureBox[,] grid)
        {
            if(x == islandX && y == islandY)
            {
                grid[x, y].Image = Image.FromFile("C:/Users/Zach's Desktop/Documents/code/CMPS_4143_P04-Missing-Plane-Adventure/P04-Missing-Plane-Adventure/P04-Missing-Plane-Adventure/assets/island.jpg");
                won = true;
                playB.Visible = true;
                quitB.Visible = true;
                wonL.Visible = true;
            } else
            {
                grid[x, y].Image = Image.FromFile("C:/Users/Zach's Desktop/Documents/code/CMPS_4143_P04-Missing-Plane-Adventure/P04-Missing-Plane-Adventure/P04-Missing-Plane-Adventure/assets/oceanTile.jpeg");
                guesses += 1;
                guessesLabel.Text = $"Guesses: {guesses}";
            }
            int distance = Convert.ToInt32(Math.Abs(Math.Sqrt(Math.Pow(islandX - x, 2) + Math.Pow(islandY - y, 2))));
            distanceLabel.Text = $"Distance from island: {distance}";
        }
    }
}
