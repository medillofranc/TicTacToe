using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class Form1 : Form
    {
        private Button[] buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            foreach (var btn in buttons)
                btn.Click += PlayerMove;

            ClearGame();
        }


        private void PlayerMove(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn is Button)
            {
                btn.Text = "X";
                btn.Enabled = false;
            }
        }


        private void ClearGame()
        {
            foreach (var button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
