namespace WindowsFormsApp1
{
    partial class UserControl9
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labQt9 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labQt9
            // 
            this.labQt9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labQt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQt9.Location = new System.Drawing.Point(0, 0);
            this.labQt9.Name = "labQt9";
            this.labQt9.Size = new System.Drawing.Size(838, 397);
            this.labQt9.TabIndex = 0;
            this.labQt9.Text = "question";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(196, 101);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(531, 21);
            this.comboBox9.TabIndex = 1;
            this.comboBox9.SelectionChangeCommitted += new System.EventHandler(this.comboBox9_SelectionChangeCommitted);
            // 
            // UserControl9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.labQt9);
            this.Name = "UserControl9";
            this.Size = new System.Drawing.Size(838, 397);
            this.Load += new System.EventHandler(this.UserControl9_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labQt9;
        private System.Windows.Forms.ComboBox comboBox9;
    }
}
