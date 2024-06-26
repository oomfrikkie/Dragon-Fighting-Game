﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragon_Fighting_Game
{

    //player block button
    public partial class Form2 : Form
    {
        //declaring the crucial variables
        string[] p1Data2;
        string[] p2Data2;
        int[] p1Values2;
        int[] p2Values2;

        bool player1Blocking = false;
        bool player2Blocking = false;

        int currentPlayer = 0;
        int RoundCounter = 0;
        
        Random random = new Random();
        Random random1 = new Random();
        bool player1Defeated = false;
        bool player2Defeated = false;

            bool player1Special = false;
            bool player2Special = false;

        public Form2(string[] p1Data, string[] p2Data, int[] p1Values, int[] p2Values) //bringing arrays from form1
        {
            p1Data2 = p1Data;
            p2Data2 = p2Data;
            p1Values2 = p1Values;
            p2Values2 = p2Values;
            InitializeComponent();
            btnRest.Visible = false;
            btnRest.Enabled = false;
            TakeInitiative();

        }

        //loading form 2
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }



        public int RandomRoll()
        {

            return random.Next(1, 7); 
            
        }
        public void TakeInitiative() //determines whos going first for the round
        {
           
            int player1Roll = RandomRoll();
            int player2Roll = RandomRoll();
            while (player1Roll == player2Roll)
            {
                player1Roll = RandomRoll();
                player2Roll = RandomRoll(); // this uses the RandomRoll() to determine who goes first

            }
            if (player1Roll > player2Roll)
            {
                gbx5.Text = ($"{p1Data2[1]},  the {p1Data2[2]} turn ");
                lblDragon1Hp.Text = ("HP" + p1Values2[0]);
                label1.Text = ($"HP: {p2Values2[0]}");
                gbx6.Text = ("Opponent" + p2Data2[1]);
                currentPlayer = 1;
                RoundCounter++;

            }
            else if (player1Roll < player2Roll)
            {
                gbx5.Text = ($"{p2Data2[1]},  the {p2Data2[2]} turn ");
                label1.Text = ($"HP: {p2Values2[0]}");
                lblDragon1Hp.Text = ("HP" + p2Values2[0]);
                gbx6.Text = ("Opponent" + p1Data2[1]);
                currentPlayer = 2;
                RoundCounter++;

            }





        }
        private void SwitchTurn() // switching turns between players
        {
            if (RoundCounter == 2) // resets round counter
            {
                RoundCounter = 0;
                TakeInitiative(); // r
            }

            if (currentPlayer == 1)
            {
                gbx5.Text = ($"{p1Data2[1]},  the {p1Data2[2]} turn ");
                lblDragon1Hp.Text = ("HP" + p1Values2[0]);
                label1.Text = ($"HP: {p2Values2[0]}");
                gbx6.Text = ("Opponent" + p2Data2[1]); // updating player datas

                if (player1Special == true)
                {
                    btnRest.Visible = true;
                    btnRest.Enabled = true;
                }
                else
                {
                    btnRest.Visible = false;
                    btnRest.Enabled = false;
                }
            }
            else if (currentPlayer == 2)
            {
                gbx5.Text = ($"{p2Data2[1]},  the {p2Data2[2]} turn ");
                lblDragon1Hp.Text = ($"HP: {p2Values2[0]}");
                label1.Text = ($"HP: {p1Values2[0]}");
                gbx6.Text = ("Opponent" + p1Data2[1]);

                if (player2Special == true)
                {
                    btnRest.Visible = true;
                    btnRest.Enabled = true;
                }
                else
                {
                    btnRest.Visible = false;
                    btnRest.Enabled = false;
                }
            }
        }


     
       
        

        private void btnAtk_Click_1(object sender, EventArgs e) // code for atk button
        {
            Attack();

            CheckDefeated();
            SwitchTurn();

            RoundCounter++;
        }
        private void Attack()
        {
            int damage;
            if (currentPlayer == 1)
            {
                if (player2Blocking == true) // if the opponent blocks
                {
                    player2Blocking = false;
                    damage = Math.Max(0, p1Values2[1] - p2Values2[2]); // Ensure damage is not negative
                    p2Values2[0] -= damage;
                    rtbBattleLog.Text += "\n" + p1Data2[1] + " attacked but " + p2Data2[1] + " blocked. " + damage + " damage was done.";
                }
                else
                {
                    p2Values2[0] -= p1Values2[1];
                    rtbBattleLog.Text += "\n" + p1Data2[1] + " attacked for " + p1Values2[1];
                }
            }
            else if (currentPlayer == 2)
            {
                if (player1Blocking == true) // if the opponent blocks
                {
                    player1Blocking = false;
                    damage = Math.Max(0, p2Values2[1] - p1Values2[2]); // Ensure damage is not negative
                    p1Values2[0] -= damage;
                    rtbBattleLog.Text += "\n" + p2Data2[1] + " attacked but " + p1Data2[1] + " blocked. " + damage + " damage was done.";
                }
                else
                {
                    p1Values2[0] -= p2Values2[1];
                    rtbBattleLog.Text += "\n" + p2Data2[1] + " attacked for " + p2Values2[1];
                }
            }






        }


        private void btnBlock_Click(object sender, EventArgs e) // code for the block button
        {
            Block();

            CheckDefeated();
            SwitchTurn();

            RoundCounter++;
        }
        private void Block()
        {
            if (currentPlayer == 1) //if the opponent blocks
            {
                player1Blocking = true;
                player2Blocking = false;

            }
            else if (currentPlayer == 2)
            {
                player2Blocking = true;
                player1Blocking = false;


            }



        }

        private void btnSAtk_Click(object sender, EventArgs e) // code for the special attack button
        {

            SAttack();

            CheckDefeated();
            SwitchTurn();

            RoundCounter++;
        }
        private void SAttack() // special attack funtionality
        {
            int damage;

            if (currentPlayer == 1)
            {
                if (player2Blocking == true) // if the opponent blocks
                {
                    player2Blocking = false;
                    damage = Math.Max(0, p1Values2[3] - p2Values2[2]); // Ensure damage is not negative
                    p2Values2[0] -= damage;
                    rtbBattleLog.Text += "\n" + p1Data2[1] + " used his special attack but " + p2Data2[1] + " blocked. " + damage + " damage was done.";
                }
                else
                {
                    p2Values2[0] -= p1Values2[3];
                    rtbBattleLog.Text += "\n" + p1Data2[1] + " used his special attack for " + p1Values2[3];
                }
                player1Special = true;
            }
            else if (currentPlayer == 2)
            {
                if (player1Blocking == true) // if the opponent blocks
                {
                    player1Blocking = false;
                    damage = Math.Max(0, p2Values2[3] - p1Values2[2]); // Ensure damage is not negative
                    p1Values2[0] -= damage;
                    rtbBattleLog.Text += "\n" + p2Data2[1] + " used his special attack but " + p1Data2[1] + " blocked. " + damage + " damage was done.";
                }
                else
                {
                    p1Values2[0] -= p2Values2[3];
                    rtbBattleLog.Text += "\n" + p2Data2[1] + " used his special attack for " + p2Values2[3];
                }
                player2Special = true;
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            Rest();
            CheckDefeated();
            SwitchTurn();

            RoundCounter++;

        }
        private void Rest()
        {
            if (currentPlayer == 1)
            {
                rtbBattleLog.Text = ($"{p1Data2[1]} Rested after his special");
                btnRest.Visible = false;
                btnRest.Enabled = false;
                player1Special = false;

            }
            else if (currentPlayer == 2)
            {
                rtbBattleLog.Text = ($"{p2Data2[1]} Rested after his special");
                btnRest.Visible = false;
                btnRest.Enabled = false;
                player2Special = false;
            }
        }



        private void CheckDefeated()//here is where the victor is decided
        {
            if (p1Values2[0] <= 0)
            {
                p1Values2[0] = 0;
                rtbBattleLog.Text = ($"\n {p1Data2[1]} Has been defeated . \n {p2Data2[1]}2 Wins!!!! \n -------------------------------------------------------");
                player1Defeated = true;
                btnAtk.Enabled = false;
                btnBlock.Enabled = false;
                btnSAtk.Enabled = false;
                btnRest.Enabled = false;
                btnRest.Visible = false;
            }
            else if (p2Values2[0] <= 0)
            {
                p2Values2[0] = 0;
                rtbBattleLog.Text = ($"\n {p2Data2[1]} Has been defeated . \n {p1Data2[1]} Wins!!!! \n -------------------------------------------------------");
                player2Defeated = true;
                btnAtk.Enabled = false;
                btnBlock.Enabled = false;
                btnSAtk.Enabled = false;
                btnRest.Enabled = false;
                btnRest.Visible = false;
            }
            
        }

       
     
        private void lblDragonHp2_Click(object sender, EventArgs e)
        {

        }
        private void gbx5_Enter(object sender, EventArgs e)
        {

        }
       

    }
}