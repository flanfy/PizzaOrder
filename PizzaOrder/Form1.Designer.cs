namespace PizzaOrder
{
    partial class FormPizzaOrder
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
            this.grbSauce = new System.Windows.Forms.GroupBox();
            this.rdbSauce3 = new System.Windows.Forms.RadioButton();
            this.rdbSauce2 = new System.Windows.Forms.RadioButton();
            this.rdbSauce1 = new System.Windows.Forms.RadioButton();
            this.rdbSauce0 = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chk9 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk11 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.grbCheese = new System.Windows.Forms.GroupBox();
            this.rdbCheese3 = new System.Windows.Forms.RadioButton();
            this.rdbCheese2 = new System.Windows.Forms.RadioButton();
            this.rdbCheese1 = new System.Windows.Forms.RadioButton();
            this.rdbCheese0 = new System.Windows.Forms.RadioButton();
            this.lblSpecialInstruction = new System.Windows.Forms.Label();
            this.lblPizzaNum = new System.Windows.Forms.Label();
            this.txtPizzaNum = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.pnlPizzas = new System.Windows.Forms.Panel();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.pnlPizzaNum = new System.Windows.Forms.Panel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.grbSauce.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbCheese.SuspendLayout();
            this.pnlInstructions.SuspendLayout();
            this.pnlPizzaNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSauce
            // 
            this.grbSauce.Controls.Add(this.rdbSauce3);
            this.grbSauce.Controls.Add(this.rdbSauce2);
            this.grbSauce.Controls.Add(this.rdbSauce1);
            this.grbSauce.Controls.Add(this.rdbSauce0);
            this.grbSauce.Location = new System.Drawing.Point(19, 23);
            this.grbSauce.Name = "grbSauce";
            this.grbSauce.Size = new System.Drawing.Size(289, 75);
            this.grbSauce.TabIndex = 0;
            this.grbSauce.TabStop = false;
            this.grbSauce.Text = "Sauce";
            // 
            // rdbSauce3
            // 
            this.rdbSauce3.AutoSize = true;
            this.rdbSauce3.Location = new System.Drawing.Point(226, 34);
            this.rdbSauce3.Name = "rdbSauce3";
            this.rdbSauce3.Size = new System.Drawing.Size(56, 17);
            this.rdbSauce3.TabIndex = 3;
            this.rdbSauce3.TabStop = true;
            this.rdbSauce3.Text = "Heavy";
            this.rdbSauce3.UseVisualStyleBackColor = true;
            this.rdbSauce3.Click += new System.EventHandler(this.rdbSauceChecked);
            // 
            // rdbSauce2
            // 
            this.rdbSauce2.AutoSize = true;
            this.rdbSauce2.Location = new System.Drawing.Point(152, 34);
            this.rdbSauce2.Name = "rdbSauce2";
            this.rdbSauce2.Size = new System.Drawing.Size(58, 17);
            this.rdbSauce2.TabIndex = 2;
            this.rdbSauce2.TabStop = true;
            this.rdbSauce2.Text = "Normal";
            this.rdbSauce2.UseVisualStyleBackColor = true;
            this.rdbSauce2.Click += new System.EventHandler(this.rdbSauceChecked);
            // 
            // rdbSauce1
            // 
            this.rdbSauce1.AutoSize = true;
            this.rdbSauce1.Location = new System.Drawing.Point(83, 34);
            this.rdbSauce1.Name = "rdbSauce1";
            this.rdbSauce1.Size = new System.Drawing.Size(48, 17);
            this.rdbSauce1.TabIndex = 1;
            this.rdbSauce1.TabStop = true;
            this.rdbSauce1.Text = "Light";
            this.rdbSauce1.UseVisualStyleBackColor = true;
            this.rdbSauce1.Click += new System.EventHandler(this.rdbSauceChecked);
            // 
            // rdbSauce0
            // 
            this.rdbSauce0.AutoSize = true;
            this.rdbSauce0.Location = new System.Drawing.Point(13, 34);
            this.rdbSauce0.Name = "rdbSauce0";
            this.rdbSauce0.Size = new System.Drawing.Size(51, 17);
            this.rdbSauce0.TabIndex = 0;
            this.rdbSauce0.TabStop = true;
            this.rdbSauce0.Text = "None";
            this.rdbSauce0.UseVisualStyleBackColor = true;
            this.rdbSauce0.Click += new System.EventHandler(this.rdbSauceChecked);
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.chk9);
            this.grbToppings.Controls.Add(this.chk6);
            this.grbToppings.Controls.Add(this.chk3);
            this.grbToppings.Controls.Add(this.chk11);
            this.grbToppings.Controls.Add(this.chk5);
            this.grbToppings.Controls.Add(this.chk8);
            this.grbToppings.Controls.Add(this.chk2);
            this.grbToppings.Controls.Add(this.chk10);
            this.grbToppings.Controls.Add(this.chk7);
            this.grbToppings.Controls.Add(this.chk4);
            this.grbToppings.Controls.Add(this.chk1);
            this.grbToppings.Location = new System.Drawing.Point(19, 119);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(289, 194);
            this.grbToppings.TabIndex = 1;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // chk9
            // 
            this.chk9.AutoSize = true;
            this.chk9.Location = new System.Drawing.Point(207, 105);
            this.chk9.Name = "chk9";
            this.chk9.Size = new System.Drawing.Size(65, 17);
            this.chk9.TabIndex = 24;
            this.chk9.Text = "Spinach";
            this.chk9.UseVisualStyleBackColor = true;
            this.chk9.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(210, 67);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(62, 17);
            this.chk6.TabIndex = 22;
            this.chk6.Text = "Tomato";
            this.chk6.UseVisualStyleBackColor = true;
            this.chk6.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(207, 32);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(48, 17);
            this.chk3.TabIndex = 20;
            this.chk3.Text = "Ham";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk11
            // 
            this.chk11.AutoSize = true;
            this.chk11.Location = new System.Drawing.Point(117, 142);
            this.chk11.Name = "chk11";
            this.chk11.Size = new System.Drawing.Size(90, 17);
            this.chk11.TabIndex = 18;
            this.chk11.Text = "Olives, Green";
            this.chk11.UseVisualStyleBackColor = true;
            this.chk11.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(117, 67);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(73, 17);
            this.chk5.TabIndex = 16;
            this.chk5.Text = "Pineapple";
            this.chk5.UseVisualStyleBackColor = true;
            this.chk5.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(117, 105);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(54, 17);
            this.chk8.TabIndex = 16;
            this.chk8.Text = "Onion";
            this.chk8.UseVisualStyleBackColor = true;
            this.chk8.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(117, 32);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(57, 17);
            this.chk2.TabIndex = 14;
            this.chk2.Text = "Bacon";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(13, 142);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(88, 17);
            this.chk10.TabIndex = 12;
            this.chk10.Text = "Olives, Black";
            this.chk10.UseVisualStyleBackColor = true;
            this.chk10.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(13, 105);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(97, 17);
            this.chk7.TabIndex = 10;
            this.chk7.Text = "Green Peppers";
            this.chk7.UseVisualStyleBackColor = true;
            this.chk7.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(13, 67);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(80, 17);
            this.chk4.TabIndex = 8;
            this.chk4.Text = "Mushrooms";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(13, 32);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(74, 17);
            this.chk1.TabIndex = 6;
            this.chk1.Text = "Pepperoni";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.chkToppings_Changed);
            // 
            // grbCheese
            // 
            this.grbCheese.Controls.Add(this.rdbCheese3);
            this.grbCheese.Controls.Add(this.rdbCheese2);
            this.grbCheese.Controls.Add(this.rdbCheese1);
            this.grbCheese.Controls.Add(this.rdbCheese0);
            this.grbCheese.Location = new System.Drawing.Point(19, 319);
            this.grbCheese.Name = "grbCheese";
            this.grbCheese.Size = new System.Drawing.Size(289, 76);
            this.grbCheese.TabIndex = 2;
            this.grbCheese.TabStop = false;
            this.grbCheese.Text = "Cheese";
            // 
            // rdbCheese3
            // 
            this.rdbCheese3.AutoSize = true;
            this.rdbCheese3.Location = new System.Drawing.Point(226, 33);
            this.rdbCheese3.Name = "rdbCheese3";
            this.rdbCheese3.Size = new System.Drawing.Size(56, 17);
            this.rdbCheese3.TabIndex = 3;
            this.rdbCheese3.TabStop = true;
            this.rdbCheese3.Text = "Heavy";
            this.rdbCheese3.UseVisualStyleBackColor = true;
            this.rdbCheese3.CheckedChanged += new System.EventHandler(this.rdbCheeseChecked);
            // 
            // rdbCheese2
            // 
            this.rdbCheese2.AutoSize = true;
            this.rdbCheese2.Location = new System.Drawing.Point(152, 33);
            this.rdbCheese2.Name = "rdbCheese2";
            this.rdbCheese2.Size = new System.Drawing.Size(58, 17);
            this.rdbCheese2.TabIndex = 2;
            this.rdbCheese2.TabStop = true;
            this.rdbCheese2.Text = "Normal";
            this.rdbCheese2.UseVisualStyleBackColor = true;
            this.rdbCheese2.CheckedChanged += new System.EventHandler(this.rdbCheeseChecked);
            // 
            // rdbCheese1
            // 
            this.rdbCheese1.AutoSize = true;
            this.rdbCheese1.Location = new System.Drawing.Point(83, 33);
            this.rdbCheese1.Name = "rdbCheese1";
            this.rdbCheese1.Size = new System.Drawing.Size(48, 17);
            this.rdbCheese1.TabIndex = 1;
            this.rdbCheese1.TabStop = true;
            this.rdbCheese1.Text = "Light";
            this.rdbCheese1.UseVisualStyleBackColor = true;
            this.rdbCheese1.CheckedChanged += new System.EventHandler(this.rdbCheeseChecked);
            // 
            // rdbCheese0
            // 
            this.rdbCheese0.AutoSize = true;
            this.rdbCheese0.Location = new System.Drawing.Point(13, 33);
            this.rdbCheese0.Name = "rdbCheese0";
            this.rdbCheese0.Size = new System.Drawing.Size(51, 17);
            this.rdbCheese0.TabIndex = 0;
            this.rdbCheese0.TabStop = true;
            this.rdbCheese0.Text = "None";
            this.rdbCheese0.UseVisualStyleBackColor = true;
            this.rdbCheese0.CheckedChanged += new System.EventHandler(this.rdbCheeseChecked);
            // 
            // lblSpecialInstruction
            // 
            this.lblSpecialInstruction.AutoSize = true;
            this.lblSpecialInstruction.Location = new System.Drawing.Point(16, 410);
            this.lblSpecialInstruction.Name = "lblSpecialInstruction";
            this.lblSpecialInstruction.Size = new System.Drawing.Size(102, 13);
            this.lblSpecialInstruction.TabIndex = 3;
            this.lblSpecialInstruction.Text = "Special Instructions:";
            // 
            // lblPizzaNum
            // 
            this.lblPizzaNum.AutoSize = true;
            this.lblPizzaNum.Location = new System.Drawing.Point(21, 17);
            this.lblPizzaNum.Name = "lblPizzaNum";
            this.lblPizzaNum.Size = new System.Drawing.Size(95, 13);
            this.lblPizzaNum.TabIndex = 2;
            this.lblPizzaNum.Text = "How many pizzas?";
            // 
            // txtPizzaNum
            // 
            this.txtPizzaNum.Location = new System.Drawing.Point(122, 10);
            this.txtPizzaNum.Name = "txtPizzaNum";
            this.txtPizzaNum.Size = new System.Drawing.Size(45, 20);
            this.txtPizzaNum.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(92, 57);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Start Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Red;
            this.btnCheckOut.Location = new System.Drawing.Point(19, 530);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(279, 36);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(19, 426);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(279, 89);
            this.txtInstructions.TabIndex = 6;
            this.txtInstructions.Leave += new System.EventHandler(this.txtInstructions_Leave);
            // 
            // pnlPizzas
            // 
            this.pnlPizzas.AutoScroll = true;
            this.pnlPizzas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPizzas.Location = new System.Drawing.Point(28, 145);
            this.pnlPizzas.Name = "pnlPizzas";
            this.pnlPizzas.Size = new System.Drawing.Size(200, 461);
            this.pnlPizzas.TabIndex = 0;
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.AutoScroll = true;
            this.pnlInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInstructions.Controls.Add(this.grbSauce);
            this.pnlInstructions.Controls.Add(this.grbToppings);
            this.pnlInstructions.Controls.Add(this.txtInstructions);
            this.pnlInstructions.Controls.Add(this.grbCheese);
            this.pnlInstructions.Controls.Add(this.btnCheckOut);
            this.pnlInstructions.Controls.Add(this.lblSpecialInstruction);
            this.pnlInstructions.Enabled = false;
            this.pnlInstructions.Location = new System.Drawing.Point(247, 25);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(331, 581);
            this.pnlInstructions.TabIndex = 1;
            // 
            // pnlPizzaNum
            // 
            this.pnlPizzaNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPizzaNum.Controls.Add(this.lblErrorMessage);
            this.pnlPizzaNum.Controls.Add(this.lblPizzaNum);
            this.pnlPizzaNum.Controls.Add(this.btnOrder);
            this.pnlPizzaNum.Controls.Add(this.txtPizzaNum);
            this.pnlPizzaNum.Location = new System.Drawing.Point(28, 25);
            this.pnlPizzaNum.Name = "pnlPizzaNum";
            this.pnlPizzaNum.Size = new System.Drawing.Size(200, 100);
            this.pnlPizzaNum.TabIndex = 0;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(24, 37);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(143, 17);
            this.lblErrorMessage.TabIndex = 0;
            // 
            // FormPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(606, 625);
            this.Controls.Add(this.pnlPizzaNum);
            this.Controls.Add(this.pnlInstructions);
            this.Controls.Add(this.pnlPizzas);
            this.MaximizeBox = false;
            this.Name = "FormPizzaOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order";
            this.grbSauce.ResumeLayout(false);
            this.grbSauce.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbCheese.ResumeLayout(false);
            this.grbCheese.PerformLayout();
            this.pnlInstructions.ResumeLayout(false);
            this.pnlInstructions.PerformLayout();
            this.pnlPizzaNum.ResumeLayout(false);
            this.pnlPizzaNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSauce;
        private System.Windows.Forms.RadioButton rdbSauce3;
        private System.Windows.Forms.RadioButton rdbSauce2;
        private System.Windows.Forms.RadioButton rdbSauce1;
        private System.Windows.Forms.RadioButton rdbSauce0;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.CheckBox chk9;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk11;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.GroupBox grbCheese;
        private System.Windows.Forms.RadioButton rdbCheese3;
        private System.Windows.Forms.RadioButton rdbCheese2;
        private System.Windows.Forms.RadioButton rdbCheese1;
        private System.Windows.Forms.RadioButton rdbCheese0;
        private System.Windows.Forms.Label lblSpecialInstruction;
        private System.Windows.Forms.Label lblPizzaNum;
        private System.Windows.Forms.TextBox txtPizzaNum;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Panel pnlPizzas;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Panel pnlPizzaNum;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

