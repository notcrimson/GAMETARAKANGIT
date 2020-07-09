namespace GAMETARAKAN
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewGame = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "TARAKAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAMETARAKAN.Properties.Resources.bottom;
            this.pictureBox1.Location = new System.Drawing.Point(247, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.White;
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGame.Location = new System.Drawing.Point(282, 128);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(221, 38);
            this.NewGame.TabIndex = 3;
            this.NewGame.Text = "New game";
            this.NewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            this.NewGame.MouseLeave += new System.EventHandler(this.NewGame_MouseLeave);
            this.NewGame.MouseHover += new System.EventHandler(this.NewGame_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GAMETARAKAN.Properties.Resources.bottom;
            this.pictureBox2.Location = new System.Drawing.Point(247, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(282, 217);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(222, 37);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseHover += new System.EventHandler(this.Exit_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NewGame;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Exit;
    }
}