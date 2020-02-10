namespace HelloWorldJohnO
{
    partial class frmHelloWorld
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.lblByJohnO = new System.Windows.Forms.Label();
            this.picliluzivert2 = new System.Windows.Forms.PictureBox();
            this.picliluzivert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picliluzivert2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picliluzivert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.Red;
            this.lblHelloWorld.Location = new System.Drawing.Point(181, 44);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(225, 41);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello, World!";
            this.lblHelloWorld.Click += new System.EventHandler(this.LblHelloWorld_Click);
            // 
            // lblByJohnO
            // 
            this.lblByJohnO.AutoSize = true;
            this.lblByJohnO.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByJohnO.ForeColor = System.Drawing.Color.Red;
            this.lblByJohnO.Location = new System.Drawing.Point(440, 111);
            this.lblByJohnO.Name = "lblByJohnO";
            this.lblByJohnO.Size = new System.Drawing.Size(157, 31);
            this.lblByJohnO.TabIndex = 2;
            this.lblByJohnO.Text = "By John O.";
            this.lblByJohnO.Click += new System.EventHandler(this.LblByJohnO_Click);
            // 
            // picliluzivert2
            // 
            this.picliluzivert2.Image = global::HelloWorldJohnO.Properties.Resources.lil_uzi_vert_cover_1;
            this.picliluzivert2.Location = new System.Drawing.Point(446, 281);
            this.picliluzivert2.Name = "picliluzivert2";
            this.picliluzivert2.Size = new System.Drawing.Size(327, 167);
            this.picliluzivert2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picliluzivert2.TabIndex = 3;
            this.picliluzivert2.TabStop = false;
            // 
            // picliluzivert
            // 
            this.picliluzivert.Image = global::HelloWorldJohnO.Properties.Resources.uziiii;
            this.picliluzivert.Location = new System.Drawing.Point(0, 239);
            this.picliluzivert.Name = "picliluzivert";
            this.picliluzivert.Size = new System.Drawing.Size(277, 209);
            this.picliluzivert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picliluzivert.TabIndex = 1;
            this.picliluzivert.TabStop = false;
            this.picliluzivert.Click += new System.EventHandler(this.Picliluzivert_Click);
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picliluzivert2);
            this.Controls.Add(this.lblByJohnO);
            this.Controls.Add(this.picliluzivert);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World! by John O.";
            this.Load += new System.EventHandler(this.FrmHelloWorld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picliluzivert2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picliluzivert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.PictureBox picliluzivert;
        private System.Windows.Forms.Label lblByJohnO;
        private System.Windows.Forms.PictureBox picliluzivert2;
    }
}

