using System;
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
        string[] p1Data2;
        string[] p2Data2;
        int[] p1Values2;
        int[] p2Values2;
        Random random = new Random();
        bool player1Blocking = false;
        bool player2Blocking = false;
        int currentPlayer = 0;

        //bro wtf is this
        public Form2(string[] p1Data, string[] p2Data, int[] p1Values, int[] p2Values)
        {

            p1Data2 = p1Data;
            p2Data2 = p2Data;
            p1Values2 = p1Values;
            p2Values2 = p2Values;

            InitializeComponent();
            TakeInitiative();

        }

        //loading form 2
        private void Form2_Load(object sender, EventArgs e)
        {

        }

          //player dragon hp
        private void lblDragonHp2_Click(object sender, EventArgs e)
        {

        }


        public int RandomRoll()
        {
            return random.Next(1, 7);
        }
        public int TakeInitiative() //determines whos going first for the round
        {

            int player1Roll;
            int player2Roll;
            while (true)
            {
                player1Roll = RandomRoll();
                player2Roll = RandomRoll();
                if (player1Roll != player2Roll)
                    break;
            }

            currentPlayer = (player1Roll > player2Roll) ? 1 : 2;
            return currentPlayer;
        }
        private void SwitchTurn()
        {
            currentPlayer = (currentPlayer == 1) ? 2 : 1;

        }
        private void EndRound() // redoes the dice roll for the next round
        {
            TakeInitiative();
        }
        private void Attack()
        {
            int targetPlayer = (currentPlayer == 1) ? 2 : 1;
            int PlayerAttack = (currentPlayer == 1) ? p1Values2[1] : p2Values2[1];
            int playerBlock = (targetPlayer == 1) ? p1Values2[2] : p2Values2[2];
            int damage = PlayerAttack;

            if (targetPlayer == 1 && player1Blocking) // if player 2 attacks and player 1 blocks
            {
                rtbBattleLog.AppendText($"\n{p2Data2[1]} attacked but {p1Data2[1]} blocked.\n -------------------------------------------------------");
                // Refresh the RichTextBox to ensure the text is displayed immediately
                rtbBattleLog.Refresh();
                return;
            }
            else if (targetPlayer == 2 && player2Blocking) // if player 1 attacks and player 2 blocks
            {
                rtbBattleLog.AppendText($"\n{p1Data2[1]} attacked but {p2Data2[1]} blocked.\n -------------------------------------------------------");
                // Refresh the RichTextBox to ensure the text is displayed immediately
                rtbBattleLog.Refresh();
                // Adjust damage based on opponent's block
                damage = Math.Max(PlayerAttack - playerBlock, 0);
            }

            // Apply damage to the target player
            if (targetPlayer == 1)
            {
                p1Values2[0] -= damage;
                rtbBattleLog.AppendText($"\n{p2Data2[1]} attacked {p1Data2[1]} for {damage} damage.\n -------------------------------------------------------");
            }
            else
            {
                p2Values2[0] -= damage;
                rtbBattleLog.AppendText($"\n{p1Data2[1]} attacked {p2Data2[1]} for {damage} damage.\n -------------------------------------------------------");
            }

            if (currentPlayer == 1)
            {
                SwitchTurn();
            }
            else
            {
                EndRound();
            }
        }

        //attack 
        private void btnAtk_Click(object sender, EventArgs e)
        {
            Attack();
        }

        private void CheckDefeated()
        {
            if (p1Values2[0] == 0)//whats with the "-----"?
            {
                rtbBattleLog.Text = ("\n Player 1 Has been defeat . \n Player 2 Wins!!!! \n -------------------------------------------------------");
            }
            else if (p2Values2[0] == 0)
            {
                rtbBattleLog.Text = ("\n Player 2 Has been defeat . \n Player 1 Wins!!!! \n -------------------------------------------------------");
            }
        }

        //rest button
        private void btnRest_Click(object sender, EventArgs e)
        {

        }
    }
}


