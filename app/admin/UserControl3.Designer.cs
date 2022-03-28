namespace WindowsFormsApp1
{
    partial class UserControl3
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
            this.labQt3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labQt3
            // 
            this.labQt3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labQt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQt3.Location = new System.Drawing.Point(0, 0);
            this.labQt3.Name = "labQt3";
            this.labQt3.Size = new System.Drawing.Size(838, 397);
            this.labQt3.TabIndex = 1;
            this.labQt3.Text = "question";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(196, 101);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(531, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.labQt3);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(838, 397);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labQt3;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}
