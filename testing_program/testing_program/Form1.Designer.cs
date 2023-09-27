namespace testing_program
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
            this.buttonstart = new System.Windows.Forms.Button();
            this.labelcpu = new System.Windows.Forms.Label();
            this.labelram = new System.Windows.Forms.Label();
            this.progressBarcpu = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(713, 415);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 23);
            this.buttonstart.TabIndex = 0;
            this.buttonstart.Text = "start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.click_buttonstart);
            // 
            // labelcpu
            // 
            this.labelcpu.AutoSize = true;
            this.labelcpu.Location = new System.Drawing.Point(12, 9);
            this.labelcpu.Name = "labelcpu";
            this.labelcpu.Size = new System.Drawing.Size(52, 15);
            this.labelcpu.TabIndex = 1;
            this.labelcpu.Text = "labelcpu";
            // 
            // labelram
            // 
            this.labelram.AutoSize = true;
            this.labelram.Location = new System.Drawing.Point(306, 185);
            this.labelram.Name = "labelram";
            this.labelram.Size = new System.Drawing.Size(53, 15);
            this.labelram.TabIndex = 2;
            this.labelram.Text = "labelram";
            // 
            // progressBarcpu
            // 
            this.progressBarcpu.Location = new System.Drawing.Point(12, 27);
            this.progressBarcpu.Name = "progressBarcpu";
            this.progressBarcpu.Size = new System.Drawing.Size(776, 23);
            this.progressBarcpu.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarcpu);
            this.Controls.Add(this.labelram);
            this.Controls.Add(this.labelcpu);
            this.Controls.Add(this.buttonstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonstart;
        private Label labelcpu;
        private Label labelram;
        private ProgressBar progressBarcpu;
    }
}