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
            this.gbx7 = new System.Windows.Forms.GroupBox();
            this.rtbBattleLog = new System.Windows.Forms.RichTextBox();
            this.gbx5 = new System.Windows.Forms.GroupBox();
            this.lblDragon1Hp = new System.Windows.Forms.Label();
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
            this.btnRest.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.Color.Red;
            this.btnRest.Location = new System.Drawing.Point(205, 87);
            this.btnRest.Margin = new System.Windows.Forms.Padding(2);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(122, 124);
            this.btnRest.TabIndex = 9;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            // 
            // gbx6
            // 
            this.gbx6.BackColor = System.Drawing.Color.Transparent;
            this.gbx6.Controls.Add(this.label1);
            this.gbx6.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx6.Location = new System.Drawing.Point(331, 28);
            this.gbx6.Margin = new System.Windows.Forms.Padding(2);
            this.gbx6.Name = "gbx6";
            this.gbx6.Padding = new System.Windows.Forms.Padding(2);
            this.gbx6.Size = new System.Drawing.Size(154, 137);
            this.gbx6.TabIndex = 7;
            this.gbx6.TabStop = false;
            this.gbx6.Text = "Opponent X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "HP: ";
            // 
            // gbx7
            // 
            this.gbx7.BackColor = System.Drawing.Color.Transparent;
            this.gbx7.Controls.Add(this.rtbBattleLog);
            this.gbx7.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx7.Location = new System.Drawing.Point(19, 215);
            this.gbx7.Margin = new System.Windows.Forms.Padding(2);
            this.gbx7.Name = "gbx7";
            this.gbx7.Padding = new System.Windows.Forms.Padding(2);
            this.gbx7.Size = new System.Drawing.Size(400, 128);
            this.gbx7.TabIndex = 8;
            this.gbx7.TabStop = false;
            this.gbx7.Text = "Battle Log";
            // 
            // rtbBattleLog
            // 
            this.rtbBattleLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbBattleLog.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBattleLog.Location = new System.Drawing.Point(4, 17);
            this.rtbBattleLog.Margin = new System.Windows.Forms.Padding(2);
            this.rtbBattleLog.Name = "rtbBattleLog";
            this.rtbBattleLog.Size = new System.Drawing.Size(462, 106);
            this.rtbBattleLog.TabIndex = 0;
            this.rtbBattleLog.Text = "";
            // 
            // gbx5
            // 
            this.gbx5.BackColor = System.Drawing.Color.Transparent;
            this.gbx5.Controls.Add(this.lblDragon1Hp);
            this.gbx5.Controls.Add(this.lblDragonHp1);
            this.gbx5.Controls.Add(this.btnAtk);
            this.gbx5.Controls.Add(this.btnBlock);
            this.gbx5.Controls.Add(this.btnSAtk);
            this.gbx5.Font = new System.Drawing.Font("Goudy Stout", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx5.Location = new System.Drawing.Point(19, 14);
            this.gbx5.Margin = new System.Windows.Forms.Padding(2);
            this.gbx5.Name = "gbx5";
            this.gbx5.Padding = new System.Windows.Forms.Padding(2);
            this.gbx5.Size = new System.Drawing.Size(182, 197);
            this.gbx5.TabIndex = 6;
            this.gbx5.TabStop = false;
            this.gbx5.Text = "X , the X Dragon\'s turn";
            this.gbx5.Enter += new System.EventHandler(this.gbx5_Enter);
            // 
            // lblDragon1Hp
            // 
            this.lblDragon1Hp.AutoSize = true;
            this.lblDragon1Hp.Location = new System.Drawing.Point(30, 50);
            this.lblDragon1Hp.Name = "lblDragon1Hp";
            this.lblDragon1Hp.Size = new System.Drawing.Size(44, 15);
            this.lblDragon1Hp.TabIndex = 6;
            this.lblDragon1Hp.Text = "HP:";
            // 
            // lblDragonHp1
            // 
            this.lblDragonHp1.AutoSize = true;
            this.lblDragonHp1.Location = new System.Drawing.Point(35, 30);
            this.lblDragonHp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDragonHp1.Name = "lblDragonHp1";
            this.lblDragonHp1.Size = new System.Drawing.Size(66, 15);
            this.lblDragonHp1.TabIndex = 5;
            this.lblDragonHp1.Text = "HP: X";
            // 
            // btnAtk
            // 
            this.btnAtk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAtk.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtk.ForeColor = System.Drawing.Color.Black;
            this.btnAtk.Location = new System.Drawing.Point(30, 68);
            this.btnAtk.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtk.Name = "btnAtk";
            this.btnAtk.Size = new System.Drawing.Size(118, 40);
            this.btnAtk.TabIndex = 2;
            this.btnAtk.Text = "Attack";
            this.btnAtk.UseVisualStyleBackColor = false;
            this.btnAtk.Click += new System.EventHandler(this.btnAtk_Click_1);
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBlock.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlock.Location = new System.Drawing.Point(30, 113);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(118, 39);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnSAtk
            // 
            this.btnSAtk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSAtk.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAtk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSAtk.Location = new System.Drawing.Point(30, 157);
            this.btnSAtk.Margin = new System.Windows.Forms.Padding(2);
            this.btnSAtk.Name = "btnSAtk";
            this.btnSAtk.Size = new System.Drawing.Size(118, 35);
            this.btnSAtk.TabIndex = 4;
            this.btnSAtk.Text = "Speical Attack";
            this.btnSAtk.UseVisualStyleBackColor = false;
            this.btnSAtk.Click += new System.EventHandler(this.btnSAtk_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dragon_Fighting_Game.Properties.Resources.dragon_battles_part_2;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.gbx6);
            this.Controls.Add(this.gbx7);
            this.Controls.Add(this.gbx5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
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
        private System.Windows.Forms.GroupBox gbx7;
        private System.Windows.Forms.RichTextBox rtbBattleLog;
        private System.Windows.Forms.GroupBox gbx5;
        private System.Windows.Forms.Label lblDragonHp1;
        private System.Windows.Forms.Button btnAtk;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnSAtk;
        private System.Windows.Forms.Label lblDragon1Hp;
    }
}