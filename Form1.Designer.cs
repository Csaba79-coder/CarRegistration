
namespace CarRegistration
{
    partial class Form1
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
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.textBoxYearOfProd = new System.Windows.Forms.TextBox();
            this.textBoxMotTestExpDate = new System.Windows.Forms.TextBox();
            this.textBoxNumberPlate = new System.Windows.Forms.TextBox();
            this.checkBoxDiesel = new System.Windows.Forms.CheckBox();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.buttonAddNewCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(433, 70);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 23);
            this.textBoxType.TabIndex = 0;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(433, 203);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(100, 23);
            this.textBoxOwner.TabIndex = 2;
            // 
            // textBoxYearOfProd
            // 
            this.textBoxYearOfProd.Location = new System.Drawing.Point(433, 268);
            this.textBoxYearOfProd.Name = "textBoxYearOfProd";
            this.textBoxYearOfProd.Size = new System.Drawing.Size(100, 23);
            this.textBoxYearOfProd.TabIndex = 3;
            // 
            // textBoxMotTestExpDate
            // 
            this.textBoxMotTestExpDate.Location = new System.Drawing.Point(433, 328);
            this.textBoxMotTestExpDate.Name = "textBoxMotTestExpDate";
            this.textBoxMotTestExpDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxMotTestExpDate.TabIndex = 4;
            // 
            // textBoxNumberPlate
            // 
            this.textBoxNumberPlate.Location = new System.Drawing.Point(433, 133);
            this.textBoxNumberPlate.Name = "textBoxNumberPlate";
            this.textBoxNumberPlate.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumberPlate.TabIndex = 5;
            // 
            // checkBoxDiesel
            // 
            this.checkBoxDiesel.AutoSize = true;
            this.checkBoxDiesel.Location = new System.Drawing.Point(433, 389);
            this.checkBoxDiesel.Name = "checkBoxDiesel";
            this.checkBoxDiesel.Size = new System.Drawing.Size(57, 19);
            this.checkBoxDiesel.TabIndex = 6;
            this.checkBoxDiesel.Text = "Diesel";
            this.checkBoxDiesel.UseVisualStyleBackColor = true;
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 15;
            this.listBoxCars.Location = new System.Drawing.Point(80, 62);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(226, 289);
            this.listBoxCars.TabIndex = 7;
            this.listBoxCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
            // 
            // buttonAddNewCar
            // 
            this.buttonAddNewCar.Location = new System.Drawing.Point(80, 385);
            this.buttonAddNewCar.Name = "buttonAddNewCar";
            this.buttonAddNewCar.Size = new System.Drawing.Size(125, 23);
            this.buttonAddNewCar.TabIndex = 8;
            this.buttonAddNewCar.Text = "Add New Car";
            this.buttonAddNewCar.UseVisualStyleBackColor = true;
            this.buttonAddNewCar.Click += new System.EventHandler(this.buttonAddNewCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number Plate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Owner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Year of Production";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "MOT Test Exp. Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cars list";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddNewCar);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.checkBoxDiesel);
            this.Controls.Add(this.textBoxNumberPlate);
            this.Controls.Add(this.textBoxMotTestExpDate);
            this.Controls.Add(this.textBoxYearOfProd);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.textBoxType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.TextBox textBoxYearOfProd;
        private System.Windows.Forms.TextBox textBoxMotTestExpDate;
        private System.Windows.Forms.TextBox textBoxNumberPlate;
        private System.Windows.Forms.CheckBox checkBoxDiesel;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Button buttonAddNewCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

