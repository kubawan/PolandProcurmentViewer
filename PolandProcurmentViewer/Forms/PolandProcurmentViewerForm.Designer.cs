
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
            this.GetDataBtn = new System.Windows.Forms.Button();
            this.lblTenderTitle = new System.Windows.Forms.Label();
            this.lblTenderId = new System.Windows.Forms.Label();
            this.lblTenderTitleData = new System.Windows.Forms.Label();
            this.lblTenderIdData = new System.Windows.Forms.Label();
            this.TendersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GetDataBtn
            // 
            this.GetDataBtn.Location = new System.Drawing.Point(11, 10);
            this.GetDataBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetDataBtn.Name = "GetDataBtn";
            this.GetDataBtn.Size = new System.Drawing.Size(105, 22);
            this.GetDataBtn.TabIndex = 1;
            this.GetDataBtn.Text = "Get Data";
            this.GetDataBtn.UseVisualStyleBackColor = true;
            this.GetDataBtn.Click += new System.EventHandler(this.GetDataBtn_Click);
            // 
            // lblTenderTitle
            // 
            this.lblTenderTitle.AutoSize = true;
            this.lblTenderTitle.Location = new System.Drawing.Point(262, 37);
            this.lblTenderTitle.Name = "lblTenderTitle";
            this.lblTenderTitle.Size = new System.Drawing.Size(68, 15);
            this.lblTenderTitle.TabIndex = 2;
            this.lblTenderTitle.Text = "Tender title:";
            // 
            // lblTenderId
            // 
            this.lblTenderId.AutoSize = true;
            this.lblTenderId.Location = new System.Drawing.Point(310, 62);
            this.lblTenderId.Name = "lblTenderId";
            this.lblTenderId.Size = new System.Drawing.Size(20, 15);
            this.lblTenderId.TabIndex = 3;
            this.lblTenderId.Text = "Id:";
            // 
            // lblTenderTitleData
            // 
            this.lblTenderTitleData.AutoSize = true;
            this.lblTenderTitleData.Location = new System.Drawing.Point(336, 37);
            this.lblTenderTitleData.Name = "lblTenderTitleData";
            this.lblTenderTitleData.Size = new System.Drawing.Size(0, 15);
            this.lblTenderTitleData.TabIndex = 4;
            // 
            // lblTenderIdData
            // 
            this.lblTenderIdData.AutoSize = true;
            this.lblTenderIdData.Location = new System.Drawing.Point(336, 62);
            this.lblTenderIdData.Name = "lblTenderIdData";
            this.lblTenderIdData.Size = new System.Drawing.Size(0, 15);
            this.lblTenderIdData.TabIndex = 5;
            // 
            // listBox1
            // 
            this.TendersListBox.FormattingEnabled = true;
            this.TendersListBox.ItemHeight = 15;
            this.TendersListBox.Location = new System.Drawing.Point(12, 37);
            this.TendersListBox.Name = "TendersListBox";
            this.TendersListBox.Size = new System.Drawing.Size(244, 289);
            this.TendersListBox.TabIndex = 6;
            this.TendersListBox.SelectedIndexChanged += TendersListBox_SelectedIndexChanged;
            // 
            // PPViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 338);
            this.Controls.Add(this.TendersListBox);
            this.Controls.Add(this.lblTenderIdData);
            this.Controls.Add(this.lblTenderTitleData);
            this.Controls.Add(this.lblTenderId);
            this.Controls.Add(this.lblTenderTitle);
            this.Controls.Add(this.GetDataBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PPViewerForm";
            this.Text = "Procurement Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button GetDataBtn;
        private System.Windows.Forms.Label lblTenderTitle;
        private System.Windows.Forms.Label lblTenderId;
        private System.Windows.Forms.Label lblTenderTitleData;
        private System.Windows.Forms.Label lblTenderIdData;
        private System.Windows.Forms.ListBox TendersListBox;
    }
}

