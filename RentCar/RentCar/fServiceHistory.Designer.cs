namespace RentCar
{
    partial class fServiceHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fServiceHistory));
            this.txbNum = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgHistory = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txbDistance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFirst = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSecond = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCompare = new System.Windows.Forms.TextBox();
            this.button_Json = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNum
            // 
            this.txbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNum.Location = new System.Drawing.Point(465, 10);
            this.txbNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNum.Name = "txbNum";
            this.txbNum.ReadOnly = true;
            this.txbNum.Size = new System.Drawing.Size(152, 23);
            this.txbNum.TabIndex = 0;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(465, 45);
            this.txbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(152, 23);
            this.txbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car Name:";
            // 
            // dtgHistory
            // 
            this.dtgHistory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistory.Location = new System.Drawing.Point(9, 65);
            this.dtgHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgHistory.Name = "dtgHistory";
            this.dtgHistory.RowHeadersWidth = 51;
            this.dtgHistory.RowTemplate.Height = 24;
            this.dtgHistory.Size = new System.Drawing.Size(370, 370);
            this.dtgHistory.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(384, 177);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 258);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(465, 449);
            this.btnSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(151, 48);
            this.btnSub.TabIndex = 10;
            this.btnSub.Text = "Show different distance";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(465, 543);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(151, 48);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "Show comparison";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txbDistance
            // 
            this.txbDistance.BackColor = System.Drawing.SystemColors.Control;
            this.txbDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDistance.ForeColor = System.Drawing.Color.Red;
            this.txbDistance.Location = new System.Drawing.Point(9, 573);
            this.txbDistance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbDistance.Name = "txbDistance";
            this.txbDistance.ReadOnly = true;
            this.txbDistance.Size = new System.Drawing.Size(141, 23);
            this.txbDistance.TabIndex = 12;
            this.txbDistance.Text = "0 km";
            this.txbDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chartreuse;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 543);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Different distance:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.cbFirst);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 449);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 51);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "First mainternance job:";
            // 
            // cbFirst
            // 
            this.cbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFirst.FormattingEnabled = true;
            this.cbFirst.Location = new System.Drawing.Point(2, 20);
            this.cbFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFirst.Name = "cbFirst";
            this.cbFirst.Size = new System.Drawing.Size(134, 25);
            this.cbFirst.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.cbSecond);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(229, 449);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(185, 51);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Second mainternance job:";
            // 
            // cbSecond
            // 
            this.cbSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSecond.FormattingEnabled = true;
            this.cbSecond.Location = new System.Drawing.Point(2, 20);
            this.cbSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSecond.Name = "cbSecond";
            this.cbSecond.Size = new System.Drawing.Size(134, 25);
            this.cbSecond.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Chartreuse;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(228, 543);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Comparison result:";
            // 
            // txbCompare
            // 
            this.txbCompare.BackColor = System.Drawing.SystemColors.Control;
            this.txbCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCompare.ForeColor = System.Drawing.Color.Red;
            this.txbCompare.Location = new System.Drawing.Point(231, 573);
            this.txbCompare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCompare.Name = "txbCompare";
            this.txbCompare.ReadOnly = true;
            this.txbCompare.Size = new System.Drawing.Size(141, 23);
            this.txbCompare.TabIndex = 16;
            this.txbCompare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Json
            // 
            this.button_Json.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Json.Location = new System.Drawing.Point(420, 95);
            this.button_Json.Margin = new System.Windows.Forms.Padding(2);
            this.button_Json.Name = "button_Json";
            this.button_Json.Size = new System.Drawing.Size(151, 48);
            this.button_Json.TabIndex = 18;
            this.button_Json.Text = "Export Json Document";
            this.button_Json.UseVisualStyleBackColor = true;
            this.button_Json.Click += new System.EventHandler(this.button_Json_Click);
            // 
            // fServiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 600);
            this.Controls.Add(this.button_Json);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbCompare);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.txbDistance);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbNum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fServiceHistory";
            this.Text = "Service History";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txbDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFirst;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSecond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCompare;
        private System.Windows.Forms.Button button_Json;
    }
}