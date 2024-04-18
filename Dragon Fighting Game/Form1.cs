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
    public partial class Form1 : Form
    {
        String[] p1Data = new string[3];
        String[] p2Data = new string[3];
        int[] p1Values = new int[4];
        int[] p2Values = new int[4];

        // Ice Dragon Stats
        string Ice_Dragon_Name = "Ice Dragon";
        int Ice_Dragon_Health = 30;
        int Ice_Dragon_Atk = 4;
        int Ice_Dragon_SAtk = 9;
        int Ice_Dragon_Block = 5;

        // Fire Dragon Stats
        string Fire_Dragon_Name = "Fire Dragon";
        int Fire_Dragon_Health = 20;
        int Fire_Dragon_Atk = 5;
        int Fire_Dragon_SAtk = 12;
        int Fire_Dragon_Block = 4;

        // Earth Dragon Stats
        string Earth_Dragon_Name = "Earth Dragon";
        int Earth_Dragon_Health = 50;
        int Earth_Dragon_Atk = 2;
        int Earth_Dragon_SAtk = 5;
        int Earth_Dragon_Block = 6;

        // Wind Dragon Stats
        string Wind_Dragon_Name = "Wind Dragon";
        int Wind_Dragon_Health = 40;
        int Wind_Dragon_Atk = 3;
        int Wind_Dragon_SAtk = 7;
        int Wind_Dragon_Block = 5;



        public Form1()
        {
            InitializeComponent();

        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            string player1Name = txtPlayer1Name.Text;
            string dragon1Name = txtDragon1Name.Text;
            string dragonType;

            p1Data[0] = player1Name;
            p1Data[1] = dragon1Name;
            
            if (!radFire1.Checked && !radIce1.Checked && ! radEarth1.Checked && !radWind1.Checked)
            {
                MessageBox.Show("Please Player 1 Select a Dragon");
                return;
            }
            if ( (player1Name == "" && dragon1Name == "")|| player1Name == "" || dragon1Name == "")
            {
                MessageBox.Show("Please Enter The Missing Name");
            }
        }

        private void radFire1_CheckedChanged(object sender, EventArgs e)
        {
            p1Data[2] = Fire_Dragon_Name;
            p1Values = new int[] { Fire_Dragon_Health, Fire_Dragon_Atk, Fire_Dragon_Block, Fire_Dragon_SAtk };

        }

        private void radIce1_CheckedChanged(object sender, EventArgs e)
        {
            p1Data[2] = Ice_Dragon_Name;
            p1Values = new int[] { Ice_Dragon_Health, Ice_Dragon_Atk, Ice_Dragon_Block, Ice_Dragon_SAtk };
        }

        private void radWind1_CheckedChanged(object sender, EventArgs e)
        {
            p1Data[2] = Wind_Dragon_Name; 
            p1Values = new int[] { Wind_Dragon_Health, Wind_Dragon_Atk, Wind_Dragon_Block, Wind_Dragon_SAtk };
        }

        private void radEarth1_CheckedChanged(object sender, EventArgs e)
        {
            p1Data[2] = Earth_Dragon_Name; 
            p1Values = new int[] { Earth_Dragon_Health, Earth_Dragon_Atk, Earth_Dragon_Block, Earth_Dragon_SAtk };
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            string player2Name = txtPlayer2Name.Text;
            string dragon2Name = txtDragon2Name.Text;
            string dragonType;

            p2Data[0] = player2Name;
            p2Data[1] = dragon2Name;

            if (!radFire2.Checked && !radIce2.Checked && !radEarth2.Checked && !radWind2.Checked)
            {
                MessageBox.Show("Please Player 1 Select a Dragon");
                return;
            }
            if ((player2Name == "" && dragon2Name == "") || player2Name == "" || dragon2Name == "")
            {
                MessageBox.Show("Please Enter The Missing Name");
            }

        }

        private void radFire2_CheckedChanged(object sender, EventArgs e)
        {
            p2Data[2] = Fire_Dragon_Name;
            p2Values = new int[] { Fire_Dragon_Health, Fire_Dragon_Atk, Fire_Dragon_Block, Fire_Dragon_SAtk };
        }

        private void radIce2_CheckedChanged(object sender, EventArgs e)
        {
            p2Data[2] = Ice_Dragon_Name;
            p2Values = new int[] { Ice_Dragon_Health, Ice_Dragon_Atk, Ice_Dragon_Block, Ice_Dragon_SAtk };
        }

        private void radWind2_CheckedChanged(object sender, EventArgs e)
        {
            p2Data[2] = Wind_Dragon_Name;
            p2Values = new int[] { Wind_Dragon_Health, Wind_Dragon_Atk, Wind_Dragon_Block, Wind_Dragon_SAtk };
        }

        private void radEarth2_CheckedChanged(object sender, EventArgs e)
        {
            p2Data[2] = Earth_Dragon_Name;
            p2Values = new int[] { Earth_Dragon_Health, Earth_Dragon_Atk, Earth_Dragon_Block, Earth_Dragon_SAtk };
        }
    }
}

