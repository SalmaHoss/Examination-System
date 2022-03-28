namespace WindowsFormsApp1
{
    partial class UserControl8
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
            this.labQt8 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labQt8
            // 
            this.labQt8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labQt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQt8.Location = new System.Drawing.Point(0, 0);
            this.labQt8.Name = "labQt8";
            this.labQt8.Size = new System.Drawing.Size(838, 397);
            this.labQt8.TabIndex = 0;
            this.labQt8.Text = "question";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(196, 101);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(531, 21);
            this.comboBox8.TabIndex = 1;
            this.comboBox8.SelectionChangeCommitted += new System.EventHandler(this.comboBox8_SelectionChangeCommitted);
            // 
            // UserControl8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.labQt8);
            this.Name = "UserControl8";
            this.Size = new System.Drawing.Size(838, 397);
            this.Load += new System.EventHandler(this.UserControl8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labQt8;
        private System.Windows.Forms.ComboBox comboBox8;
    }
}
