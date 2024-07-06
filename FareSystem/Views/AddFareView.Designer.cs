namespace FareSystem.Views
{
    partial class AddFareView
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
            this.basicPriceTB = new System.Windows.Forms.TextBox();
            this.distancePriceTB = new System.Windows.Forms.TextBox();
            this.vehicleCB = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basicPriceTB
            // 
            this.basicPriceTB.Location = new System.Drawing.Point(319, 235);
            this.basicPriceTB.Name = "basicPriceTB";
            this.basicPriceTB.Size = new System.Drawing.Size(100, 19);
            this.basicPriceTB.TabIndex = 0;
            // 
            // distancePriceTB
            // 
            this.distancePriceTB.Location = new System.Drawing.Point(319, 299);
            this.distancePriceTB.Name = "distancePriceTB";
            this.distancePriceTB.Size = new System.Drawing.Size(100, 19);
            this.distancePriceTB.TabIndex = 1;
            // 
            // vehicleCB
            // 
            this.vehicleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleCB.FormattingEnabled = true;
            this.vehicleCB.Items.AddRange(new object[] {
            "バス",
            "電車",
            "飛行機"});
            this.vehicleCB.Location = new System.Drawing.Point(319, 157);
            this.vehicleCB.Name = "vehicleCB";
            this.vehicleCB.Size = new System.Drawing.Size(121, 20);
            this.vehicleCB.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(523, 364);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "完了";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(655, 363);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddFareView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.vehicleCB);
            this.Controls.Add(this.distancePriceTB);
            this.Controls.Add(this.basicPriceTB);
            this.Name = "AddFareView";
            this.Text = "AddFareView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox basicPriceTB;
        private System.Windows.Forms.TextBox distancePriceTB;
        private System.Windows.Forms.ComboBox vehicleCB;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button closeButton;
    }
}