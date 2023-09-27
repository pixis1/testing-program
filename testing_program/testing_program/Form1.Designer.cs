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
            this.labelcpu = new System.Windows.Forms.Label();
            this.labelram = new System.Windows.Forms.Label();
            this.buttondeleteallcashe = new System.Windows.Forms.Button();
            this.buttondeletewebcashe = new System.Windows.Forms.Button();
            this.buttondeletestdcashe = new System.Windows.Forms.Button();
            this.buttontoautorun = new System.Windows.Forms.Button();
            this.textexetorun = new System.Windows.Forms.TextBox();
            this.buttontonotautorun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelcpu
            // 
            this.labelcpu.AutoSize = true;
            this.labelcpu.Location = new System.Drawing.Point(12, 426);
            this.labelcpu.Name = "labelcpu";
            this.labelcpu.Size = new System.Drawing.Size(27, 15);
            this.labelcpu.TabIndex = 0;
            this.labelcpu.Text = "cpu";
            // 
            // labelram
            // 
            this.labelram.AutoSize = true;
            this.labelram.Location = new System.Drawing.Point(12, 411);
            this.labelram.Name = "labelram";
            this.labelram.Size = new System.Drawing.Size(28, 15);
            this.labelram.TabIndex = 1;
            this.labelram.Text = "ram";
            // 
            // buttondeleteallcashe
            // 
            this.buttondeleteallcashe.Location = new System.Drawing.Point(554, 418);
            this.buttondeleteallcashe.Name = "buttondeleteallcashe";
            this.buttondeleteallcashe.Size = new System.Drawing.Size(234, 23);
            this.buttondeleteallcashe.TabIndex = 2;
            this.buttondeleteallcashe.Text = "Delete All Cashe Files";
            this.buttondeleteallcashe.UseVisualStyleBackColor = true;
            this.buttondeleteallcashe.Click += new System.EventHandler(this.deleteAllCashe);
            // 
            // buttondeletewebcashe
            // 
            this.buttondeletewebcashe.Location = new System.Drawing.Point(554, 389);
            this.buttondeletewebcashe.Name = "buttondeletewebcashe";
            this.buttondeletewebcashe.Size = new System.Drawing.Size(234, 23);
            this.buttondeletewebcashe.TabIndex = 3;
            this.buttondeletewebcashe.Text = "Delete Web-Browser Cashe";
            this.buttondeletewebcashe.UseVisualStyleBackColor = true;
            this.buttondeletewebcashe.Click += new System.EventHandler(this.buttondeletewebcashe_Click);
            // 
            // buttondeletestdcashe
            // 
            this.buttondeletestdcashe.Location = new System.Drawing.Point(554, 360);
            this.buttondeletestdcashe.Name = "buttondeletestdcashe";
            this.buttondeletestdcashe.Size = new System.Drawing.Size(234, 23);
            this.buttondeletestdcashe.TabIndex = 4;
            this.buttondeletestdcashe.Text = "Delete Standart Cashe";
            this.buttondeletestdcashe.UseVisualStyleBackColor = true;
            this.buttondeletestdcashe.Click += new System.EventHandler(this.buttondeletestdcashe_Click);
            // 
            // buttontoautorun
            // 
            this.buttontoautorun.Location = new System.Drawing.Point(554, 12);
            this.buttontoautorun.Name = "buttontoautorun";
            this.buttontoautorun.Size = new System.Drawing.Size(234, 23);
            this.buttontoautorun.TabIndex = 5;
            this.buttontoautorun.Text = "Click To Autorun";
            this.buttontoautorun.UseVisualStyleBackColor = true;
            this.buttontoautorun.Click += new System.EventHandler(this.buttontoautorun_Click);
            // 
            // textexetorun
            // 
            this.textexetorun.Location = new System.Drawing.Point(12, 12);
            this.textexetorun.Name = "textexetorun";
            this.textexetorun.Size = new System.Drawing.Size(536, 23);
            this.textexetorun.TabIndex = 6;
            this.textexetorun.Text = "Full Name To Executuble";
            // 
            // buttontonotautorun
            // 
            this.buttontonotautorun.Location = new System.Drawing.Point(554, 41);
            this.buttontonotautorun.Name = "buttontonotautorun";
            this.buttontonotautorun.Size = new System.Drawing.Size(234, 23);
            this.buttontonotautorun.TabIndex = 7;
            this.buttontonotautorun.Text = "Click To Unautorun";
            this.buttontonotautorun.UseVisualStyleBackColor = true;
            this.buttontonotautorun.Click += new System.EventHandler(this.buttontonotautorun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttontonotautorun);
            this.Controls.Add(this.textexetorun);
            this.Controls.Add(this.buttontoautorun);
            this.Controls.Add(this.buttondeletestdcashe);
            this.Controls.Add(this.buttondeletewebcashe);
            this.Controls.Add(this.buttondeleteallcashe);
            this.Controls.Add(this.labelram);
            this.Controls.Add(this.labelcpu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelcpu;
        private Label labelram;
        private Button buttondeleteallcashe;
        private Button buttondeletewebcashe;
        private Button buttondeletestdcashe;
        private Button buttontoautorun;
        private TextBox textexetorun;
        private Button buttontonotautorun;
    }
}