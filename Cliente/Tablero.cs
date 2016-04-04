using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Tablero : Form
    {
        public Tablero()
        {
            InitializeComponent();
        }

        //64,64   //896, 64
        //64, 768  //896, 768
        PictureBox player1;
        int[,] matriz;
        PictureBox[,] matriz_vista;

        private void Form1_Load(object sender, EventArgs e)
        {
            player1 = pbPlayer1;
        }

        private void Tablero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player1.Left -= 7;
            }
            if (e.KeyCode == Keys.Right)
            {
                player1.Left += 7;
            }
            if (e.KeyCode == Keys.Down)
            {
                player1.Top += 7;
            }
            if (e.KeyCode == Keys.Up)
            {
                player1.Top -= 7;
            }
        }
    }
}
