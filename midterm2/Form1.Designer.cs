
namespace midterm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PicSmile = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.TxtYourName = new System.Windows.Forms.TextBox();
            this.LblYourName = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.PicGoal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // PicSmile
            // 
            this.PicSmile.Image = ((System.Drawing.Image)(resources.GetObject("PicSmile.Image")));
            this.PicSmile.Location = new System.Drawing.Point(60, 50);
            this.PicSmile.Name = "PicSmile";
            this.PicSmile.Size = new System.Drawing.Size(30, 30);
            this.PicSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSmile.TabIndex = 0;
            this.PicSmile.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(207, 240);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(183, 23);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Score";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(216, 189);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(175, 29);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // TxtYourName
            // 
            this.TxtYourName.Location = new System.Drawing.Point(211, 284);
            this.TxtYourName.Name = "TxtYourName";
            this.TxtYourName.Size = new System.Drawing.Size(179, 19);
            this.TxtYourName.TabIndex = 4;
            // 
            // LblYourName
            // 
            this.LblYourName.AutoSize = true;
            this.LblYourName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYourName.Location = new System.Drawing.Point(209, 267);
            this.LblYourName.Name = "LblYourName";
            this.LblYourName.Size = new System.Drawing.Size(99, 15);
            this.LblYourName.TabIndex = 5;
            this.LblYourName.Text = "Enter your name:";
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(211, 309);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(354, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(207, 218);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(183, 23);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "Press SPACE-BAR to start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicGoal
            // 
            this.PicGoal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PicGoal.Location = new System.Drawing.Point(202, 163);
            this.PicGoal.Name = "PicGoal";
            this.PicGoal.Size = new System.Drawing.Size(196, 185);
            this.PicGoal.TabIndex = 9;
            this.PicGoal.TabStop = false;
            this.PicGoal.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblYourName);
            this.Controls.Add(this.TxtYourName);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.PicSmile);
            this.Controls.Add(this.PicGoal);
            this.Name = "Form1";
            this.Text = "Labyrinth";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicSmile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGoal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicSmile;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.TextBox TxtYourName;
        private System.Windows.Forms.Label LblYourName;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox PicGoal;
    }
}

