namespace RentCar
{
    partial class fService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fService));
            this.btnVinfast = new System.Windows.Forms.Button();
            this.btnFord = new System.Windows.Forms.Button();
            this.btnCarmudi = new System.Windows.Forms.Button();
            this.btnFleet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVinfast
            // 
            this.btnVinfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVinfast.Location = new System.Drawing.Point(81, 124);
            this.btnVinfast.Name = "btnVinfast";
            this.btnVinfast.Size = new System.Drawing.Size(142, 111);
            this.btnVinfast.TabIndex = 0;
            this.btnVinfast.Text = "Vinfast Service";
            this.btnVinfast.UseVisualStyleBackColor = true;
            this.btnVinfast.Click += new System.EventHandler(this.btnVinfast_Click);
            // 
            // btnFord
            // 
            this.btnFord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFord.Location = new System.Drawing.Point(397, 124);
            this.btnFord.Name = "btnFord";
            this.btnFord.Size = new System.Drawing.Size(142, 111);
            this.btnFord.TabIndex = 1;
            this.btnFord.Text = "Ford Service";
            this.btnFord.UseVisualStyleBackColor = true;
            this.btnFord.Click += new System.EventHandler(this.btnFord_Click);
            // 
            // btnCarmudi
            // 
            this.btnCarmudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarmudi.Location = new System.Drawing.Point(700, 124);
            this.btnCarmudi.Name = "btnCarmudi";
            this.btnCarmudi.Size = new System.Drawing.Size(142, 111);
            this.btnCarmudi.TabIndex = 2;
            this.btnCarmudi.Text = "Carmudi Service";
            this.btnCarmudi.UseVisualStyleBackColor = true;
            this.btnCarmudi.Click += new System.EventHandler(this.btnCarmudi_Click);
            // 
            // btnFleet
            // 
            this.btnFleet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFleet.Location = new System.Drawing.Point(397, 330);
            this.btnFleet.Name = "btnFleet";
            this.btnFleet.Size = new System.Drawing.Size(142, 111);
            this.btnFleet.TabIndex = 3;
            this.btnFleet.Text = "Service Fleet";
            this.btnFleet.UseVisualStyleBackColor = true;
            this.btnFleet.Click += new System.EventHandler(this.btnFleet_Click);
            // 
            // fService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.Controls.Add(this.btnFleet);
            this.Controls.Add(this.btnCarmudi);
            this.Controls.Add(this.btnFord);
            this.Controls.Add(this.btnVinfast);
            this.Name = "fService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Service";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVinfast;
        private System.Windows.Forms.Button btnFord;
        private System.Windows.Forms.Button btnCarmudi;
        private System.Windows.Forms.Button btnFleet;
    }
}