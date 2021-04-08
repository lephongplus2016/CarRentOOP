namespace RentCar
{
    partial class fVehicleService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVehicleService));
            this.dtgVehicle = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEngine = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnTires = new System.Windows.Forms.Button();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehicle)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVehicle
            // 
            this.dtgVehicle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehicle.Location = new System.Drawing.Point(13, 104);
            this.dtgVehicle.Name = "dtgVehicle";
            this.dtgVehicle.RowHeadersWidth = 51;
            this.dtgVehicle.RowTemplate.Height = 24;
            this.dtgVehicle.Size = new System.Drawing.Size(841, 464);
            this.dtgVehicle.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEngine);
            this.flowLayoutPanel1.Controls.Add(this.btnTrans);
            this.flowLayoutPanel1.Controls.Add(this.btnTires);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(183, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(503, 85);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnEngine
            // 
            this.btnEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEngine.Location = new System.Drawing.Point(3, 3);
            this.btnEngine.Name = "btnEngine";
            this.btnEngine.Size = new System.Drawing.Size(153, 82);
            this.btnEngine.TabIndex = 0;
            this.btnEngine.Text = "Service Engine";
            this.btnEngine.UseVisualStyleBackColor = true;
            this.btnEngine.Click += new System.EventHandler(this.btnEngine_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.Location = new System.Drawing.Point(162, 3);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(184, 82);
            this.btnTrans.TabIndex = 1;
            this.btnTrans.Text = "Service Transmission";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnTires
            // 
            this.btnTires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTires.Location = new System.Drawing.Point(352, 3);
            this.btnTires.Name = "btnTires";
            this.btnTires.Size = new System.Drawing.Size(142, 82);
            this.btnTires.TabIndex = 2;
            this.btnTires.Text = "Service Tires";
            this.btnTires.UseVisualStyleBackColor = true;
            this.btnTires.Click += new System.EventHandler(this.btnTires_Click);
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(263, 509);
            this.prgBar.Maximum = 1000;
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(329, 23);
            this.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(394, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Process:";
            // 
            // fVehicleService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtgVehicle);
            this.Name = "fVehicleService";
            this.Text = "Vehicle Service";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehicle)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVehicle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEngine;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnTires;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}