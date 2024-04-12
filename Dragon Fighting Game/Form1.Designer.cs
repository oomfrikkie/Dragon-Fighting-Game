namespace Dragon_Fighting_Game
{
    partial class Form1
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
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.gbx2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radFire1 = new System.Windows.Forms.RadioButton();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.txtDragon1Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radIce1 = new System.Windows.Forms.RadioButton();
            this.radWind1 = new System.Windows.Forms.RadioButton();
            this.radEarth1 = new System.Windows.Forms.RadioButton();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbx3 = new System.Windows.Forms.GroupBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDragon2Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.gbx4 = new System.Windows.Forms.GroupBox();
            this.radEarth2 = new System.Windows.Forms.RadioButton();
            this.radWind2 = new System.Windows.Forms.RadioButton();
            this.radIce2 = new System.Windows.Forms.RadioButton();
            this.radFIre2 = new System.Windows.Forms.RadioButton();
            this.gbx1.SuspendLayout();
            this.gbx2.SuspendLayout();
            this.gbx3.SuspendLayout();
            this.gbx4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.btnSave1);
            this.gbx1.Controls.Add(this.label2);
            this.gbx1.Controls.Add(this.txtDragon1Name);
            this.gbx1.Controls.Add(this.label1);
            this.gbx1.Controls.Add(this.txtPlayer1Name);
            this.gbx1.Controls.Add(this.gbx2);
            this.gbx1.Location = new System.Drawing.Point(21, 12);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(312, 334);
            this.gbx1.TabIndex = 0;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "Player 1";
            // 
            // gbx2
            // 
            this.gbx2.Controls.Add(this.radEarth1);
            this.gbx2.Controls.Add(this.radWind1);
            this.gbx2.Controls.Add(this.radIce1);
            this.gbx2.Controls.Add(this.radFire1);
            this.gbx2.Location = new System.Drawing.Point(30, 118);
            this.gbx2.Name = "gbx2";
            this.gbx2.Size = new System.Drawing.Size(199, 167);
            this.gbx2.TabIndex = 1;
            this.gbx2.TabStop = false;
            this.gbx2.Text = "Dragons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Name:";
            // 
            // radFire1
            // 
            this.radFire1.AutoSize = true;
            this.radFire1.Location = new System.Drawing.Point(15, 47);
            this.radFire1.Name = "radFire1";
            this.radFire1.Size = new System.Drawing.Size(99, 20);
            this.radFire1.TabIndex = 2;
            this.radFire1.TabStop = true;
            this.radFire1.Text = "Fire Dragon";
            this.radFire1.UseVisualStyleBackColor = true;
            this.radFire1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(111, 39);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(153, 22);
            this.txtPlayer1Name.TabIndex = 3;
            // 
            // txtDragon1Name
            // 
            this.txtDragon1Name.Location = new System.Drawing.Point(111, 79);
            this.txtDragon1Name.Name = "txtDragon1Name";
            this.txtDragon1Name.Size = new System.Drawing.Size(153, 22);
            this.txtDragon1Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dragon Name";
            // 
            // radIce1
            // 
            this.radIce1.AutoSize = true;
            this.radIce1.Location = new System.Drawing.Point(15, 73);
            this.radIce1.Name = "radIce1";
            this.radIce1.Size = new System.Drawing.Size(94, 20);
            this.radIce1.TabIndex = 3;
            this.radIce1.TabStop = true;
            this.radIce1.Text = "Ice Dragon";
            this.radIce1.UseVisualStyleBackColor = true;
            // 
            // radWind1
            // 
            this.radWind1.AutoSize = true;
            this.radWind1.Location = new System.Drawing.Point(15, 99);
            this.radWind1.Name = "radWind1";
            this.radWind1.Size = new System.Drawing.Size(107, 20);
            this.radWind1.TabIndex = 4;
            this.radWind1.TabStop = true;
            this.radWind1.Text = "Wind Dragon";
            this.radWind1.UseVisualStyleBackColor = true;
            // 
            // radEarth1
            // 
            this.radEarth1.AutoSize = true;
            this.radEarth1.Location = new System.Drawing.Point(15, 125);
            this.radEarth1.Name = "radEarth1";
            this.radEarth1.Size = new System.Drawing.Size(107, 20);
            this.radEarth1.TabIndex = 5;
            this.radEarth1.TabStop = true;
            this.radEarth1.Text = "Earth Dragon";
            this.radEarth1.UseVisualStyleBackColor = true;
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(6, 291);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(300, 40);
            this.btnSave1.TabIndex = 1;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 352);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(708, 86);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "START GAME";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // gbx3
            // 
            this.gbx3.Controls.Add(this.btnSave2);
            this.gbx3.Controls.Add(this.label3);
            this.gbx3.Controls.Add(this.txtDragon2Name);
            this.gbx3.Controls.Add(this.label4);
            this.gbx3.Controls.Add(this.txtPlayer2Name);
            this.gbx3.Controls.Add(this.gbx4);
            this.gbx3.Location = new System.Drawing.Point(417, 12);
            this.gbx3.Name = "gbx3";
            this.gbx3.Size = new System.Drawing.Size(312, 334);
            this.gbx3.TabIndex = 6;
            this.gbx3.TabStop = false;
            this.gbx3.Text = "Player 1";
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(6, 291);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(300, 40);
            this.btnSave2.TabIndex = 1;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dragon Name";
            // 
            // txtDragon2Name
            // 
            this.txtDragon2Name.Location = new System.Drawing.Point(111, 79);
            this.txtDragon2Name.Name = "txtDragon2Name";
            this.txtDragon2Name.Size = new System.Drawing.Size(153, 22);
            this.txtDragon2Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Player Name:";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(111, 39);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(153, 22);
            this.txtPlayer2Name.TabIndex = 3;
            // 
            // gbx4
            // 
            this.gbx4.Controls.Add(this.radEarth2);
            this.gbx4.Controls.Add(this.radWind2);
            this.gbx4.Controls.Add(this.radIce2);
            this.gbx4.Controls.Add(this.radFIre2);
            this.gbx4.Location = new System.Drawing.Point(30, 118);
            this.gbx4.Name = "gbx4";
            this.gbx4.Size = new System.Drawing.Size(199, 167);
            this.gbx4.TabIndex = 1;
            this.gbx4.TabStop = false;
            this.gbx4.Text = "Dragons";
            // 
            // radEarth2
            // 
            this.radEarth2.AutoSize = true;
            this.radEarth2.Location = new System.Drawing.Point(15, 125);
            this.radEarth2.Name = "radEarth2";
            this.radEarth2.Size = new System.Drawing.Size(107, 20);
            this.radEarth2.TabIndex = 5;
            this.radEarth2.TabStop = true;
            this.radEarth2.Text = "Earth Dragon";
            this.radEarth2.UseVisualStyleBackColor = true;
            // 
            // radWind2
            // 
            this.radWind2.AutoSize = true;
            this.radWind2.Location = new System.Drawing.Point(15, 99);
            this.radWind2.Name = "radWind2";
            this.radWind2.Size = new System.Drawing.Size(107, 20);
            this.radWind2.TabIndex = 4;
            this.radWind2.TabStop = true;
            this.radWind2.Text = "Wind Dragon";
            this.radWind2.UseVisualStyleBackColor = true;
            // 
            // radIce2
            // 
            this.radIce2.AutoSize = true;
            this.radIce2.Location = new System.Drawing.Point(15, 73);
            this.radIce2.Name = "radIce2";
            this.radIce2.Size = new System.Drawing.Size(94, 20);
            this.radIce2.TabIndex = 3;
            this.radIce2.TabStop = true;
            this.radIce2.Text = "Ice Dragon";
            this.radIce2.UseVisualStyleBackColor = true;
            // 
            // radFIre2
            // 
            this.radFIre2.AutoSize = true;
            this.radFIre2.Location = new System.Drawing.Point(15, 47);
            this.radFIre2.Name = "radFIre2";
            this.radFIre2.Size = new System.Drawing.Size(99, 20);
            this.radFIre2.TabIndex = 2;
            this.radFIre2.TabStop = true;
            this.radFIre2.Text = "Fire Dragon";
            this.radFIre2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbx1);
            this.Name = "Form1";
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.gbx2.ResumeLayout(false);
            this.gbx2.PerformLayout();
            this.gbx3.ResumeLayout(false);
            this.gbx3.PerformLayout();
            this.gbx4.ResumeLayout(false);
            this.gbx4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.TextBox txtDragon1Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.GroupBox gbx2;
        private System.Windows.Forms.RadioButton radFire1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radEarth1;
        private System.Windows.Forms.RadioButton radWind1;
        private System.Windows.Forms.RadioButton radIce1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbx3;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDragon2Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.GroupBox gbx4;
        private System.Windows.Forms.RadioButton radEarth2;
        private System.Windows.Forms.RadioButton radWind2;
        private System.Windows.Forms.RadioButton radIce2;
        private System.Windows.Forms.RadioButton radFIre2;
    }
}

