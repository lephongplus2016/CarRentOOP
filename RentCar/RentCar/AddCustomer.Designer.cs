namespace RentCar
{
    partial class AddCustomer
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
            this.txb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_age = new System.Windows.Forms.TextBox();
            this.txb_card = new System.Windows.Forms.TextBox();
            this.txb_license = new System.Windows.Forms.TextBox();
            this.txb_deposit = new System.Windows.Forms.TextBox();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.rbCon1 = new System.Windows.Forms.RadioButton();
            this.rbCon2 = new System.Windows.Forms.RadioButton();
            this.rbCon3 = new System.Windows.Forms.RadioButton();
            this.rbCon4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txb_id
            // 
            this.txb_id.Enabled = false;
            this.txb_id.Location = new System.Drawing.Point(800, 71);
            this.txb_id.Margin = new System.Windows.Forms.Padding(4);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(233, 22);
            this.txb_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(653, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(620, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Customer Credit Card:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer Car License:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(624, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Customer Deposit:";
            // 
            // txb_name
            // 
            this.txb_name.Enabled = false;
            this.txb_name.Location = new System.Drawing.Point(800, 123);
            this.txb_name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(233, 22);
            this.txb_name.TabIndex = 1;
            // 
            // txb_age
            // 
            this.txb_age.Enabled = false;
            this.txb_age.Location = new System.Drawing.Point(800, 172);
            this.txb_age.Margin = new System.Windows.Forms.Padding(4);
            this.txb_age.Name = "txb_age";
            this.txb_age.Size = new System.Drawing.Size(233, 22);
            this.txb_age.TabIndex = 2;
            // 
            // txb_card
            // 
            this.txb_card.Enabled = false;
            this.txb_card.Location = new System.Drawing.Point(800, 265);
            this.txb_card.Margin = new System.Windows.Forms.Padding(4);
            this.txb_card.Name = "txb_card";
            this.txb_card.Size = new System.Drawing.Size(233, 22);
            this.txb_card.TabIndex = 4;
            // 
            // txb_license
            // 
            this.txb_license.Enabled = false;
            this.txb_license.Location = new System.Drawing.Point(800, 304);
            this.txb_license.Margin = new System.Windows.Forms.Padding(4);
            this.txb_license.Name = "txb_license";
            this.txb_license.Size = new System.Drawing.Size(233, 22);
            this.txb_license.TabIndex = 5;
            // 
            // txb_deposit
            // 
            this.txb_deposit.Enabled = false;
            this.txb_deposit.Location = new System.Drawing.Point(800, 346);
            this.txb_deposit.Margin = new System.Windows.Forms.Padding(4);
            this.txb_deposit.Name = "txb_deposit";
            this.txb_deposit.Size = new System.Drawing.Size(233, 22);
            this.txb_deposit.TabIndex = 6;
            // 
            // txb_address
            // 
            this.txb_address.Enabled = false;
            this.txb_address.Location = new System.Drawing.Point(800, 218);
            this.txb_address.Margin = new System.Windows.Forms.Padding(4);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(233, 22);
            this.txb_address.TabIndex = 3;
            // 
            // btnAddCus
            // 
            this.btnAddCus.Location = new System.Drawing.Point(13, 336);
            this.btnAddCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(200, 102);
            this.btnAddCus.TabIndex = 14;
            this.btnAddCus.Text = "ADD NEW CUSTOMER";
            this.btnAddCus.UseVisualStyleBackColor = true;
            this.btnAddCus.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbCon1
            // 
            this.rbCon1.AutoSize = true;
            this.rbCon1.Location = new System.Drawing.Point(28, 60);
            this.rbCon1.Name = "rbCon1";
            this.rbCon1.Size = new System.Drawing.Size(218, 21);
            this.rbCon1.TabIndex = 15;
            this.rbCon1.TabStop = true;
            this.rbCon1.Text = "Constructor 1: iD, name, age1";
            this.rbCon1.UseVisualStyleBackColor = true;
            this.rbCon1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbCon2
            // 
            this.rbCon2.AutoSize = true;
            this.rbCon2.Location = new System.Drawing.Point(28, 127);
            this.rbCon2.Name = "rbCon2";
            this.rbCon2.Size = new System.Drawing.Size(281, 21);
            this.rbCon2.TabIndex = 16;
            this.rbCon2.TabStop = true;
            this.rbCon2.Text = "Constructor 2:  iD, name,  age,  address\r\n";
            this.rbCon2.UseVisualStyleBackColor = true;
            this.rbCon2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbCon3
            // 
            this.rbCon3.AutoSize = true;
            this.rbCon3.Location = new System.Drawing.Point(28, 198);
            this.rbCon3.Name = "rbCon3";
            this.rbCon3.Size = new System.Drawing.Size(471, 21);
            this.rbCon3.TabIndex = 17;
            this.rbCon3.TabStop = true;
            this.rbCon3.Text = "Constructor 3: iD, name, age, address, creditcard, carLicense, deposit";
            this.rbCon3.UseVisualStyleBackColor = true;
            this.rbCon3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbCon4
            // 
            this.rbCon4.AutoSize = true;
            this.rbCon4.Location = new System.Drawing.Point(28, 268);
            this.rbCon4.Name = "rbCon4";
            this.rbCon4.Size = new System.Drawing.Size(256, 21);
            this.rbCon4.TabIndex = 18;
            this.rbCon4.TabStop = true;
            this.rbCon4.Text = "Constructor : iD, name, age, deposit";
            this.rbCon4.UseVisualStyleBackColor = true;
            this.rbCon4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // AddCustomer
            // 
            this.AcceptButton = this.btnAddCus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 451);
            this.Controls.Add(this.rbCon4);
            this.Controls.Add(this.rbCon3);
            this.Controls.Add(this.rbCon2);
            this.Controls.Add(this.rbCon1);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.txb_deposit);
            this.Controls.Add(this.txb_license);
            this.Controls.Add(this.txb_card);
            this.Controls.Add(this.txb_age);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_id);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_age;
        private System.Windows.Forms.TextBox txb_card;
        private System.Windows.Forms.TextBox txb_license;
        private System.Windows.Forms.TextBox txb_deposit;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.RadioButton rbCon1;
        private System.Windows.Forms.RadioButton rbCon2;
        private System.Windows.Forms.RadioButton rbCon3;
        private System.Windows.Forms.RadioButton rbCon4;
    }
}