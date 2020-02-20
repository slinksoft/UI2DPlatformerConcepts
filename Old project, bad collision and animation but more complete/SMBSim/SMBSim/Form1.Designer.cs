namespace SMBSim
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
            this.marioMovementCollision = new System.Windows.Forms.Timer(this.components);
            this.gravityTimer = new System.Windows.Forms.Timer(this.components);
            this.jumpTimer = new System.Windows.Forms.Timer(this.components);
            this.aniTimer = new System.Windows.Forms.Timer(this.components);
            this.itemTimer = new System.Windows.Forms.Timer(this.components);
            this.mushroomAI = new System.Windows.Forms.Timer(this.components);
            this.goombaAI = new System.Windows.Forms.Timer(this.components);
            this.enemykillcheck = new System.Windows.Forms.Timer(this.components);
            this.marioDeath = new System.Windows.Forms.Timer(this.components);
            this.fireAI = new System.Windows.Forms.Timer(this.components);
            this.marioHit = new System.Windows.Forms.Timer(this.components);
            this.invicibleDelay = new System.Windows.Forms.Timer(this.components);
            this.rightBorder = new System.Windows.Forms.PictureBox();
            this.leftBorder = new System.Windows.Forms.PictureBox();
            this.fireball2 = new System.Windows.Forms.PictureBox();
            this.fireball1 = new System.Windows.Forms.PictureBox();
            this.goomba1 = new System.Windows.Forms.PictureBox();
            this.qblockC2 = new System.Windows.Forms.PictureBox();
            this.qblockC1 = new System.Windows.Forms.PictureBox();
            this.qblockP2 = new System.Windows.Forms.PictureBox();
            this.qblockP1 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.flower1 = new System.Windows.Forms.PictureBox();
            this.ground4 = new System.Windows.Forms.PictureBox();
            this.ground3 = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.mario = new System.Windows.Forms.PictureBox();
            this.mushroom1 = new System.Windows.Forms.PictureBox();
            this.mainground = new System.Windows.Forms.PictureBox();
            this.marioDeathdelay = new System.Windows.Forms.Timer(this.components);
            this.mainfloor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goomba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qblockC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qblockC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qblockP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qblockP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainfloor)).BeginInit();
            this.SuspendLayout();
            // 
            // marioMovementCollision
            // 
            this.marioMovementCollision.Enabled = true;
            this.marioMovementCollision.Interval = 20;
            this.marioMovementCollision.Tick += new System.EventHandler(this.marioMovementCollision_Tick);
            // 
            // gravityTimer
            // 
            this.gravityTimer.Enabled = true;
            this.gravityTimer.Interval = 20;
            this.gravityTimer.Tick += new System.EventHandler(this.gravityTimer_Tick);
            // 
            // jumpTimer
            // 
            this.jumpTimer.Interval = 20;
            this.jumpTimer.Tick += new System.EventHandler(this.jumpTimer_Tick);
            // 
            // aniTimer
            // 
            this.aniTimer.Enabled = true;
            this.aniTimer.Interval = 20;
            this.aniTimer.Tick += new System.EventHandler(this.aniTimer_Tick);
            // 
            // itemTimer
            // 
            this.itemTimer.Enabled = true;
            this.itemTimer.Interval = 10;
            this.itemTimer.Tick += new System.EventHandler(this.itemTimer_Tick);
            // 
            // mushroomAI
            // 
            this.mushroomAI.Interval = 20;
            this.mushroomAI.Tick += new System.EventHandler(this.mushroomAI_Tick);
            // 
            // goombaAI
            // 
            this.goombaAI.Enabled = true;
            this.goombaAI.Interval = 20;
            this.goombaAI.Tick += new System.EventHandler(this.goombaAI_Tick);
            // 
            // enemykillcheck
            // 
            this.enemykillcheck.Enabled = true;
            this.enemykillcheck.Interval = 20;
            this.enemykillcheck.Tick += new System.EventHandler(this.enemykillcheck_Tick);
            // 
            // marioDeath
            // 
            this.marioDeath.Interval = 40;
            this.marioDeath.Tick += new System.EventHandler(this.marioDeath_Tick);
            // 
            // fireAI
            // 
            this.fireAI.Interval = 20;
            this.fireAI.Tick += new System.EventHandler(this.fireAI_Tick);
            // 
            // marioHit
            // 
            this.marioHit.Enabled = true;
            this.marioHit.Interval = 20;
            this.marioHit.Tick += new System.EventHandler(this.marioHit_Tick);
            // 
            // invicibleDelay
            // 
            this.invicibleDelay.Interval = 3000;
            this.invicibleDelay.Tick += new System.EventHandler(this.invicibleDelay_Tick);
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.Lime;
            this.rightBorder.Location = new System.Drawing.Point(687, 0);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(24, 366);
            this.rightBorder.TabIndex = 18;
            this.rightBorder.TabStop = false;
            this.rightBorder.Visible = false;
            // 
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.Lime;
            this.leftBorder.Location = new System.Drawing.Point(-47, 0);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(41, 366);
            this.leftBorder.TabIndex = 17;
            this.leftBorder.TabStop = false;
            this.leftBorder.Visible = false;
            // 
            // fireball2
            // 
            this.fireball2.BackColor = System.Drawing.Color.Transparent;
            this.fireball2.Image = global::SMBSim.Properties.Resources.fire;
            this.fireball2.Location = new System.Drawing.Point(10000, 30000);
            this.fireball2.Name = "fireball2";
            this.fireball2.Size = new System.Drawing.Size(17, 23);
            this.fireball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireball2.TabIndex = 16;
            this.fireball2.TabStop = false;
            // 
            // fireball1
            // 
            this.fireball1.BackColor = System.Drawing.Color.Transparent;
            this.fireball1.Image = global::SMBSim.Properties.Resources.fire;
            this.fireball1.Location = new System.Drawing.Point(10000, 30000);
            this.fireball1.Name = "fireball1";
            this.fireball1.Size = new System.Drawing.Size(17, 23);
            this.fireball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireball1.TabIndex = 15;
            this.fireball1.TabStop = false;
            // 
            // goomba1
            // 
            this.goomba1.BackColor = System.Drawing.Color.Transparent;
            this.goomba1.Image = global::SMBSim.Properties.Resources.Goomba;
            this.goomba1.Location = new System.Drawing.Point(581, 117);
            this.goomba1.Name = "goomba1";
            this.goomba1.Size = new System.Drawing.Size(44, 38);
            this.goomba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goomba1.TabIndex = 14;
            this.goomba1.TabStop = false;
            // 
            // qblockC2
            // 
            this.qblockC2.BackColor = System.Drawing.Color.Transparent;
            this.qblockC2.Image = global::SMBSim.Properties.Resources.questionblock;
            this.qblockC2.Location = new System.Drawing.Point(21, -22);
            this.qblockC2.Name = "qblockC2";
            this.qblockC2.Size = new System.Drawing.Size(40, 40);
            this.qblockC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qblockC2.TabIndex = 13;
            this.qblockC2.TabStop = false;
            // 
            // qblockC1
            // 
            this.qblockC1.BackColor = System.Drawing.Color.Transparent;
            this.qblockC1.Image = global::SMBSim.Properties.Resources.questionblock;
            this.qblockC1.Location = new System.Drawing.Point(186, 16);
            this.qblockC1.Name = "qblockC1";
            this.qblockC1.Size = new System.Drawing.Size(40, 40);
            this.qblockC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qblockC1.TabIndex = 12;
            this.qblockC1.TabStop = false;
            // 
            // qblockP2
            // 
            this.qblockP2.BackColor = System.Drawing.Color.Transparent;
            this.qblockP2.Image = global::SMBSim.Properties.Resources.questionblock;
            this.qblockP2.Location = new System.Drawing.Point(585, 47);
            this.qblockP2.Name = "qblockP2";
            this.qblockP2.Size = new System.Drawing.Size(40, 40);
            this.qblockP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qblockP2.TabIndex = 10;
            this.qblockP2.TabStop = false;
            // 
            // qblockP1
            // 
            this.qblockP1.BackColor = System.Drawing.Color.Transparent;
            this.qblockP1.Image = global::SMBSim.Properties.Resources.questionblock;
            this.qblockP1.Location = new System.Drawing.Point(276, 16);
            this.qblockP1.Name = "qblockP1";
            this.qblockP1.Size = new System.Drawing.Size(40, 40);
            this.qblockP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qblockP1.TabIndex = 9;
            this.qblockP1.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = global::SMBSim.Properties.Resources.coin;
            this.coin1.Location = new System.Drawing.Point(421, 97);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(17, 23);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 8;
            this.coin1.TabStop = false;
            // 
            // flower1
            // 
            this.flower1.BackColor = System.Drawing.Color.Transparent;
            this.flower1.Image = global::SMBSim.Properties.Resources.flower;
            this.flower1.Location = new System.Drawing.Point(30000, 30000);
            this.flower1.Name = "flower1";
            this.flower1.Size = new System.Drawing.Size(29, 34);
            this.flower1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flower1.TabIndex = 7;
            this.flower1.TabStop = false;
            // 
            // ground4
            // 
            this.ground4.BackColor = System.Drawing.Color.Black;
            this.ground4.BackgroundImage = global::SMBSim.Properties.Resources.brickblock;
            this.ground4.Location = new System.Drawing.Point(168, 168);
            this.ground4.Name = "ground4";
            this.ground4.Size = new System.Drawing.Size(163, 26);
            this.ground4.TabIndex = 5;
            this.ground4.TabStop = false;
            // 
            // ground3
            // 
            this.ground3.BackColor = System.Drawing.Color.Transparent;
            this.ground3.Image = global::SMBSim.Properties.Resources.pipe;
            this.ground3.Location = new System.Drawing.Point(351, 224);
            this.ground3.Name = "ground3";
            this.ground3.Size = new System.Drawing.Size(66, 115);
            this.ground3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground3.TabIndex = 4;
            this.ground3.TabStop = false;
            // 
            // ground2
            // 
            this.ground2.BackColor = System.Drawing.Color.Transparent;
            this.ground2.Image = global::SMBSim.Properties.Resources.pipe;
            this.ground2.Location = new System.Drawing.Point(581, 256);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(63, 83);
            this.ground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground2.TabIndex = 3;
            this.ground2.TabStop = false;
            // 
            // ground1
            // 
            this.ground1.BackColor = System.Drawing.Color.Black;
            this.ground1.BackgroundImage = global::SMBSim.Properties.Resources.brickblock;
            this.ground1.Location = new System.Drawing.Point(0, 97);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(86, 28);
            this.ground1.TabIndex = 1;
            this.ground1.TabStop = false;
            // 
            // mario
            // 
            this.mario.BackColor = System.Drawing.Color.Transparent;
            this.mario.Location = new System.Drawing.Point(28, 158);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(30, 36);
            this.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mario.TabIndex = 2;
            this.mario.TabStop = false;
            // 
            // mushroom1
            // 
            this.mushroom1.BackColor = System.Drawing.Color.Transparent;
            this.mushroom1.Image = global::SMBSim.Properties.Resources.mushroom;
            this.mushroom1.Location = new System.Drawing.Point(30000, 30000);
            this.mushroom1.Name = "mushroom1";
            this.mushroom1.Size = new System.Drawing.Size(29, 34);
            this.mushroom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mushroom1.TabIndex = 6;
            this.mushroom1.TabStop = false;
            // 
            // mainground
            // 
            this.mainground.Image = global::SMBSim.Properties.Resources.maingroundbg;
            this.mainground.Location = new System.Drawing.Point(0, 0);
            this.mainground.Name = "mainground";
            this.mainground.Size = new System.Drawing.Size(681, 366);
            this.mainground.TabIndex = 11;
            this.mainground.TabStop = false;
            // 
            // marioDeathdelay
            // 
            this.marioDeathdelay.Interval = 1000;
            this.marioDeathdelay.Tick += new System.EventHandler(this.marioDeathdelay_Tick);
            // 
            // mainfloor
            // 
            this.mainfloor.BackColor = System.Drawing.Color.Black;
            this.mainfloor.BackgroundImage = global::SMBSim.Properties.Resources.mainfloor;
            this.mainfloor.Location = new System.Drawing.Point(0, 325);
            this.mainfloor.Name = "mainfloor";
            this.mainfloor.Size = new System.Drawing.Size(681, 41);
            this.mainfloor.TabIndex = 19;
            this.mainfloor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMBSim.Properties.Resources.maingroundbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 364);
            this.Controls.Add(this.mainfloor);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.fireball2);
            this.Controls.Add(this.fireball1);
            this.Controls.Add(this.qblockC2);
            this.Controls.Add(this.qblockC1);
            this.Controls.Add(this.qblockP2);
            this.Controls.Add(this.qblockP1);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.flower1);
            this.Controls.Add(this.ground4);
            this.Controls.Add(this.ground3);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.mario);
            this.Controls.Add(this.mushroom1);
            this.Controls.Add(this.goomba1);
            this.Controls.Add(this.mainground);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goomba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qblockC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qblockC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qblockP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qblockP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainfloor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.PictureBox mario;
        private System.Windows.Forms.PictureBox ground2;
        private System.Windows.Forms.PictureBox ground3;
        private System.Windows.Forms.Timer marioMovementCollision;
        private System.Windows.Forms.Timer gravityTimer;
        private System.Windows.Forms.Timer jumpTimer;
        private System.Windows.Forms.PictureBox ground4;
        private System.Windows.Forms.Timer aniTimer;
        private System.Windows.Forms.PictureBox mushroom1;
        private System.Windows.Forms.Timer itemTimer;
        private System.Windows.Forms.PictureBox flower1;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox qblockP1;
        private System.Windows.Forms.Timer mushroomAI;
        private System.Windows.Forms.PictureBox qblockP2;
        private System.Windows.Forms.PictureBox mainground;
        private System.Windows.Forms.PictureBox qblockC1;
        private System.Windows.Forms.PictureBox qblockC2;
        private System.Windows.Forms.PictureBox goomba1;
        private System.Windows.Forms.Timer goombaAI;
        private System.Windows.Forms.Timer enemykillcheck;
        private System.Windows.Forms.Timer marioDeath;
        private System.Windows.Forms.Timer fireAI;
        private System.Windows.Forms.PictureBox fireball1;
        private System.Windows.Forms.PictureBox fireball2;
        private System.Windows.Forms.PictureBox leftBorder;
        private System.Windows.Forms.PictureBox rightBorder;
        private System.Windows.Forms.Timer marioHit;
        private System.Windows.Forms.Timer invicibleDelay;
        private System.Windows.Forms.Timer marioDeathdelay;
        private System.Windows.Forms.PictureBox mainfloor;
    }
}

