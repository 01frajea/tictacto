using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tictactou
{
    public partial class Form1 : Form
    {

        bool zahler = true;
       
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (zahler)
            {
                button1.Text = "x";
                player.Text = "player1";
                button1.Enabled= false;
            }
            else
            {
                button1.Text = "O";
                player.Text = "player2";
                button1.Enabled = false;
            }
            zahler = !zahler;

            berechen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (zahler)
            {
                button2.Text = "x";
                player.Text = "player1";
                button2.Enabled = false;
            }
            else
            {
                button2.Text = "O";
                player.Text = "player2";
                button2.Enabled = false;
            }
            zahler = !zahler;
            berechen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (zahler)
            {
                button3.Text = "x";
                player.Text = "player1";
                button3.Enabled = false;
            }
            else
            {
                button3.Text = "O";
                player.Text = "player2";
                button3.Enabled = false;
            }
            zahler = !zahler;
            berechen();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (zahler)
            {
                button4.Text = "x";
                player.Text = "player1";
                button4.Enabled = false;
            }
            else
            {
                button4.Text = "O";
                player.Text = "player2";
                button4.Enabled = false;
            }

            zahler =! zahler;
            berechen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (zahler)
            {
                button5.Text = "x";
                player.Text = "player1";
                button5.Enabled = false;
            }
            else
            {
                button5.Text = "O";
                player.Text = "player2";
                button5.Enabled = false;
            }
            zahler = !zahler;
            berechen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (zahler)
            {
                button6.Text = "x";
                player.Text = "player1";
                button6.Enabled = false;
            }
            else
            {
                button6.Text = "O";
                player.Text = "player2";
                button6.Enabled = false;
            }
            zahler = !zahler;
            berechen();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (zahler)
            {
                button7.Text = "x";
                player.Text = "player1";
                button7.Enabled = false;
            }
            else
            {
                button7.Text = "O";
                player.Text = "player2";
                button7.Enabled = false;
            }
            zahler = !zahler;
            berechen();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (zahler)
            {
                button8.Text = "x";
                player.Text = "player1";
                button8.Enabled = false;
            }
            else
            {
                button8.Text = "O";
                player.Text = "player2";
                button8.Enabled = false;

            }
            zahler = !zahler;
            berechen();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (zahler)
            {
                button9.Text = "x";
                player.Text = "player1";
                button9.Enabled = false;

            }
            else
                
            {
                button9.Text = "O";
                player.Text = "player2";
                button9.Enabled = false;

            }
            zahler = !zahler;
            berechen();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        public void berechen()
        {
            if (button1.Text == "x" & button2.Text == "x" & button3.Text == "x" | button1.Text == "x" & button4.Text == "x" & button7.Text == "x" | button1.Text == "x" & button5.Text == "x" & button9.Text == "x" | button7.Text == "x" & button8.Text == "x" & button9.Text == "x" | button3.Text == "x" & button6.Text == "x" & button9.Text == "x" | button4.Text == "x" & button5.Text == "x" & button6.Text == "x" | button2.Text == "x" & button5.Text == "x" & button8.Text == "x")
            {

                label1.Text = "spieler 1 gewonnen";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
            if (button1.Text == "O" & button2.Text == "O" & button3.Text == "O" | button1.Text == "O" & button4.Text == "O" & button7.Text == "O" | button1.Text == "O" & button5.Text == "O" & button9.Text == "O" | button7.Text == "O" & button8.Text == "O" & button9.Text == "O" | button3.Text == "O" & button6.Text == "O" & button9.Text == "O" | button4.Text == "O" & button5.Text == "O" & button6.Text == "O" | button2.Text == "O" & button5.Text == "O" & button8.Text == "O")
            {
                label1.Text = "spieler 2 gewonnnen";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void löschen_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label1.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
