
namespace frmShowGrade
{
    partial class ReportViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gradeInEachCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExaminationSystemDataSet = new frmShowGrade.ExaminationSystemDataSet();
            this.examinationSystemDataSet1 = new frmShowGrade.ExaminationSystemDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gradeInEachCourseTableAdapter = new frmShowGrade.ExaminationSystemDataSetTableAdapters.gradeInEachCourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gradeInEachCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeInEachCourseBindingSource
            // 
            this.gradeInEachCourseBindingSource.DataMember = "gradeInEachCourse";
            this.gradeInEachCourseBindingSource.DataSource = this.ExaminationSystemDataSet;
            // 
            // ExaminationSystemDataSet
            // 
            this.ExaminationSystemDataSet.DataSetName = "ExaminationSystemDataSet";
            this.ExaminationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examinationSystemDataSet1
            // 
            this.examinationSystemDataSet1.DataSetName = "ExaminationSystemDataSet";
            this.examinationSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.gradeInEachCourseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmShowGrade.stdExamsGrade.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // gradeInEachCourseTableAdapter
            // 
            this.gradeInEachCourseTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            //this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeInEachCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExaminationSystemDataSet examinationSystemDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gradeInEachCourseBindingSource;
        private ExaminationSystemDataSet ExaminationSystemDataSet;
        private ExaminationSystemDataSetTableAdapters.gradeInEachCourseTableAdapter gradeInEachCourseTableAdapter;
    }
}