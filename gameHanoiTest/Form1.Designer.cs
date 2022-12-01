namespace gameHanoiTest
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
            this.userControl11 = new MOVABLECONTROL.UserControl1();
            this.userControl12 = new MOVABLECONTROL.UserControl1();
            this.userControl13 = new MOVABLECONTROL.UserControl1();
            this.controlbar1 = new gameHanoiTest.controlbar();
            this.controlbar2 = new gameHanoiTest.controlbar();
            this.controlbar3 = new gameHanoiTest.controlbar();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.Location = new System.Drawing.Point(100, 139);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(63, 39);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.White;
            this.userControl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl12.Location = new System.Drawing.Point(76, 184);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(118, 39);
            this.userControl12.TabIndex = 1;
            // 
            // userControl13
            // 
            this.userControl13.BackColor = System.Drawing.Color.White;
            this.userControl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl13.Location = new System.Drawing.Point(45, 229);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(177, 39);
            this.userControl13.TabIndex = 2;
            // 
            // controlbar1
            // 
            this.controlbar1.BackColor = System.Drawing.Color.Black;
            this.controlbar1.Location = new System.Drawing.Point(127, 97);
            this.controlbar1.Name = "controlbar1";
            this.controlbar1.Size = new System.Drawing.Size(11, 187);
            this.controlbar1.TabIndex = 3;
            // 
            // controlbar2
            // 
            this.controlbar2.BackColor = System.Drawing.Color.Black;
            this.controlbar2.Location = new System.Drawing.Point(347, 97);
            this.controlbar2.Name = "controlbar2";
            this.controlbar2.Size = new System.Drawing.Size(11, 187);
            this.controlbar2.TabIndex = 4;
            // 
            // controlbar3
            // 
            this.controlbar3.BackColor = System.Drawing.Color.Black;
            this.controlbar3.Location = new System.Drawing.Point(582, 97);
            this.controlbar3.Name = "controlbar3";
            this.controlbar3.Size = new System.Drawing.Size(11, 187);
            this.controlbar3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 381);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.controlbar3);
            this.Controls.Add(this.controlbar2);
            this.Controls.Add(this.controlbar1);
            this.Name = "Form1";
            this.Text = "Hanoi Towers Game User Input ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MOVABLECONTROL.UserControl1 userControl11;
        private MOVABLECONTROL.UserControl1 userControl12;
        private MOVABLECONTROL.UserControl1 userControl13;
        private controlbar controlbar1;
        private controlbar controlbar2;
        private controlbar controlbar3;
    }
}

