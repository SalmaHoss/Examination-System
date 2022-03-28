namespace WindowsFormsApp1
{
    partial class UserControl10
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
            this.labQt10 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labQt10
            // 
            this.labQt10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labQt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQt10.Location = new System.Drawing.Point(0, 0);
            this.labQt10.Name = "labQt10";
            this.labQt10.Size = new System.Drawing.Size(838, 397);
            this.labQt10.TabIndex = 0;
            this.labQt10.Text = "question";
            this.labQt10.Click += new System.EventHandler(this.labQt10_Click);
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(196, 101);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(531, 21);
            this.comboBox10.TabIndex = 1;
            this.comboBox10.SelectionChangeCommitted += new System.EventHandler(this.comboBox10_SelectionChangeCommitted);
            // 
            // UserControl10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.labQt10);
            this.Name = "UserControl10";
            this.Size = new System.Drawing.Size(838, 397);
            this.Load += new System.EventHandler(this.UserControl10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labQt10;
        private System.Windows.Forms.ComboBox comboBox10;
    }
}
