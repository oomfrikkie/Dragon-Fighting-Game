namespace Dragon_Fighting_Game
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRest = new System.Windows.Forms.Button();
            this.gbx6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDragonHp2 = new System.Windows.Forms.Label();
            this.gbx7 = new System.Windows.Forms.GroupBox();
            this.rtbBattleLog = new System.Windows.Forms.RichTextBox();
            this.gbx5 = new System.Windows.Forms.GroupBox();
            this.lblDragonHp1 = new System.Windows.Forms.Label();
            this.btnAtk = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnSAtk = new System.Windows.Forms.Button();
            this.gbx6.SuspendLayout();
            this.gbx7.SuspendLayout();
            this.gbx5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(273, 101);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(162, 152);
            this.btnRest.TabIndex = 9;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            // 
            // gbx6
            // 
            this.gbx6.Controls.Add(this.label1);
            this.gbx6.Controls.Add(this.lblDragonHp2);
            this.gbx6.Location = new System.Drawing.Point(441, 35);
            this.gbx6.Name = "gbx6";
            this.gbx6.Size = new System.Drawing.Size(206, 169);
            this.gbx6.TabIndex = 7;
            this.gbx6.TabStop = false;
            this.gbx6.Text = "Opponent X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "X, the X dragon";
            // 
            // lblDragonHp2
            // 
            this.lblDragonHp2.AutoSize = true;
            this.lblDragonHp2.Location = new System.Drawing.Point(69, 80);
            this.lblDragonHp2.Name = "lblDragonHp2";
            this.lblDragonHp2.Size = new System.Drawing.Size(40, 16);
            this.lblDragonHp2.TabIndex = 6;
            this.lblDragonHp2.Text = "HP: X";
            // 
            // gbx7
            // 
            this.gbx7.Controls.Add(this.rtbBattleLog);
            this.gbx7.Location = new System.Drawing.Point(25, 265);
            this.gbx7.Name = "gbx7";
            this.gbx7.Size = new System.Drawing.Size(534, 157);
            this.gbx7.TabIndex = 8;
            this.gbx7.TabStop = false;
            this.gbx7.Text = "Battle Log";
            // 
            // rtbBattleLog
            // 
            this.rtbBattleLog.Location = new System.Drawing.Point(6, 21);
            this.rtbBattleLog.Name = "rtbBattleLog";
            this.rtbBattleLog.Size = new System.Drawing.Size(522, 130);
            this.rtbBattleLog.TabIndex = 0;
            this.rtbBattleLog.Text = "";
            // 
            // gbx5
            // 
            this.gbx5.Controls.Add(this.lblDragonHp1);
            this.gbx5.Controls.Add(this.btnAtk);
            this.gbx5.Controls.Add(this.btnBlock);
            this.gbx5.Controls.Add(this.btnSAtk);
            this.gbx5.Location = new System.Drawing.Point(25, 17);
            this.gbx5.Name = "gbx5";
            this.gbx5.Size = new System.Drawing.Size(242, 242);
            this.gbx5.TabIndex = 6;
            this.gbx5.TabStop = false;
            this.gbx5.Text = "X , the X Dragon\'s turn";
            // 
            // lblDragonHp1
            // 
            this.lblDragonHp1.AutoSize = true;
            this.lblDragonHp1.Location = new System.Drawing.Point(47, 37);
            this.lblDragonHp1.Name = "lblDragonHp1";
            this.lblDragonHp1.Size = new System.Drawing.Size(40, 16);
            this.lblDragonHp1.TabIndex = 5;
            this.lblDragonHp1.Text = "HP: X";
            // 
            // btnAtk
            // 
            this.btnAtk.Location = new System.Drawing.Point(40, 84);
            this.btnAtk.Name = "btnAtk";
            this.btnAtk.Size = new System.Drawing.Size(157, 49);
            this.btnAtk.TabIndex = 2;
            this.btnAtk.Text = "Attack";
            this.btnAtk.UseVisualStyleBackColor = true;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(40, 139);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(157, 48);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnSAtk
            // 
            this.btnSAtk.Location = new System.Drawing.Point(40, 193);
            this.btnSAtk.Name = "btnSAtk";
            this.btnSAtk.Size = new System.Drawing.Size(157, 43);
            this.btnSAtk.TabIndex = 4;
            this.btnSAtk.Text = "Speical Attack";
            this.btnSAtk.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.gbx6);
            this.Controls.Add(this.gbx7);
            this.Controls.Add(this.gbx5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbx6.ResumeLayout(false);
            this.gbx6.PerformLayout();
            this.gbx7.ResumeLayout(false);
            this.gbx5.ResumeLayout(false);
            this.gbx5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.GroupBox gbx6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDragonHp2;
        private System.Windows.Forms.GroupBox gbx7;
        private System.Windows.Forms.RichTextBox rtbBattleLog;
        private System.Windows.Forms.GroupBox gbx5;
        private System.Windows.Forms.Label lblDragonHp1;
        private System.Windows.Forms.Button btnAtk;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnSAtk;
    }
}