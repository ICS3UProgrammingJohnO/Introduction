namespace PerAreaVolJohnO
{
    partial class frmPerAreaVolJohn
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
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btlPerimeter = new System.Windows.Forms.Button();
            this.btlArea = new System.Windows.Forms.Button();
            this.btlVolume = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(304, 99);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(25, 13);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "???";
            this.lblPerimeter.Click += new System.EventHandler(this.LblPerimeter_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(304, 252);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(25, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "???";
            this.lblArea.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(304, 367);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(25, 13);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // btlPerimeter
            // 
            this.btlPerimeter.Location = new System.Drawing.Point(12, 47);
            this.btlPerimeter.Name = "btlPerimeter";
            this.btlPerimeter.Size = new System.Drawing.Size(196, 116);
            this.btlPerimeter.TabIndex = 4;
            this.btlPerimeter.Text = "Caculate the perimeter of a rectangle with the leagth 7cm and width 5cm";
            this.btlPerimeter.UseVisualStyleBackColor = true;
            this.btlPerimeter.Click += new System.EventHandler(this.BtlPerimeter_Click);
            // 
            // btlArea
            // 
            this.btlArea.Location = new System.Drawing.Point(12, 192);
            this.btlArea.Name = "btlArea";
            this.btlArea.Size = new System.Drawing.Size(196, 103);
            this.btlArea.TabIndex = 5;
            this.btlArea.Text = "caculate the area of of a cricle with the radius of 6";
            this.btlArea.UseVisualStyleBackColor = true;
            this.btlArea.Click += new System.EventHandler(this.BtlArea_Click);
            // 
            // btlVolume
            // 
            this.btlVolume.Location = new System.Drawing.Point(12, 326);
            this.btlVolume.Name = "btlVolume";
            this.btlVolume.Size = new System.Drawing.Size(196, 94);
            this.btlVolume.TabIndex = 6;
            this.btlVolume.Text = "Calculate the volume of a sphere with radius 4cm";
            this.btlVolume.UseVisualStyleBackColor = true;
            this.btlVolume.Click += new System.EventHandler(this.BtlVolume_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helloToolStripMenuItem.Text = "Program";
            this.helloToolStripMenuItem.Click += new System.EventHandler(this.HelloToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // frmPerAreaVolJohn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btlVolume);
            this.Controls.Add(this.btlArea);
            this.Controls.Add(this.btlPerimeter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPerAreaVolJohn";
            this.Text = "Perimeter, Area Volume by John O";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btlPerimeter;
        private System.Windows.Forms.Button btlArea;
        private System.Windows.Forms.Button btlVolume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

