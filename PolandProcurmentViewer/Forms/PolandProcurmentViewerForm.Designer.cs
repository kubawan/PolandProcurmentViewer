
namespace PP.Viewer
{
    partial class PPViewerForm
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
            this.TenderGridViewer = new System.Windows.Forms.DataGridView();
            this.GetDataBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TenderGridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // TenderGridViewer
            // 
            this.TenderGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TenderGridViewer.Location = new System.Drawing.Point(12, 48);
            this.TenderGridViewer.Name = "TenderGridViewer";
            this.TenderGridViewer.RowHeadersWidth = 51;
            this.TenderGridViewer.RowTemplate.Height = 29;
            this.TenderGridViewer.Size = new System.Drawing.Size(776, 390);
            this.TenderGridViewer.TabIndex = 0;
            // 
            // GetDataBtn
            // 
            this.GetDataBtn.Location = new System.Drawing.Point(13, 13);
            this.GetDataBtn.Name = "GetDataBtn";
            this.GetDataBtn.Size = new System.Drawing.Size(120, 29);
            this.GetDataBtn.TabIndex = 1;
            this.GetDataBtn.Text = "Get Data";
            this.GetDataBtn.UseVisualStyleBackColor = true;
            this.GetDataBtn.Click += new System.EventHandler(this.GetDataBtn_Click);
            // 
            // PPViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetDataBtn);
            this.Controls.Add(this.TenderGridViewer);
            this.Name = "PPViewerForm";
            this.Text = "Procurement Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.TenderGridViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TenderGridViewer;
        private System.Windows.Forms.Button GetDataBtn;
    }
}

