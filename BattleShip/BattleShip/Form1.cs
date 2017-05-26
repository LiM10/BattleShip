using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 800;

            // Ships
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button ship = new Button();
                    ship.Width = 50;
                    ship.Height = 50;
                    ship.Top = 130 + j * 50;
                    ship.Left = 130 + i * 50;
                    ship.BackColor = Color.Green;
                    ship.Click += new EventHandler(bomb);
                    Controls.Add(ship);
                }
            }

            

            // Numbers

            for (int i = 1; i <= 10; i++)
            {
                Label num = new Label();
                num.Width = 50;
                num.Height = 50;
                num.Top = 80;
                num.Left = 130 + (i-1) * 50;
                num.Padding = new Padding(15, 30, 15, 0);
                num.Text = i.ToString();
                num.ForeColor = Color.Black;
                num.BackColor = Color.AliceBlue;
                Controls.Add(num);
            }

            // Letters
            string[] ltr = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            for (int i = 0; i < ltr.Length; i++)
            {
                Label letter = new Label();
                letter.Width = 50;
                letter.Height = 50;
                letter.Top = 180 + (i - 1) * 50;
                letter.Left = 80;
                letter.Padding = new Padding(30, 15, 0, 15);
                letter.Text = ltr[i].ToString();
                letter.ForeColor = Color.Black;
                letter.BackColor = Color.AliceBlue;

                Controls.Add(letter);
            }
            
            // Area
            Panel area = new Panel();
            area.Width = 800;
            area.Height = 800;
            area.Padding = new Padding(50, 50, 50, 50);
            area.BackColor = Color.AliceBlue;
            Controls.Add(area);
            


            
        }

        private void bomb(object sender, EventArgs e)
        {
            Button ship = (Button)sender;
            if (ship.BackColor == Color.Green)
            {
                ship.BackColor = Color.Red;
            }
        }
        
    }
}
