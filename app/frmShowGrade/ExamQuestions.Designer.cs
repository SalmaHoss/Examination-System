
namespace frmShowGrade
{
    partial class ExamQuestions
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExaminationSystemDataSet = new frmShowGrade.ExaminationSystemDataSet();
            this.examQuesionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examQuesionsTableAdapter = new frmShowGrade.ExaminationSystemDataSetTableAdapters.examQuesionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examQuesionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.examQuesionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmShowGrade.ExamQuestionsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExaminationSystemDataSet
            // 
            this.ExaminationSystemDataSet.DataSetName = "ExaminationSystemDataSet";
            this.ExaminationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examQuesionsBindingSource
            // 
            this.examQuesionsBindingSource.DataMember = "examQuesions";
            this.examQuesionsBindingSource.DataSource = this.ExaminationSystemDataSet;
            // 
            // examQuesionsTableAdapter
            // 
            this.examQuesionsTableAdapter.ClearBeforeFill = true;
            // 
            // ExamQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ExamQuestions";
            this.Text = "ExamQuestions";
            //this.Load += new System.EventHandler(this.ExamQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExaminationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examQuesionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource examQuesionsBindingSource;
        private ExaminationSystemDataSet ExaminationSystemDataSet;
        private ExaminationSystemDataSetTableAdapters.examQuesionsTableAdapter examQuesionsTableAdapter;
    }
}