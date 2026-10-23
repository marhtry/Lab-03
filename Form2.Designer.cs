namespace Lab_02
{
    partial class Form2
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
            this.button3 = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.userControl11 = new Lab_02.UserControl1();
            this.userControl12 = new Lab_02.UserControl1();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(848, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 141);
            this.button3.TabIndex = 2;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonRight_click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(12, 228);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(55, 141);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(92, 34);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(376, 513);
            this.userControl11.TabIndex = 4;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(466, 34);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(376, 513);
            this.userControl12.TabIndex = 5;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(915, 605);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.button3);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.mainForm2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonLeft;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
    }
}