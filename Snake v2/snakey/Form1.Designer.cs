namespace snakey
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
            this.pbcanvas = new System.Windows.Forms.PictureBox();
            this.lblgaeover = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcanvas
            // 
            this.pbcanvas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbcanvas.Location = new System.Drawing.Point(13, 13);
            this.pbcanvas.Name = "pbcanvas";
            this.pbcanvas.Size = new System.Drawing.Size(513, 431);
            this.pbcanvas.TabIndex = 0;
            this.pbcanvas.TabStop = false;
            this.pbcanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbcanvas_Paint);
            // 
            // lblgaeover
            // 
            this.lblgaeover.AutoSize = true;
            this.lblgaeover.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgaeover.Location = new System.Drawing.Point(45, 42);
            this.lblgaeover.Name = "lblgaeover";
            this.lblgaeover.Size = new System.Drawing.Size(100, 37);
            this.lblgaeover.TabIndex = 1;
            this.lblgaeover.Text = "label1";
            this.lblgaeover.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(800, 13);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(102, 37);
            this.lblscore.TabIndex = 3;
            this.lblscore.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 495);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblgaeover);
            this.Controls.Add(this.pbcanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcanvas;
        private System.Windows.Forms.Label lblgaeover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Timer gametimer;
    }
}

