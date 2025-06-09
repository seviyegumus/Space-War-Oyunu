namespace spacewar2
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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            oyuncuaracı = new PictureBox();
            Basitdusman = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)oyuncuaracı).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Basitdusman).BeginInit();
            SuspendLayout();
            // 
            // oyuncuaracı
            // 
            oyuncuaracı.BackColor = Color.Transparent;
            oyuncuaracı.BackgroundImage = (Image)resources.GetObject("oyuncuaracı.BackgroundImage");
            oyuncuaracı.Location = new Point(21, 245);
            oyuncuaracı.Name = "oyuncuaracı";
            oyuncuaracı.Size = new Size(78, 113);
            oyuncuaracı.TabIndex = 0;
            oyuncuaracı.TabStop = false;
            // 
            // Basitdusman
            // 
            Basitdusman.BackgroundImage = (Image)resources.GetObject("Basitdusman.BackgroundImage");
            Basitdusman.Location = new Point(1091, 285);
            Basitdusman.Name = "Basitdusman";
            Basitdusman.Size = new Size(31, 30);
            Basitdusman.TabIndex = 1;
            Basitdusman.TabStop = false;
            Basitdusman.Click += Basitdusman_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1209, 653);
            Controls.Add(Basitdusman);
            Controls.Add(oyuncuaracı);
            Name = "Form2";
            Text = "SpaceWar";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)oyuncuaracı).EndInit();
            ((System.ComponentModel.ISupportInitialize)Basitdusman).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox oyuncuaracı;
        private PictureBox Basitdusman;
    }
}