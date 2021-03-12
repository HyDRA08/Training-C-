namespace ADONETWindowsForm
{
    partial class FormView
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
            this.HRButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HRButton
            // 
            this.HRButton.Location = new System.Drawing.Point(76, 224);
            this.HRButton.Name = "HRButton";
            this.HRButton.Size = new System.Drawing.Size(188, 47);
            this.HRButton.TabIndex = 0;
            this.HRButton.Text = "HR";
            this.HRButton.UseVisualStyleBackColor = true;
            this.HRButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(485, 227);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(188, 44);
            this.EmployeeButton.TabIndex = 1;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 532);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.HRButton);
            this.Name = "FormView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HRButton;
        private System.Windows.Forms.Button EmployeeButton;
    }
}

