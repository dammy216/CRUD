namespace FareSystem
{
    partial class FareView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fareGV = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.vehicleView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicPriceView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distancePriceVIew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fareGV)).BeginInit();
            this.SuspendLayout();
            // 
            // fareGV
            // 
            this.fareGV.AllowDrop = true;
            this.fareGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.fareGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fareGV.BackgroundColor = System.Drawing.SystemColors.Info;
            this.fareGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.fareGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fareGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleView,
            this.basicPriceView,
            this.distancePriceVIew,
            this.Column1,
            this.Column2});
            this.fareGV.GridColor = System.Drawing.SystemColors.Desktop;
            this.fareGV.Location = new System.Drawing.Point(130, 116);
            this.fareGV.MultiSelect = false;
            this.fareGV.Name = "fareGV";
            this.fareGV.ReadOnly = true;
            this.fareGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.fareGV.RowTemplate.Height = 21;
            this.fareGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fareGV.Size = new System.Drawing.Size(543, 208);
            this.fareGV.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(224, 364);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "追加へ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(358, 364);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "編集";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(517, 364);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // vehicleView
            // 
            this.vehicleView.HeaderText = "乗り物";
            this.vehicleView.Name = "vehicleView";
            this.vehicleView.ReadOnly = true;
            // 
            // basicPriceView
            // 
            this.basicPriceView.HeaderText = "基本料金";
            this.basicPriceView.Name = "basicPriceView";
            this.basicPriceView.ReadOnly = true;
            // 
            // distancePriceVIew
            // 
            this.distancePriceVIew.HeaderText = "距離料金";
            this.distancePriceVIew.Name = "distancePriceVIew";
            this.distancePriceVIew.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "距離";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "合計金額";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FareView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.fareGV);
            this.Name = "FareView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fareGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fareGV;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleView;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicPriceView;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancePriceVIew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

