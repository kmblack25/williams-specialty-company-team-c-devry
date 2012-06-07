namespace WSC_Business_Automation_test
{
    partial class Print_Engrave_Specialist
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbStock = new System.Windows.Forms.GroupBox();
            this.txtStockDelivery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbStockNo = new System.Windows.Forms.RadioButton();
            this.rdbStockYes = new System.Windows.Forms.RadioButton();
            this.lblOrdNum = new System.Windows.Forms.Label();
            this.grbInventory = new System.Windows.Forms.GroupBox();
            this.lblQtyItem5 = new System.Windows.Forms.Label();
            this.cmbItem5 = new System.Windows.Forms.ComboBox();
            this.cmbItem4 = new System.Windows.Forms.ComboBox();
            this.cmbItem3 = new System.Windows.Forms.ComboBox();
            this.cmbItem2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblQtyItem4 = new System.Windows.Forms.Label();
            this.lblQtyItem3 = new System.Windows.Forms.Label();
            this.lblQtyItem2 = new System.Windows.Forms.Label();
            this.lblQtyItem1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblItem5 = new System.Windows.Forms.Label();
            this.lblItem4 = new System.Windows.Forms.Label();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbQA = new System.Windows.Forms.GroupBox();
            this.txtQAComments = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rdbQAFail = new System.Windows.Forms.RadioButton();
            this.rdbQAPass = new System.Windows.Forms.RadioButton();
            this.cmbItem1 = new System.Windows.Forms.ComboBox();
            this.grbStock.SuspendLayout();
            this.grbInventory.SuspendLayout();
            this.grbQA.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(591, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Order Complete";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(437, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Order Validated";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Number";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(739, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(739, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Notifications";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(739, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(739, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grbStock
            // 
            this.grbStock.Controls.Add(this.txtStockDelivery);
            this.grbStock.Controls.Add(this.label3);
            this.grbStock.Controls.Add(this.rdbStockNo);
            this.grbStock.Controls.Add(this.rdbStockYes);
            this.grbStock.Location = new System.Drawing.Point(418, 221);
            this.grbStock.Name = "grbStock";
            this.grbStock.Size = new System.Drawing.Size(278, 129);
            this.grbStock.TabIndex = 46;
            this.grbStock.TabStop = false;
            this.grbStock.Text = "Stock Availability";
            this.grbStock.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtStockDelivery
            // 
            this.txtStockDelivery.Location = new System.Drawing.Point(106, 96);
            this.txtStockDelivery.Name = "txtStockDelivery";
            this.txtStockDelivery.Size = new System.Drawing.Size(102, 20);
            this.txtStockDelivery.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expected Delivery";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // rdbStockNo
            // 
            this.rdbStockNo.AutoSize = true;
            this.rdbStockNo.Location = new System.Drawing.Point(7, 57);
            this.rdbStockNo.Name = "rdbStockNo";
            this.rdbStockNo.Size = new System.Drawing.Size(39, 17);
            this.rdbStockNo.TabIndex = 1;
            this.rdbStockNo.TabStop = true;
            this.rdbStockNo.Text = "No";
            this.rdbStockNo.UseVisualStyleBackColor = true;
            // 
            // rdbStockYes
            // 
            this.rdbStockYes.AutoSize = true;
            this.rdbStockYes.Location = new System.Drawing.Point(7, 33);
            this.rdbStockYes.Name = "rdbStockYes";
            this.rdbStockYes.Size = new System.Drawing.Size(43, 17);
            this.rdbStockYes.TabIndex = 0;
            this.rdbStockYes.TabStop = true;
            this.rdbStockYes.Text = "Yes";
            this.rdbStockYes.UseVisualStyleBackColor = true;
            this.rdbStockYes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblOrdNum
            // 
            this.lblOrdNum.AutoSize = true;
            this.lblOrdNum.Location = new System.Drawing.Point(110, 28);
            this.lblOrdNum.Name = "lblOrdNum";
            this.lblOrdNum.Size = new System.Drawing.Size(76, 13);
            this.lblOrdNum.TabIndex = 48;
            this.lblOrdNum.Text = "Order_Number";
            // 
            // grbInventory
            // 
            this.grbInventory.Controls.Add(this.cmbItem1);
            this.grbInventory.Controls.Add(this.lblQtyItem5);
            this.grbInventory.Controls.Add(this.cmbItem5);
            this.grbInventory.Controls.Add(this.cmbItem4);
            this.grbInventory.Controls.Add(this.cmbItem3);
            this.grbInventory.Controls.Add(this.cmbItem2);
            this.grbInventory.Controls.Add(this.label15);
            this.grbInventory.Controls.Add(this.lblQtyItem4);
            this.grbInventory.Controls.Add(this.lblQtyItem3);
            this.grbInventory.Controls.Add(this.lblQtyItem2);
            this.grbInventory.Controls.Add(this.lblQtyItem1);
            this.grbInventory.Controls.Add(this.label10);
            this.grbInventory.Controls.Add(this.lblItem5);
            this.grbInventory.Controls.Add(this.lblItem4);
            this.grbInventory.Controls.Add(this.lblItem3);
            this.grbInventory.Controls.Add(this.lblItem2);
            this.grbInventory.Controls.Add(this.lblItem1);
            this.grbInventory.Controls.Add(this.label4);
            this.grbInventory.Location = new System.Drawing.Point(15, 117);
            this.grbInventory.Name = "grbInventory";
            this.grbInventory.Size = new System.Drawing.Size(375, 233);
            this.grbInventory.TabIndex = 49;
            this.grbInventory.TabStop = false;
            this.grbInventory.Text = "Ordered Items";
            // 
            // lblQtyItem5
            // 
            this.lblQtyItem5.AutoSize = true;
            this.lblQtyItem5.Location = new System.Drawing.Point(130, 211);
            this.lblQtyItem5.Name = "lblQtyItem5";
            this.lblQtyItem5.Size = new System.Drawing.Size(55, 13);
            this.lblQtyItem5.TabIndex = 17;
            this.lblQtyItem5.Text = "Qty_Item5";
            // 
            // cmbItem5
            // 
            this.cmbItem5.FormattingEnabled = true;
            this.cmbItem5.Location = new System.Drawing.Point(222, 203);
            this.cmbItem5.MaxDropDownItems = 2;
            this.cmbItem5.Name = "cmbItem5";
            this.cmbItem5.Size = new System.Drawing.Size(121, 21);
            this.cmbItem5.TabIndex = 16;
            // 
            // cmbItem4
            // 
            this.cmbItem4.FormattingEnabled = true;
            this.cmbItem4.Location = new System.Drawing.Point(222, 169);
            this.cmbItem4.MaxDropDownItems = 2;
            this.cmbItem4.Name = "cmbItem4";
            this.cmbItem4.Size = new System.Drawing.Size(121, 21);
            this.cmbItem4.TabIndex = 15;
            // 
            // cmbItem3
            // 
            this.cmbItem3.FormattingEnabled = true;
            this.cmbItem3.Location = new System.Drawing.Point(222, 131);
            this.cmbItem3.MaxDropDownItems = 2;
            this.cmbItem3.Name = "cmbItem3";
            this.cmbItem3.Size = new System.Drawing.Size(121, 21);
            this.cmbItem3.TabIndex = 14;
            // 
            // cmbItem2
            // 
            this.cmbItem2.FormattingEnabled = true;
            this.cmbItem2.Location = new System.Drawing.Point(222, 91);
            this.cmbItem2.MaxDropDownItems = 2;
            this.cmbItem2.Name = "cmbItem2";
            this.cmbItem2.Size = new System.Drawing.Size(121, 21);
            this.cmbItem2.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(219, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Sold or Delivered";
            // 
            // lblQtyItem4
            // 
            this.lblQtyItem4.AutoSize = true;
            this.lblQtyItem4.Location = new System.Drawing.Point(130, 177);
            this.lblQtyItem4.Name = "lblQtyItem4";
            this.lblQtyItem4.Size = new System.Drawing.Size(55, 13);
            this.lblQtyItem4.TabIndex = 10;
            this.lblQtyItem4.Text = "Qty_Item4";
            // 
            // lblQtyItem3
            // 
            this.lblQtyItem3.AutoSize = true;
            this.lblQtyItem3.Location = new System.Drawing.Point(130, 134);
            this.lblQtyItem3.Name = "lblQtyItem3";
            this.lblQtyItem3.Size = new System.Drawing.Size(55, 13);
            this.lblQtyItem3.TabIndex = 9;
            this.lblQtyItem3.Text = "Qty_Item3";
            // 
            // lblQtyItem2
            // 
            this.lblQtyItem2.AutoSize = true;
            this.lblQtyItem2.Location = new System.Drawing.Point(130, 99);
            this.lblQtyItem2.Name = "lblQtyItem2";
            this.lblQtyItem2.Size = new System.Drawing.Size(55, 13);
            this.lblQtyItem2.TabIndex = 8;
            this.lblQtyItem2.Text = "Qty_Item2";
            // 
            // lblQtyItem1
            // 
            this.lblQtyItem1.AutoSize = true;
            this.lblQtyItem1.Location = new System.Drawing.Point(127, 57);
            this.lblQtyItem1.Name = "lblQtyItem1";
            this.lblQtyItem1.Size = new System.Drawing.Size(55, 13);
            this.lblQtyItem1.TabIndex = 7;
            this.lblQtyItem1.Text = "Qty_Item1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Quantity";
            // 
            // lblItem5
            // 
            this.lblItem5.AutoSize = true;
            this.lblItem5.Location = new System.Drawing.Point(15, 211);
            this.lblItem5.Name = "lblItem5";
            this.lblItem5.Size = new System.Drawing.Size(77, 13);
            this.lblItem5.TabIndex = 5;
            this.lblItem5.Text = "Catalog_Num4";
            // 
            // lblItem4
            // 
            this.lblItem4.AutoSize = true;
            this.lblItem4.Location = new System.Drawing.Point(15, 177);
            this.lblItem4.Name = "lblItem4";
            this.lblItem4.Size = new System.Drawing.Size(77, 13);
            this.lblItem4.TabIndex = 4;
            this.lblItem4.Text = "Catalog_Num3";
            // 
            // lblItem3
            // 
            this.lblItem3.AutoSize = true;
            this.lblItem3.Location = new System.Drawing.Point(15, 139);
            this.lblItem3.Name = "lblItem3";
            this.lblItem3.Size = new System.Drawing.Size(77, 13);
            this.lblItem3.TabIndex = 3;
            this.lblItem3.Text = "Catalog_Num3";
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Location = new System.Drawing.Point(15, 99);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(77, 13);
            this.lblItem2.TabIndex = 2;
            this.lblItem2.Text = "Catalog_Num2";
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Location = new System.Drawing.Point(15, 57);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(77, 13);
            this.lblItem1.TabIndex = 1;
            this.lblItem1.Text = "Catalog_Num1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stock Item";
            // 
            // grbQA
            // 
            this.grbQA.Controls.Add(this.txtQAComments);
            this.grbQA.Controls.Add(this.label17);
            this.grbQA.Controls.Add(this.rdbQAFail);
            this.grbQA.Controls.Add(this.rdbQAPass);
            this.grbQA.Location = new System.Drawing.Point(418, 117);
            this.grbQA.Name = "grbQA";
            this.grbQA.Size = new System.Drawing.Size(278, 100);
            this.grbQA.TabIndex = 50;
            this.grbQA.TabStop = false;
            this.grbQA.Text = "Quality Assurance";
            // 
            // txtQAComments
            // 
            this.txtQAComments.Location = new System.Drawing.Point(142, 20);
            this.txtQAComments.Multiline = true;
            this.txtQAComments.Name = "txtQAComments";
            this.txtQAComments.Size = new System.Drawing.Size(130, 74);
            this.txtQAComments.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(79, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Comments";
            // 
            // rdbQAFail
            // 
            this.rdbQAFail.AutoSize = true;
            this.rdbQAFail.Location = new System.Drawing.Point(10, 61);
            this.rdbQAFail.Name = "rdbQAFail";
            this.rdbQAFail.Size = new System.Drawing.Size(41, 17);
            this.rdbQAFail.TabIndex = 1;
            this.rdbQAFail.TabStop = true;
            this.rdbQAFail.Text = "Fail";
            this.rdbQAFail.UseVisualStyleBackColor = true;
            // 
            // rdbQAPass
            // 
            this.rdbQAPass.AutoSize = true;
            this.rdbQAPass.Location = new System.Drawing.Point(7, 20);
            this.rdbQAPass.Name = "rdbQAPass";
            this.rdbQAPass.Size = new System.Drawing.Size(48, 17);
            this.rdbQAPass.TabIndex = 0;
            this.rdbQAPass.TabStop = true;
            this.rdbQAPass.Text = "Pass";
            this.rdbQAPass.UseVisualStyleBackColor = true;
            // 
            // cmbItem1
            // 
            this.cmbItem1.FormattingEnabled = true;
            this.cmbItem1.Location = new System.Drawing.Point(222, 57);
            this.cmbItem1.MaxDropDownItems = 2;
            this.cmbItem1.Name = "cmbItem1";
            this.cmbItem1.Size = new System.Drawing.Size(121, 21);
            this.cmbItem1.TabIndex = 18;
            // 
            // Print_Engrave_Specialist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 362);
            this.Controls.Add(this.grbQA);
            this.Controls.Add(this.grbInventory);
            this.Controls.Add(this.lblOrdNum);
            this.Controls.Add(this.grbStock);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Print_Engrave_Specialist";
            this.Text = "Print_Engrave_Specialist";
            this.Load += new System.EventHandler(this.Print_Engrave_Specialist_Load);
            this.grbStock.ResumeLayout(false);
            this.grbStock.PerformLayout();
            this.grbInventory.ResumeLayout(false);
            this.grbInventory.PerformLayout();
            this.grbQA.ResumeLayout(false);
            this.grbQA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grbStock;
        private System.Windows.Forms.RadioButton rdbStockYes;
        private System.Windows.Forms.RadioButton rdbStockNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStockDelivery;
        private System.Windows.Forms.Label lblOrdNum;
        private System.Windows.Forms.GroupBox grbInventory;
        private System.Windows.Forms.Label lblQtyItem4;
        private System.Windows.Forms.Label lblQtyItem3;
        private System.Windows.Forms.Label lblQtyItem2;
        private System.Windows.Forms.Label lblQtyItem1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblItem5;
        private System.Windows.Forms.Label lblItem4;
        private System.Windows.Forms.Label lblItem3;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQtyItem5;
        private System.Windows.Forms.ComboBox cmbItem5;
        private System.Windows.Forms.ComboBox cmbItem4;
        private System.Windows.Forms.ComboBox cmbItem3;
        private System.Windows.Forms.ComboBox cmbItem2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grbQA;
        private System.Windows.Forms.TextBox txtQAComments;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rdbQAFail;
        private System.Windows.Forms.RadioButton rdbQAPass;
        private System.Windows.Forms.ComboBox cmbItem1;
    }
}