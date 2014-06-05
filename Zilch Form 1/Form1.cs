using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zilch_Form_1
{
    public partial class Form1 : Form
    {
        bool first = false;
        bool second = false;
        bool third = false;
        bool fourth = false;
        bool fifth = false;
        bool sixth = false;
        int dieOne = 0;
        int dieTwo = 0;
        int dieThree = 0;
        int dieFour = 0;
        int dieFive = 0;
        int dieSix = 0;
        int stop1 = 1;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            die1Timer.Interval = 100;
            die2Timer.Interval = 100;
            die3Timer.Interval = 100;
            die4Timer.Interval = 100;
            die5Timer.Interval = 100;
            die6Timer.Interval = 100;
            keep1Btn.Enabled = false;
            keep2Btn.Enabled = false;
            keep3Btn.Enabled = false;
            keep4Btn.Enabled = false;
            keep5Btn.Enabled = false;
            keep6Btn.Enabled = false;
            roll1Btn.Enabled = false;
            bankBtn.Enabled = false;
        }

        private void keep1Btn_Click(object sender, EventArgs e)
        {
            if (dieOne == 1 && first == true)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                first = false;
            }
            else if (dieOne == 2 && first == true)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                first = false;
            }
            else if (dieOne == 3 && first == true)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                first = false;
            }
            else if (dieOne == 4 && first == true)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                first = false;
            }
            else if (dieOne == 5 && first == true)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                first = false;
            }
            else if (dieOne == 6 && first == true)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                first = false;
            }
            else if (dieOne == 1 && first == false)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 1.png");
                first = true;
            }
            else if (dieOne == 2 && first == false)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 2.png");
                first = true;
            }
            else if (dieOne == 3 && first == false)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 3.png");
                first = true;
            }
            else if (dieOne == 4 && first == false)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 4.png");
                first = true;
            }
            else if (dieOne == 5 && first == false)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 5.png");
                first = true;
            }
            else if (dieOne == 6 && first == false)
            {
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 6.png");
                first = true;
            }
            blockRoll();
        }

        private void keep2Btn_Click(object sender, EventArgs e)
        {
            if (dieTwo == 1 && second == true)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                second = false;
            }
            else if (dieTwo == 2 && second == true)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                second = false;
            }
            else if (dieTwo == 3 && second == true)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                second = false;
            }
            else if (dieTwo == 4 && second == true)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                second = false;
            }
            else if (dieTwo == 5 && second == true)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                second = false;
            }
            else if (dieTwo == 6 && second == true)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                second = false;
            }
            else if (dieTwo == 1 && second == false)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 1.png");
                second = true;
            }
            else if (dieTwo == 2 && second == false)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 2.png");
                second = true;
            }
            else if (dieTwo == 3 && second == false)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 3.png");
                second = true;
            }
            else if (dieTwo == 4 && second == false)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 4.png");
                second = true;
            }
            else if (dieTwo == 5 && second == false)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 5.png");
                second = true;
            }
            else if (dieTwo == 6 && second == false)
            {
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 6.png");
                second = true;
            }
            blockRoll();
        }

        private void keep3Btn_Click(object sender, EventArgs e)
        {
            if (dieThree == 1 && third == true)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                third = false;
            }
            else if (dieThree == 2 && third == true)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                third = false;
            }
            else if (dieThree == 3 && third == true)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                third = false;
            }
            else if (dieThree == 4 && third == true)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                third = false;
            }
            else if (dieThree == 5 && third == true)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                third = false;
            }
            else if (dieThree == 6 && third == true)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                third = false;
            }
            else if (dieThree == 1 && third == false)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 1.png");
                third = true;
            }
            else if (dieThree == 2 && third == false)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 2.png");
                third = true;
            }
            else if (dieThree == 3 && third == false)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 3.png");
                third = true;
            }
            else if (dieThree == 4 && third == false)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 4.png");
                third = true;
            }
            else if (dieThree == 5 && third == false)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 5.png");
                third = true;
            }
            else if (dieThree == 6 && third == false)
            {
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 6.png");
                third = true;
            }
            blockRoll();
        }
        private void keep4Btn_Click(object sender, EventArgs e)
        {
            if (dieFour == 1 && fourth == true)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                fourth = false;
            }
            else if (dieFour == 2 && fourth == true)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                fourth = false;
            }
            else if (dieFour == 3 && fourth == true)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                fourth = false;
            }
            else if (dieFour == 4 && fourth == true)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                fourth = false;
            }
            else if (dieFour == 5 && fourth == true)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                fourth = false;
            }
            else if (dieFour == 6 && fourth == true)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                fourth = false;
            }
            else if (dieFour == 1 && fourth == false)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 1.png");
                fourth = true;
            }
            else if (dieFour == 2 && fourth == false)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 2.png");
                fourth = true;
            }
            else if (dieFour == 3 && fourth == false)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 3.png");
                fourth = true;
            }
            else if (dieFour == 4 && fourth == false)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 4.png");
                fourth = true;
            }
            else if (dieFour == 5 && fourth == false)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 5.png");
                fourth = true;
            }
            else if (dieFour == 6 && fourth == false)
            {
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 6.png");
                fourth = true;
            }
            blockRoll();
        }

        private void keep5Btn_Click(object sender, EventArgs e)
        {
            if (dieFive == 1 && fifth == true)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                fifth = false;
            }
            else if (dieFive == 2 && fifth == true)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                fifth = false;
            }
            else if (dieFive == 3 && fifth == true)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                fifth = false;
            }
            else if (dieFive == 4 && fifth == true)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                fifth = false;
            }
            else if (dieFive == 5 && fifth == true)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                fifth = false;
            }
            else if (dieFive == 6 && fifth == true)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                fifth = false;
            }
            else if (dieFive == 1 && fifth == false)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 1.png");
                fifth = true;
            }
            else if (dieFive == 2 && fifth == false)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 2.png");
                fifth = true;
            }
            else if (dieFive == 3 && fifth == false)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 3.png");
                fifth = true;
            }
            else if (dieFive == 4 && fifth == false)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 4.png");
                fifth = true;
            }
            else if (dieFive == 5 && fifth == false)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 5.png");
                fifth = true;
            }
            else if (dieFive == 6 && fifth == false)
            {
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 6.png");
                fifth = true;
            }
            blockRoll();
        }

        private void keep6Btn_Click(object sender, EventArgs e)
        {
            if (dieSix == 1 && sixth == true)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                sixth = false;
            }
            else if (dieSix == 2 && sixth == true)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                sixth = false;
            }
            else if (dieSix == 3 && sixth == true)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                sixth = false;
            }
            else if (dieSix == 4 && sixth == true)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                sixth = false;
            }
            else if (dieSix == 5 && sixth == true)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                sixth = false;
            }
            else if (dieSix == 6 && sixth == true)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                sixth = false;
            }
            else if (dieSix == 1 && sixth == false)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 1.png");
                sixth = true;
            }
            else if (dieSix == 2 && sixth == false)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 2.png");
                sixth = true;
            }
            else if (dieSix == 3 && sixth == false)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 3.png");
                sixth = true;
            }
            else if (dieSix == 4 && sixth == false)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 4.png");
                sixth = true;
            }
            else if (dieSix == 5 && sixth == false)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 5.png");
                sixth = true;
            }
            else if (dieSix == 6 && sixth == false)
            {
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Lit Die 6.png");
                sixth = true;
            }
            blockRoll();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            roll1Btn.Enabled = true;
            rollBtn.Enabled = false;

            if (first == false)
                die1Timer_Tick(sender, e);

            if (second == false)
                die2Timer_Tick(sender, e);

            if (third == false)
                die3Timer_Tick(sender, e);

            if (fourth == false)
                die4Timer_Tick(sender, e);

            if (fifth == false)
                die5Timer_Tick(sender, e);

            if (sixth == false)
                die6Timer_Tick(sender, e);

            if (first == true)
                if (second == true)
                    if (third == true)
                        if (fourth == true)
                            if (fifth == true)
                                stop1 = 6;
                            else
                            {
                                stop1 = 5;
                            }
                        else
                        {
                            stop1 = 4;
                        }
                    else
                    {
                        stop1 = 3;
                    }
                else
                {
                    stop1 = 2;
                }
            else
            {
                stop1 = 1;
            }
        }

        private void roll1Btn_Click(object sender, EventArgs e)
        {
            if (stop1 == 1)
            {
                if (first == false)
                {
                    die1Timer.Stop();
                    dieOne = random.Next(1, 7);

                    if (dieOne == 1)
                        die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                    else if (dieOne == 2)
                        die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                    else if (dieOne == 3)
                        die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                    else if (dieOne == 4)
                        die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                    else if (dieOne == 5)
                        die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                    else if (dieOne == 6)
                        die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                }

                if (second == true)
                    if (third == true)
                        if (fourth == true)
                            if (fifth == true)
                                stop1 = 6;
                            else
                                stop1 = 5;
                        else
                            stop1 = 4;
                    else
                        stop1 = 3;
                else
                    stop1 = 2;

            }
            
            else if (stop1 == 2)
            {
                if (second == false)
                {
                    die2Timer.Stop();
                    dieTwo = random.Next(1, 7);

                    if (dieTwo == 1)
                        die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                    else if (dieTwo == 2)
                        die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                    else if (dieTwo == 3)
                        die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                    else if (dieTwo == 4)
                        die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                    else if (dieTwo == 5)
                        die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                    else if (dieTwo == 6)
                        die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                }
                if (third == true)
                        if (fourth == true)
                            if (fifth == true)
                                if (sixth == true)
                                    reset();
                                else
                                    stop1 = 6;
                            else
                                stop1 = 5;
                        else
                            stop1 = 4;
                    else
                        stop1 = 3;
            }

            else if (stop1 == 3)
            {
                if (third == false)
                {
                    die3Timer.Stop();
                    dieThree = random.Next(1, 7);

                    if (dieThree == 1)
                        die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                    else if (dieThree == 2)
                        die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                    else if (dieThree == 3)
                        die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                    else if (dieThree == 4)
                        die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                    else if (dieThree == 5)
                        die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                    else if (dieThree == 6)
                        die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                }
                if (fourth == true)
                    if (fifth == true)
                        if (sixth == true)
                            reset();
                        else
                            stop1 = 6;
                    else
                        stop1 = 5;
                else
                    stop1 = 4;
            }

            else if (stop1 == 4)
            {
                if (fourth == false)
                {
                    die4Timer.Stop();
                    dieFour = random.Next(1, 7);

                    if (dieFour == 1)
                        die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                    else if (dieFour == 2)
                        die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                    else if (dieFour == 3)
                        die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                    else if (dieFour == 4)
                        die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                    else if (dieFour == 5)
                        die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                    else if (dieFour == 6)
                        die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                }
                if (fifth == true)
                    if (sixth == true)
                        reset();
                    else
                        stop1 = 6;
                else
                    stop1 = 5;
            }

            else if (stop1 == 5)
            {
                if (fifth == false)
                {
                    die5Timer.Stop();
                    dieFive = random.Next(1, 7);

                    if (dieFive == 1)
                        die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                    else if (dieFive == 2)
                        die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                    else if (dieFive == 3)
                        die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                    else if (dieFive == 4)
                        die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                    else if (dieFive == 5)
                        die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                    else if (dieFive == 6)
                        die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                }
                if (sixth == true)
                    reset();
                else
                    stop1 = 6;
            }

            else if (stop1 == 6)
            {
                if (sixth == false)
                {
                    die6Timer.Stop();
                    dieSix = random.Next(1, 7);

                    if (dieSix == 1)
                        die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
                    else if (dieSix == 2)
                        die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
                    else if (dieSix == 3)
                        die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
                    else if (dieSix == 4)
                        die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
                    else if (dieSix == 5)
                        die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
                    else if (dieSix == 6)
                        die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
                }
                reset();
            }
        }
        private void reset()
        {
            stop1 = 1;
            keep1Btn.Enabled = true;
            keep2Btn.Enabled = true;
            keep3Btn.Enabled = true;
            keep4Btn.Enabled = true;
            keep5Btn.Enabled = true;
            keep6Btn.Enabled = true;
            rollBtn.Enabled = true;
            roll1Btn.Enabled = false;
            bankBtn.Enabled = true;
        }
        private void blockRoll()
        {
            if (first == true && second == true && third == true && fourth == true && fifth == true && sixth == true)
                rollBtn.Enabled = false;
            else
                rollBtn.Enabled = true;
        }

        private void die1Timer_Tick(object sender, EventArgs e)
        {
            die1Timer.Stop();
            dieOne = random.Next(1, 7);
            if (dieOne == 1)
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
            if (dieOne == 2)
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
            if (dieOne == 3)
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
            if (dieOne == 4)
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
            if (dieOne == 5)
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
            if (dieOne == 6)
                die1Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
            die1Timer.Start();
        }

        private void die2Timer_Tick(object sender, EventArgs e)
        {
            die2Timer.Stop();
            dieTwo = random.Next(1, 7);
            if (dieTwo == 1)
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
            if (dieTwo == 2)
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
            if (dieTwo == 3)
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
            if (dieTwo == 4)
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
            if (dieTwo == 5)
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
            if (dieTwo == 6)
                die2Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
            die2Timer.Start();
        }

        private void die3Timer_Tick(object sender, EventArgs e)
        {
            die3Timer.Stop();
            dieThree = random.Next(1, 7);
            if (dieThree == 1)
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
            if (dieThree == 2)
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
            if (dieThree == 3)
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
            if (dieThree == 4)
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
            if (dieThree == 5)
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
            if (dieThree == 6)
                die3Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
            die3Timer.Start();
        }

        private void die4Timer_Tick(object sender, EventArgs e)
        {
            die4Timer.Stop();
            dieFour = random.Next(1, 7);
            if (dieFour == 1)
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
            if (dieFour == 2)
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
            if (dieFour == 3)
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
            if (dieFour == 4)
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
            if (dieFour == 5)
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
            if (dieFour == 6)
                die4Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
            die4Timer.Start();
        }

        private void die5Timer_Tick(object sender, EventArgs e)
        {
            die5Timer.Stop();
            dieFive = random.Next(1, 7);
            if (dieFive == 1)
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
            if (dieFive == 2)
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
            if (dieFive == 3)
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
            if (dieFive == 4)
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
            if (dieFive == 5)
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
            if (dieFive == 6)
                die5Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
            die5Timer.Start();
        }

        private void die6Timer_Tick(object sender, EventArgs e)
        {
            die6Timer.Stop();
            dieSix = random.Next(1, 7);
            if (dieSix == 1)
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 1.png");
            if (dieSix == 2)
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 2.png");
            if (dieSix == 3)
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 3.png");
            if (dieSix == 4)
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 4.png");
            if (dieSix == 5)
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 5.png");
            if (dieSix == 6)
                die6Pic.Image = Image.FromFile("C:\\Users\\Nathaniel\\Documents\\UVU Classes\\CS 2300\\NathanielsZilchForm\\Die 6.png");
            die6Timer.Start();
        }
    }
}