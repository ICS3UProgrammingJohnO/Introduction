namespace HelloIntJohnO
{
    partial class HelloIntForm
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbRadioButtons = new System.Windows.Forms.GroupBox();
            this.radYoruba = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radTurkish = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.grbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Red;
            this.lblGreeting.Location = new System.Drawing.Point(235, 163);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(216, 39);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // grbRadioButtons
            // 
            this.grbRadioButtons.Controls.Add(this.radTurkish);
            this.grbRadioButtons.Controls.Add(this.radSpanish);
            this.grbRadioButtons.Controls.Add(this.radYoruba);
            this.grbRadioButtons.Controls.Add(this.radEnglish);
            this.grbRadioButtons.Location = new System.Drawing.Point(88, 312);
            this.grbRadioButtons.Name = "grbRadioButtons";
            this.grbRadioButtons.Size = new System.Drawing.Size(529, 100);
            this.grbRadioButtons.TabIndex = 2;
            this.grbRadioButtons.TabStop = false;
            this.grbRadioButtons.Text = "Language";
            // 
            // radYoruba
            // 
            this.radYoruba.AutoSize = true;
            this.radYoruba.Location = new System.Drawing.Point(154, 19);
            this.radYoruba.Name = "radYoruba";
            this.radYoruba.Size = new System.Drawing.Size(59, 17);
            this.radYoruba.TabIndex = 1;
            this.radYoruba.TabStop = true;
            this.radYoruba.Text = "Yoruba";
            this.radYoruba.UseVisualStyleBackColor = true;
            this.radYoruba.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(18, 19);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // radTurkish
            // 
            this.radTurkish.AutoSize = true;
            this.radTurkish.Location = new System.Drawing.Point(425, 19);
            this.radTurkish.Name = "radTurkish";
            this.radTurkish.Size = new System.Drawing.Size(60, 17);
            this.radTurkish.TabIndex = 3;
            this.radTurkish.TabStop = true;
            this.radTurkish.Text = "Turkish";
            this.radTurkish.UseVisualStyleBackColor = true;
            this.radTurkish.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged_1);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Location = new System.Drawing.Point(278, 19);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(63, 17);
            this.radSpanish.TabIndex = 4;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Spanish";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // HelloIntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbRadioButtons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGreeting);
            this.Name = "HelloIntForm";
            this.Text = "Hello World International by John O";
            this.grbRadioButtons.ResumeLayout(false);
            this.grbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbRadioButtons;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radYoruba;
        private System.Windows.Forms.RadioButton radTurkish;
        private System.Windows.Forms.RadioButton radSpanish;
    }
}

