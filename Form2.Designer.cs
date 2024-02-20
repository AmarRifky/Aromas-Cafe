namespace Aroma_Cafe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CoffeeComboBox = new MediReport.CustomComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantityCoffeeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.confirm_btn = new FirstPage.ARCustome();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(346, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "AROMAS CAFE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(144, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Your Product";
            // 
            // CoffeeComboBox
            // 
            this.CoffeeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CoffeeComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CoffeeComboBox.BorderSize = 1;
            this.CoffeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CoffeeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoffeeComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.CoffeeComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CoffeeComboBox.Items.AddRange(new object[] {
            "Espresso",
            "Americano",
            "Latte",
            "Cappuccino",
            "Breakfast Sandwiches",
            "Paninis",
            "Cake Slices ",
            "Cookies",
            "Brownies"});
            this.CoffeeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CoffeeComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.CoffeeComboBox.Location = new System.Drawing.Point(400, 170);
            this.CoffeeComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.CoffeeComboBox.Name = "CoffeeComboBox";
            this.CoffeeComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.CoffeeComboBox.Size = new System.Drawing.Size(293, 30);
            this.CoffeeComboBox.TabIndex = 2;
            this.CoffeeComboBox.Texts = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(144, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please Enter Number Of Items You Need";
            // 
            // QuantityCoffeeTextBox
            // 
            this.QuantityCoffeeTextBox.Location = new System.Drawing.Point(570, 227);
            this.QuantityCoffeeTextBox.Name = "QuantityCoffeeTextBox";
            this.QuantityCoffeeTextBox.Size = new System.Drawing.Size(125, 23);
            this.QuantityCoffeeTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(260, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Amount of your order";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(569, 358);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(157, 23);
            this.TotalTextBox.TabIndex = 6;
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.confirm_btn.FlatAppearance.BorderSize = 0;
            this.confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_btn.ForeColor = System.Drawing.Color.White;
            this.confirm_btn.Location = new System.Drawing.Point(343, 271);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(154, 45);
            this.confirm_btn.TabIndex = 7;
            this.confirm_btn.Text = "Confirm Order";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(377, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Make Your";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(499, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payment";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 616);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityCoffeeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoffeeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private MediReport.CustomComboBox CoffeeComboBox;
        private Label label3;
        private TextBox QuantityCoffeeTextBox;
        private Label label4;
        private TextBox TotalTextBox;
        private FirstPage.ARCustome confirm_btn;
        private Label label5;
        private Label label6;
    }
}