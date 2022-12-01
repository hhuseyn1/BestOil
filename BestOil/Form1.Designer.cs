namespace BestOil
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
            this.Last = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AllAmount = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.MiniCafe = new System.Windows.Forms.GroupBox();
            this.panelFood = new System.Windows.Forms.Panel();
            this.Cola = new System.Windows.Forms.CheckBox();
            this.Fries = new System.Windows.Forms.CheckBox();
            this.Hamburger = new System.Windows.Forms.CheckBox();
            this.HotDog = new System.Windows.Forms.CheckBox();
            this.PanelTextBoxes = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.AmountCafe = new System.Windows.Forms.GroupBox();
            this.TotalAmountCafe = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.PriceCafe = new System.Windows.Forms.Label();
            this.PetrolStation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalAmountPetrol = new System.Windows.Forms.Label();
            this.dollar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonLitr = new System.Windows.Forms.RadioButton();
            this.radioButtonMoney = new System.Windows.Forms.RadioButton();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.Petrolcmbbox = new System.Windows.Forms.ComboBox();
            this.LitrtextBox = new System.Windows.Forms.TextBox();
            this.lbl_Petrol = new System.Windows.Forms.Label();
            this.PricePetrol = new System.Windows.Forms.Label();
            this.PricePetroltxtbox = new System.Windows.Forms.TextBox();
            this.Last.SuspendLayout();
            this.MiniCafe.SuspendLayout();
            this.panelFood.SuspendLayout();
            this.PanelTextBoxes.SuspendLayout();
            this.AmountCafe.SuspendLayout();
            this.PetrolStation.SuspendLayout();
            this.AmountGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Last
            // 
            this.Last.Controls.Add(this.label4);
            this.Last.Controls.Add(this.AllAmount);
            this.Last.Controls.Add(this.Calculate);
            this.Last.Location = new System.Drawing.Point(25, 326);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(750, 138);
            this.Last.TabIndex = 14;
            this.Last.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(644, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "$";
            // 
            // AllAmount
            // 
            this.AllAmount.AutoSize = true;
            this.AllAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllAmount.Location = new System.Drawing.Point(579, 80);
            this.AllAmount.Name = "AllAmount";
            this.AllAmount.Size = new System.Drawing.Size(59, 32);
            this.AllAmount.TabIndex = 1;
            this.AllAmount.Text = "0.00";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(166, 43);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(149, 69);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // MiniCafe
            // 
            this.MiniCafe.Controls.Add(this.panelFood);
            this.MiniCafe.Controls.Add(this.PanelTextBoxes);
            this.MiniCafe.Controls.Add(this.AmountCafe);
            this.MiniCafe.Controls.Add(this.Count);
            this.MiniCafe.Controls.Add(this.PriceCafe);
            this.MiniCafe.Location = new System.Drawing.Point(369, -14);
            this.MiniCafe.Name = "MiniCafe";
            this.MiniCafe.Size = new System.Drawing.Size(406, 331);
            this.MiniCafe.TabIndex = 13;
            this.MiniCafe.TabStop = false;
            this.MiniCafe.Text = "Mini-Kafe";
            // 
            // panelFood
            // 
            this.panelFood.Controls.Add(this.Cola);
            this.panelFood.Controls.Add(this.Fries);
            this.panelFood.Controls.Add(this.Hamburger);
            this.panelFood.Controls.Add(this.HotDog);
            this.panelFood.Location = new System.Drawing.Point(57, 26);
            this.panelFood.Name = "panelFood";
            this.panelFood.Size = new System.Drawing.Size(126, 137);
            this.panelFood.TabIndex = 11;
            // 
            // Cola
            // 
            this.Cola.AutoSize = true;
            this.Cola.Location = new System.Drawing.Point(29, 110);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(82, 19);
            this.Cola.TabIndex = 6;
            this.Cola.Text = "Coca-Cola";
            this.Cola.UseVisualStyleBackColor = true;
            // 
            // Fries
            // 
            this.Fries.AutoSize = true;
            this.Fries.Location = new System.Drawing.Point(29, 77);
            this.Fries.Name = "Fries";
            this.Fries.Size = new System.Drawing.Size(50, 19);
            this.Fries.TabIndex = 6;
            this.Fries.Text = "Fries";
            this.Fries.UseVisualStyleBackColor = true;
            // 
            // Hamburger
            // 
            this.Hamburger.AutoSize = true;
            this.Hamburger.Location = new System.Drawing.Point(29, 46);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(87, 19);
            this.Hamburger.TabIndex = 6;
            this.Hamburger.Text = "Hamburger";
            this.Hamburger.UseVisualStyleBackColor = true;
            // 
            // HotDog
            // 
            this.HotDog.AutoSize = true;
            this.HotDog.Location = new System.Drawing.Point(29, 13);
            this.HotDog.Name = "HotDog";
            this.HotDog.Size = new System.Drawing.Size(73, 19);
            this.HotDog.TabIndex = 6;
            this.HotDog.Text = "Hot-Dog";
            this.HotDog.UseVisualStyleBackColor = true;
            // 
            // PanelTextBoxes
            // 
            this.PanelTextBoxes.Controls.Add(this.textBox5);
            this.PanelTextBoxes.Controls.Add(this.textBox6);
            this.PanelTextBoxes.Controls.Add(this.textBox1);
            this.PanelTextBoxes.Controls.Add(this.textBox8);
            this.PanelTextBoxes.Controls.Add(this.textBox2);
            this.PanelTextBoxes.Controls.Add(this.textBox7);
            this.PanelTextBoxes.Controls.Add(this.textBox3);
            this.PanelTextBoxes.Controls.Add(this.textBox4);
            this.PanelTextBoxes.Location = new System.Drawing.Point(192, 28);
            this.PanelTextBoxes.Name = "PanelTextBoxes";
            this.PanelTextBoxes.Size = new System.Drawing.Size(163, 138);
            this.PanelTextBoxes.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(82, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(58, 23);
            this.textBox5.TabIndex = 7;
            this.textBox5.Tag = "HotDog";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(83, 42);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(58, 23);
            this.textBox6.TabIndex = 7;
            this.textBox6.Tag = "Gamburger";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(16, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Tag = "HotDog";
            this.textBox1.Text = "4.00";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(83, 75);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(58, 23);
            this.textBox8.TabIndex = 7;
            this.textBox8.Tag = "Free";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(16, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.Tag = "Gamburger";
            this.textBox2.Text = "5.40";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(83, 112);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(58, 23);
            this.textBox7.TabIndex = 7;
            this.textBox7.Tag = "Cola";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(16, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.Tag = "Free";
            this.textBox3.Text = "7.20";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(16, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.Tag = "Cola";
            this.textBox4.Text = "4.40";
            // 
            // AmountCafe
            // 
            this.AmountCafe.Controls.Add(this.TotalAmountCafe);
            this.AmountCafe.Controls.Add(this.label7);
            this.AmountCafe.Location = new System.Drawing.Point(108, 208);
            this.AmountCafe.Name = "AmountCafe";
            this.AmountCafe.Size = new System.Drawing.Size(233, 112);
            this.AmountCafe.TabIndex = 9;
            this.AmountCafe.TabStop = false;
            this.AmountCafe.Text = "Amount";
            // 
            // TotalAmountCafe
            // 
            this.TotalAmountCafe.AutoSize = true;
            this.TotalAmountCafe.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmountCafe.Location = new System.Drawing.Point(146, 62);
            this.TotalAmountCafe.Name = "TotalAmountCafe";
            this.TotalAmountCafe.Size = new System.Drawing.Size(59, 32);
            this.TotalAmountCafe.TabIndex = 4;
            this.TotalAmountCafe.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "$";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(275, 0);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(40, 15);
            this.Count.TabIndex = 8;
            this.Count.Text = "Count";
            // 
            // PriceCafe
            // 
            this.PriceCafe.AutoSize = true;
            this.PriceCafe.Location = new System.Drawing.Point(208, 0);
            this.PriceCafe.Name = "PriceCafe";
            this.PriceCafe.Size = new System.Drawing.Size(33, 15);
            this.PriceCafe.TabIndex = 8;
            this.PriceCafe.Text = "Price";
            // 
            // PetrolStation
            // 
            this.PetrolStation.Controls.Add(this.label1);
            this.PetrolStation.Controls.Add(this.label3);
            this.PetrolStation.Controls.Add(this.label2);
            this.PetrolStation.Controls.Add(this.AmountGroupBox);
            this.PetrolStation.Controls.Add(this.panel1);
            this.PetrolStation.Controls.Add(this.MoneyTextBox);
            this.PetrolStation.Controls.Add(this.Petrolcmbbox);
            this.PetrolStation.Controls.Add(this.LitrtextBox);
            this.PetrolStation.Controls.Add(this.lbl_Petrol);
            this.PetrolStation.Controls.Add(this.PricePetrol);
            this.PetrolStation.Controls.Add(this.PricePetroltxtbox);
            this.PetrolStation.Location = new System.Drawing.Point(25, -14);
            this.PetrolStation.Name = "PetrolStation";
            this.PetrolStation.Size = new System.Drawing.Size(295, 334);
            this.PetrolStation.TabIndex = 12;
            this.PetrolStation.TabStop = false;
            this.PetrolStation.Text = "PetrolStation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "litr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "$";
            // 
            // AmountGroupBox
            // 
            this.AmountGroupBox.Controls.Add(this.TotalAmountPetrol);
            this.AmountGroupBox.Controls.Add(this.dollar);
            this.AmountGroupBox.Location = new System.Drawing.Point(20, 216);
            this.AmountGroupBox.Name = "AmountGroupBox";
            this.AmountGroupBox.Size = new System.Drawing.Size(233, 112);
            this.AmountGroupBox.TabIndex = 6;
            this.AmountGroupBox.TabStop = false;
            this.AmountGroupBox.Text = "Amount";
            // 
            // TotalAmountPetrol
            // 
            this.TotalAmountPetrol.AutoSize = true;
            this.TotalAmountPetrol.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmountPetrol.Location = new System.Drawing.Point(146, 62);
            this.TotalAmountPetrol.Name = "TotalAmountPetrol";
            this.TotalAmountPetrol.Size = new System.Drawing.Size(59, 32);
            this.TotalAmountPetrol.TabIndex = 4;
            this.TotalAmountPetrol.Text = "0.00";
            // 
            // dollar
            // 
            this.dollar.AutoSize = true;
            this.dollar.Location = new System.Drawing.Point(211, 76);
            this.dollar.Name = "dollar";
            this.dollar.Size = new System.Drawing.Size(13, 15);
            this.dollar.TabIndex = 4;
            this.dollar.Text = "$";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonLitr);
            this.panel1.Controls.Add(this.radioButtonMoney);
            this.panel1.Location = new System.Drawing.Point(6, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 67);
            this.panel1.TabIndex = 5;
            // 
            // radioButtonLitr
            // 
            this.radioButtonLitr.AutoSize = true;
            this.radioButtonLitr.Location = new System.Drawing.Point(3, 3);
            this.radioButtonLitr.Name = "radioButtonLitr";
            this.radioButtonLitr.Size = new System.Drawing.Size(42, 19);
            this.radioButtonLitr.TabIndex = 2;
            this.radioButtonLitr.TabStop = true;
            this.radioButtonLitr.Tag = "LitrtextBox";
            this.radioButtonLitr.Text = "Litr";
            this.radioButtonLitr.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoney
            // 
            this.radioButtonMoney.AutoSize = true;
            this.radioButtonMoney.Location = new System.Drawing.Point(3, 28);
            this.radioButtonMoney.Name = "radioButtonMoney";
            this.radioButtonMoney.Size = new System.Drawing.Size(62, 19);
            this.radioButtonMoney.TabIndex = 2;
            this.radioButtonMoney.TabStop = true;
            this.radioButtonMoney.Tag = "MoneyTextBox";
            this.radioButtonMoney.Text = "Money";
            this.radioButtonMoney.UseVisualStyleBackColor = true;
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(131, 152);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.ReadOnly = true;
            this.MoneyTextBox.Size = new System.Drawing.Size(75, 23);
            this.MoneyTextBox.TabIndex = 3;
            // 
            // Petrolcmbbox
            // 
            this.Petrolcmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Petrolcmbbox.FormattingEnabled = true;
            this.Petrolcmbbox.Location = new System.Drawing.Point(85, 31);
            this.Petrolcmbbox.Name = "Petrolcmbbox";
            this.Petrolcmbbox.Size = new System.Drawing.Size(121, 23);
            this.Petrolcmbbox.TabIndex = 0;
            // 
            // LitrtextBox
            // 
            this.LitrtextBox.Location = new System.Drawing.Point(131, 123);
            this.LitrtextBox.Name = "LitrtextBox";
            this.LitrtextBox.ReadOnly = true;
            this.LitrtextBox.Size = new System.Drawing.Size(75, 23);
            this.LitrtextBox.TabIndex = 3;
            // 
            // lbl_Petrol
            // 
            this.lbl_Petrol.AutoSize = true;
            this.lbl_Petrol.Location = new System.Drawing.Point(6, 39);
            this.lbl_Petrol.Name = "lbl_Petrol";
            this.lbl_Petrol.Size = new System.Drawing.Size(64, 15);
            this.lbl_Petrol.TabIndex = 4;
            this.lbl_Petrol.Text = "Petrol type";
            // 
            // PricePetrol
            // 
            this.PricePetrol.AutoSize = true;
            this.PricePetrol.Location = new System.Drawing.Point(9, 88);
            this.PricePetrol.Name = "PricePetrol";
            this.PricePetrol.Size = new System.Drawing.Size(33, 15);
            this.PricePetrol.TabIndex = 4;
            this.PricePetrol.Text = "Price";
            // 
            // PricePetroltxtbox
            // 
            this.PricePetroltxtbox.Location = new System.Drawing.Point(85, 80);
            this.PricePetroltxtbox.Name = "PricePetroltxtbox";
            this.PricePetroltxtbox.PlaceholderText = "0.00";
            this.PricePetroltxtbox.Size = new System.Drawing.Size(100, 23);
            this.PricePetroltxtbox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 478);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.MiniCafe);
            this.Controls.Add(this.PetrolStation);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.Last.ResumeLayout(false);
            this.Last.PerformLayout();
            this.MiniCafe.ResumeLayout(false);
            this.MiniCafe.PerformLayout();
            this.panelFood.ResumeLayout(false);
            this.panelFood.PerformLayout();
            this.PanelTextBoxes.ResumeLayout(false);
            this.PanelTextBoxes.PerformLayout();
            this.AmountCafe.ResumeLayout(false);
            this.AmountCafe.PerformLayout();
            this.PetrolStation.ResumeLayout(false);
            this.PetrolStation.PerformLayout();
            this.AmountGroupBox.ResumeLayout(false);
            this.AmountGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public GroupBox Last;
        private Label label4;
        private Label AllAmount;
        private Button Calculate;
        public GroupBox MiniCafe;
        public Panel panelFood;
        private CheckBox Cola;
        private CheckBox Fries;
        private CheckBox Hamburger;
        private CheckBox HotDog;
        private Panel PanelTextBoxes;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox1;
        private TextBox textBox8;
        private TextBox textBox2;
        private TextBox textBox7;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox AmountCafe;
        private Label TotalAmountCafe;
        private Label label7;
        private Label Count;
        private Label PriceCafe;
        public GroupBox PetrolStation;
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupBox AmountGroupBox;
        private Label TotalAmountPetrol;
        private Label dollar;
        private Panel panel1;
        private RadioButton radioButtonLitr;
        private RadioButton radioButtonMoney;
        private TextBox MoneyTextBox;
        private ComboBox Petrolcmbbox;
        private TextBox LitrtextBox;
        private Label lbl_Petrol;
        private Label PricePetrol;
        private TextBox PricePetroltxtbox;
    }
}