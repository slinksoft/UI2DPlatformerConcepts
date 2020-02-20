namespace platformerconcept
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
            this.components = new System.ComponentModel.Container();
            this.movementAndGravity = new System.Windows.Forms.Timer(this.components);
            this.jump = new System.Windows.Forms.Timer(this.components);
            this.mario = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.pf1 = new System.Windows.Forms.PictureBox();
            this.pf2 = new System.Windows.Forms.PictureBox();
            this.pf3 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.enemyMovement = new System.Windows.Forms.Timer(this.components);
            this.goomba = new System.Windows.Forms.PictureBox();
            this.pf4 = new System.Windows.Forms.PictureBox();
            this.pf5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf5)).BeginInit();
            this.SuspendLayout();
            // 
            // movementAndGravity
            // 
            this.movementAndGravity.Enabled = true;
            this.movementAndGravity.Interval = 10;
            this.movementAndGravity.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // jump
            // 
            this.jump.Enabled = true;
            this.jump.Interval = 10;
            this.jump.Tick += new System.EventHandler(this.Jump_Tick);
            // 
            // mario
            // 
            this.mario.BackColor = System.Drawing.Color.Transparent;
            this.mario.Image = global::platformerconcept.Properties.Resources.littleidleright;
            this.mario.Location = new System.Drawing.Point(192, 71);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(27, 39);
            this.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mario.TabIndex = 2;
            this.mario.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackgroundImage = global::platformerconcept.Properties.Resources.mainfloor;
            this.floor.Location = new System.Drawing.Point(-19, 365);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(695, 132);
            this.floor.TabIndex = 3;
            this.floor.TabStop = false;
            // 
            // pf1
            // 
            this.pf1.BackgroundImage = global::platformerconcept.Properties.Resources.brickblock;
            this.pf1.Location = new System.Drawing.Point(509, 234);
            this.pf1.Name = "pf1";
            this.pf1.Size = new System.Drawing.Size(147, 38);
            this.pf1.TabIndex = 4;
            this.pf1.TabStop = false;
            // 
            // pf2
            // 
            this.pf2.BackgroundImage = global::platformerconcept.Properties.Resources.brickblock;
            this.pf2.Location = new System.Drawing.Point(267, 94);
            this.pf2.Name = "pf2";
            this.pf2.Size = new System.Drawing.Size(147, 38);
            this.pf2.TabIndex = 5;
            this.pf2.TabStop = false;
            // 
            // pf3
            // 
            this.pf3.BackgroundImage = global::platformerconcept.Properties.Resources.brickblock;
            this.pf3.Location = new System.Drawing.Point(12, 234);
            this.pf3.Name = "pf3";
            this.pf3.Size = new System.Drawing.Size(147, 38);
            this.pf3.TabIndex = 6;
            this.pf3.TabStop = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.White;
            this.background.Image = global::platformerconcept.Properties.Resources.mainground;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(676, 433);
            this.background.TabIndex = 7;
            this.background.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Transparent;
            this.coin3.Image = global::platformerconcept.Properties.Resources.coin;
            this.coin3.Location = new System.Drawing.Point(570, 172);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(21, 28);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 8;
            this.coin3.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.Image = global::platformerconcept.Properties.Resources.coin;
            this.coin2.Location = new System.Drawing.Point(330, 12);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(21, 28);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 9;
            this.coin2.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = global::platformerconcept.Properties.Resources.coin;
            this.coin1.Location = new System.Drawing.Point(73, 172);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(21, 28);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 10;
            this.coin1.TabStop = false;
            // 
            // enemyMovement
            // 
            this.enemyMovement.Enabled = true;
            this.enemyMovement.Interval = 50;
            this.enemyMovement.Tick += new System.EventHandler(this.EnemyMovement_Tick);
            // 
            // goomba
            // 
            this.goomba.BackColor = System.Drawing.Color.Transparent;
            this.goomba.Image = global::platformerconcept.Properties.Resources.Goomba;
            this.goomba.Location = new System.Drawing.Point(100, 172);
            this.goomba.Name = "goomba";
            this.goomba.Size = new System.Drawing.Size(42, 46);
            this.goomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goomba.TabIndex = 11;
            this.goomba.TabStop = false;
            // 
            // pf4
            // 
            this.pf4.BackgroundImage = global::platformerconcept.Properties.Resources.brickblock;
            this.pf4.Location = new System.Drawing.Point(-19, -25);
            this.pf4.Name = "pf4";
            this.pf4.Size = new System.Drawing.Size(36, 458);
            this.pf4.TabIndex = 12;
            this.pf4.TabStop = false;
            // 
            // pf5
            // 
            this.pf5.BackgroundImage = global::platformerconcept.Properties.Resources.brickblock;
            this.pf5.Location = new System.Drawing.Point(648, 0);
            this.pf5.Name = "pf5";
            this.pf5.Size = new System.Drawing.Size(28, 433);
            this.pf5.TabIndex = 13;
            this.pf5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::platformerconcept.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 425);
            this.Controls.Add(this.goomba);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.pf2);
            this.Controls.Add(this.mario);
            this.Controls.Add(this.pf5);
            this.Controls.Add(this.pf4);
            this.Controls.Add(this.pf1);
            this.Controls.Add(this.pf3);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(684, 464);
            this.MinimumSize = new System.Drawing.Size(684, 464);
            this.Name = "Form1";
            this.Text = "2D Platformer Concept";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pf5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer movementAndGravity;
        private System.Windows.Forms.Timer jump;
        private System.Windows.Forms.PictureBox mario;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox pf1;
        private System.Windows.Forms.PictureBox pf2;
        private System.Windows.Forms.PictureBox pf3;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.Timer enemyMovement;
        private System.Windows.Forms.PictureBox goomba;
        private System.Windows.Forms.PictureBox pf4;
        private System.Windows.Forms.PictureBox pf5;
    }
}

