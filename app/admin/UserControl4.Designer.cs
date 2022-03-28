namespace WindowsFormsApp1
{
    partial class UserControl4
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
            this.labQt4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labQt4
            // 
            this.labQt4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labQt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQt4.Location = new System.Drawing.Point(0, 0);
            this.labQt4.Name = "labQt4";
            this.labQt4.Size = new System.Drawing.Size(838, 397);
            this.labQt4.TabIndex = 2;
            this.labQt4.Text = "question";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(196, 101);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(531, 21);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox4_SelectionChangeCommitted);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.labQt4);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(838, 397);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labQt4;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}
