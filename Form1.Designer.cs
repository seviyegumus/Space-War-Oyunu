﻿namespace spacewar2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            startgamebutton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(243, 27);
            button1.Name = "button1";
            button1.Size = new Size(255, 94);
            button1.TabIndex = 0;
            button1.Text = "Spacewar Game";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(223, 164);
            button2.Name = "button2";
            button2.Size = new Size(160, 50);
            button2.TabIndex = 1;
            button2.Text = "Oyuncu Adı:";
            button2.UseVisualStyleBackColor = true;
            // 
            // startgamebutton
            // 
            startgamebutton.BackColor = SystemColors.ActiveCaption;
            startgamebutton.BackgroundImageLayout = ImageLayout.None;
            startgamebutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            startgamebutton.Location = new Point(298, 278);
            startgamebutton.Name = "startgamebutton";
            startgamebutton.Size = new Size(159, 56);
            startgamebutton.TabIndex = 3;
            startgamebutton.Text = "Start Game";
            startgamebutton.UseVisualStyleBackColor = false;
            startgamebutton.Click += startgamebutton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(415, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 27);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(startgamebutton);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button startgamebutton;
        private TextBox textBox1;
    }
}
