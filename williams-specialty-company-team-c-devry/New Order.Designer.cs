namespace WSC_Business_Automation_test
{
    partial class New_Order
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblSalesPerson = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblSalesId = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblAutoGenOrdNum = new System.Windows.Forms.Label();
            this.lblOrdType = new System.Windows.Forms.TextBox();
            this.rdbPrint = new System.Windows.Forms.RadioButton();
            this.rdbEngrave = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSysDate = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrdStat = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbItem1 = new System.Windows.Forms.ComboBox();
            this.cmbItem2 = new System.Windows.Forms.ComboBox();
            this.cmbItem3 = new System.Windows.Forms.ComboBox();
            this.cmbItem4 = new System.Windows.Forms.ComboBox();
            this.cmbItem5 = new System.Windows.Forms.ComboBox();
            this.numItem1 = new System.Windows.Forms.NumericUpDown();
            this.numItem2 = new System.Windows.Forms.NumericUpDown();
            this.numItem3 = new System.Windows.Forms.NumericUpDown();
            this.numItem4 = new System.Windows.Forms.NumericUpDown();
            this.numItem5 = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.txtEngOrd1 = new System.Windows.Forms.TextBox();
            this.txtEngOrd2 = new System.Windows.Forms.TextBox();
            this.txtEngOrd3 = new System.Windows.Forms.TextBox();
            this.txtEngOrd4 = new System.Windows.Forms.TextBox();
            this.txtEngOrd5 = new System.Windows.Forms.TextBox();
            this.lblItemTag = new System.Windows.Forms.Label();
            this.lblEngravingTag = new System.Windows.Forms.Label();
            this.lblQuantityTag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCostItm1 = new System.Windows.Forms.Label();
            this.lblCostItm2 = new System.Windows.Forms.Label();
            this.lblCostItm3 = new System.Windows.Forms.Label();
            this.lblCostItm4 = new System.Windows.Forms.Label();
            this.lblCostItm5 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalCst = new System.Windows.Forms.Label();
            this.lblTotQuantity = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(73, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Order Number";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(371, 18);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(82, 13);
            this.lblCustName.TabIndex = 2;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.AutoSize = true;
            this.lblSalesPerson.Location = new System.Drawing.Point(628, 17);
            this.lblSalesPerson.Name = "lblSalesPerson";
            this.lblSalesPerson.Size = new System.Drawing.Size(69, 13);
            this.lblSalesPerson.TabIndex = 4;
            this.lblSalesPerson.Text = "Sales Person";
            this.lblSalesPerson.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(25, 76);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(60, 13);
            this.lblOrderType.TabIndex = 6;
            this.lblOrderType.Text = "Order Type";
            // 
            // lblSalesId
            // 
            this.lblSalesId.AutoSize = true;
            this.lblSalesId.Location = new System.Drawing.Point(736, 15);
            this.lblSalesId.Name = "lblSalesId";
            this.lblSalesId.Size = new System.Drawing.Size(47, 13);
            this.lblSalesId.TabIndex = 7;
            this.lblSalesId.Text = "Sales ID";
            this.lblSalesId.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(487, 18);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(42, 13);
            this.lblCustId.TabIndex = 8;
            this.lblCustId.Text = "Cust ID";
            // 
            // lblAutoGenOrdNum
            // 
            this.lblAutoGenOrdNum.AutoSize = true;
            this.lblAutoGenOrdNum.Location = new System.Drawing.Point(113, 18);
            this.lblAutoGenOrdNum.Name = "lblAutoGenOrdNum";
            this.lblAutoGenOrdNum.Size = new System.Drawing.Size(124, 13);
            this.lblAutoGenOrdNum.TabIndex = 9;
            this.lblAutoGenOrdNum.Text = "Auto Gen Order_Number";
            // 
            // lblOrdType
            // 
            this.lblOrdType.Location = new System.Drawing.Point(116, 76);
            this.lblOrdType.Name = "lblOrdType";
            this.lblOrdType.Size = new System.Drawing.Size(100, 20);
            this.lblOrdType.TabIndex = 10;
            // 
            // rdbPrint
            // 
            this.rdbPrint.AutoSize = true;
            this.rdbPrint.Location = new System.Drawing.Point(365, 72);
            this.rdbPrint.Name = "rdbPrint";
            this.rdbPrint.Size = new System.Drawing.Size(46, 17);
            this.rdbPrint.TabIndex = 11;
            this.rdbPrint.TabStop = true;
            this.rdbPrint.Text = "Print";
            this.rdbPrint.UseVisualStyleBackColor = true;
            // 
            // rdbEngrave
            // 
            this.rdbEngrave.AutoSize = true;
            this.rdbEngrave.Location = new System.Drawing.Point(464, 72);
            this.rdbEngrave.Name = "rdbEngrave";
            this.rdbEngrave.Size = new System.Drawing.Size(65, 17);
            this.rdbEngrave.TabIndex = 12;
            this.rdbEngrave.TabStop = true;
            this.rdbEngrave.Text = "Engrave";
            this.rdbEngrave.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(864, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
            // 
            // lblSysDate
            // 
            this.lblSysDate.AutoSize = true;
            this.lblSysDate.Location = new System.Drawing.Point(936, 18);
            this.lblSysDate.Name = "lblSysDate";
            this.lblSysDate.Size = new System.Drawing.Size(48, 13);
            this.lblSysDate.TabIndex = 14;
            this.lblSysDate.Text = "Sys date";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(746, 72);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(66, 13);
            this.lblOrderStatus.TabIndex = 15;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // lblOrdStat
            // 
            this.lblOrdStat.AutoSize = true;
            this.lblOrdStat.Location = new System.Drawing.Point(854, 72);
            this.lblOrdStat.Name = "lblOrdStat";
            this.lblOrdStat.Size = new System.Drawing.Size(69, 13);
            this.lblOrdStat.TabIndex = 16;
            this.lblOrdStat.Text = "Order_Status";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(28, 202);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbItem5);
            this.splitContainer1.Panel1.Controls.Add(this.cmbItem4);
            this.splitContainer1.Panel1.Controls.Add(this.cmbItem3);
            this.splitContainer1.Panel1.Controls.Add(this.cmbItem2);
            this.splitContainer1.Panel1.Controls.Add(this.cmbItem1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalQuantity);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotQuantity);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalCst);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalCost);
            this.splitContainer1.Panel2.Controls.Add(this.lblCostItm5);
            this.splitContainer1.Panel2.Controls.Add(this.lblCostItm4);
            this.splitContainer1.Panel2.Controls.Add(this.lblCostItm3);
            this.splitContainer1.Panel2.Controls.Add(this.lblCostItm2);
            this.splitContainer1.Panel2.Controls.Add(this.lblCostItm1);
            this.splitContainer1.Panel2.Controls.Add(this.txtEngOrd5);
            this.splitContainer1.Panel2.Controls.Add(this.txtEngOrd4);
            this.splitContainer1.Panel2.Controls.Add(this.txtEngOrd3);
            this.splitContainer1.Panel2.Controls.Add(this.txtEngOrd2);
            this.splitContainer1.Panel2.Controls.Add(this.txtEngOrd1);
            this.splitContainer1.Panel2.Controls.Add(this.numItem5);
            this.splitContainer1.Panel2.Controls.Add(this.numItem4);
            this.splitContainer1.Panel2.Controls.Add(this.numItem3);
            this.splitContainer1.Panel2.Controls.Add(this.numItem2);
            this.splitContainer1.Panel2.Controls.Add(this.numItem1);
            this.splitContainer1.Size = new System.Drawing.Size(866, 382);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.TabIndex = 17;
            // 
            // cmbItem1
            // 
            this.cmbItem1.FormattingEnabled = true;
            this.cmbItem1.Location = new System.Drawing.Point(16, 19);
            this.cmbItem1.Name = "cmbItem1";
            this.cmbItem1.Size = new System.Drawing.Size(121, 21);
            this.cmbItem1.TabIndex = 0;
            this.cmbItem1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbItem2
            // 
            this.cmbItem2.FormattingEnabled = true;
            this.cmbItem2.Location = new System.Drawing.Point(16, 74);
            this.cmbItem2.Name = "cmbItem2";
            this.cmbItem2.Size = new System.Drawing.Size(121, 21);
            this.cmbItem2.TabIndex = 1;
            // 
            // cmbItem3
            // 
            this.cmbItem3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cmbItem3.FormattingEnabled = true;
            this.cmbItem3.Location = new System.Drawing.Point(16, 129);
            this.cmbItem3.Name = "cmbItem3";
            this.cmbItem3.Size = new System.Drawing.Size(121, 21);
            this.cmbItem3.TabIndex = 2;
            // 
            // cmbItem4
            // 
            this.cmbItem4.FormattingEnabled = true;
            this.cmbItem4.Location = new System.Drawing.Point(16, 189);
            this.cmbItem4.Name = "cmbItem4";
            this.cmbItem4.Size = new System.Drawing.Size(121, 21);
            this.cmbItem4.TabIndex = 3;
            // 
            // cmbItem5
            // 
            this.cmbItem5.FormattingEnabled = true;
            this.cmbItem5.Location = new System.Drawing.Point(16, 255);
            this.cmbItem5.Name = "cmbItem5";
            this.cmbItem5.Size = new System.Drawing.Size(121, 21);
            this.cmbItem5.TabIndex = 4;
            // 
            // numItem1
            // 
            this.numItem1.Location = new System.Drawing.Point(299, 19);
            this.numItem1.Name = "numItem1";
            this.numItem1.Size = new System.Drawing.Size(120, 20);
            this.numItem1.TabIndex = 0;
            // 
            // numItem2
            // 
            this.numItem2.Location = new System.Drawing.Point(299, 75);
            this.numItem2.Name = "numItem2";
            this.numItem2.Size = new System.Drawing.Size(120, 20);
            this.numItem2.TabIndex = 1;
            // 
            // numItem3
            // 
            this.numItem3.Location = new System.Drawing.Point(299, 130);
            this.numItem3.Name = "numItem3";
            this.numItem3.Size = new System.Drawing.Size(120, 20);
            this.numItem3.TabIndex = 2;
            // 
            // numItem4
            // 
            this.numItem4.Location = new System.Drawing.Point(299, 189);
            this.numItem4.Name = "numItem4";
            this.numItem4.Size = new System.Drawing.Size(120, 20);
            this.numItem4.TabIndex = 3;
            // 
            // numItem5
            // 
            this.numItem5.Location = new System.Drawing.Point(299, 255);
            this.numItem5.Name = "numItem5";
            this.numItem5.Size = new System.Drawing.Size(120, 20);
            this.numItem5.TabIndex = 4;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(901, 540);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(113, 23);
            this.btnSubmitOrder.TabIndex = 18;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.Location = new System.Drawing.Point(901, 487);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(113, 23);
            this.btnUploadPic.TabIndex = 19;
            this.btnUploadPic.Text = "Upload Picture";
            this.btnUploadPic.UseVisualStyleBackColor = true;
            // 
            // txtEngOrd1
            // 
            this.txtEngOrd1.Location = new System.Drawing.Point(41, 19);
            this.txtEngOrd1.Name = "txtEngOrd1";
            this.txtEngOrd1.Size = new System.Drawing.Size(100, 20);
            this.txtEngOrd1.TabIndex = 5;
            // 
            // txtEngOrd2
            // 
            this.txtEngOrd2.Location = new System.Drawing.Point(41, 75);
            this.txtEngOrd2.Name = "txtEngOrd2";
            this.txtEngOrd2.Size = new System.Drawing.Size(100, 20);
            this.txtEngOrd2.TabIndex = 6;
            // 
            // txtEngOrd3
            // 
            this.txtEngOrd3.Location = new System.Drawing.Point(41, 130);
            this.txtEngOrd3.Name = "txtEngOrd3";
            this.txtEngOrd3.Size = new System.Drawing.Size(100, 20);
            this.txtEngOrd3.TabIndex = 7;
            // 
            // txtEngOrd4
            // 
            this.txtEngOrd4.Location = new System.Drawing.Point(41, 190);
            this.txtEngOrd4.Name = "txtEngOrd4";
            this.txtEngOrd4.Size = new System.Drawing.Size(100, 20);
            this.txtEngOrd4.TabIndex = 8;
            // 
            // txtEngOrd5
            // 
            this.txtEngOrd5.Location = new System.Drawing.Point(41, 256);
            this.txtEngOrd5.Name = "txtEngOrd5";
            this.txtEngOrd5.Size = new System.Drawing.Size(100, 20);
            this.txtEngOrd5.TabIndex = 9;
            // 
            // lblItemTag
            // 
            this.lblItemTag.AutoSize = true;
            this.lblItemTag.Location = new System.Drawing.Point(44, 183);
            this.lblItemTag.Name = "lblItemTag";
            this.lblItemTag.Size = new System.Drawing.Size(27, 13);
            this.lblItemTag.TabIndex = 20;
            this.lblItemTag.Text = "Item";
            // 
            // lblEngravingTag
            // 
            this.lblEngravingTag.AutoSize = true;
            this.lblEngravingTag.Location = new System.Drawing.Point(358, 186);
            this.lblEngravingTag.Name = "lblEngravingTag";
            this.lblEngravingTag.Size = new System.Drawing.Size(55, 13);
            this.lblEngravingTag.TabIndex = 21;
            this.lblEngravingTag.Text = "Engraving";
            // 
            // lblQuantityTag
            // 
            this.lblQuantityTag.AutoSize = true;
            this.lblQuantityTag.Location = new System.Drawing.Point(693, 182);
            this.lblQuantityTag.Name = "lblQuantityTag";
            this.lblQuantityTag.Size = new System.Drawing.Size(46, 13);
            this.lblQuantityTag.TabIndex = 22;
            this.lblQuantityTag.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Unit Cost";
            // 
            // lblCostItm1
            // 
            this.lblCostItm1.AutoSize = true;
            this.lblCostItm1.Location = new System.Drawing.Point(188, 19);
            this.lblCostItm1.Name = "lblCostItm1";
            this.lblCostItm1.Size = new System.Drawing.Size(35, 13);
            this.lblCostItm1.TabIndex = 10;
            this.lblCostItm1.Text = "label2";
            // 
            // lblCostItm2
            // 
            this.lblCostItm2.AutoSize = true;
            this.lblCostItm2.Location = new System.Drawing.Point(188, 82);
            this.lblCostItm2.Name = "lblCostItm2";
            this.lblCostItm2.Size = new System.Drawing.Size(35, 13);
            this.lblCostItm2.TabIndex = 11;
            this.lblCostItm2.Text = "label3";
            // 
            // lblCostItm3
            // 
            this.lblCostItm3.AutoSize = true;
            this.lblCostItm3.Location = new System.Drawing.Point(188, 137);
            this.lblCostItm3.Name = "lblCostItm3";
            this.lblCostItm3.Size = new System.Drawing.Size(35, 13);
            this.lblCostItm3.TabIndex = 12;
            this.lblCostItm3.Text = "label4";
            // 
            // lblCostItm4
            // 
            this.lblCostItm4.AutoSize = true;
            this.lblCostItm4.Location = new System.Drawing.Point(188, 197);
            this.lblCostItm4.Name = "lblCostItm4";
            this.lblCostItm4.Size = new System.Drawing.Size(35, 13);
            this.lblCostItm4.TabIndex = 13;
            this.lblCostItm4.Text = "label5";
            // 
            // lblCostItm5
            // 
            this.lblCostItm5.AutoSize = true;
            this.lblCostItm5.Location = new System.Drawing.Point(188, 259);
            this.lblCostItm5.Name = "lblCostItm5";
            this.lblCostItm5.Size = new System.Drawing.Size(35, 13);
            this.lblCostItm5.TabIndex = 14;
            this.lblCostItm5.Text = "label6";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(167, 348);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(103, 13);
            this.lblTotalCost.TabIndex = 15;
            this.lblTotalCost.Text = "Calculated Unit Cost";
            // 
            // lblTotalCst
            // 
            this.lblTotalCst.AutoSize = true;
            this.lblTotalCst.Location = new System.Drawing.Point(107, 348);
            this.lblTotalCst.Name = "lblTotalCst";
            this.lblTotalCst.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCst.TabIndex = 16;
            this.lblTotalCst.Text = "Total Cost";
            // 
            // lblTotQuantity
            // 
            this.lblTotQuantity.AutoSize = true;
            this.lblTotQuantity.Location = new System.Drawing.Point(331, 348);
            this.lblTotQuantity.Name = "lblTotQuantity";
            this.lblTotQuantity.Size = new System.Drawing.Size(73, 13);
            this.lblTotQuantity.TabIndex = 17;
            this.lblTotQuantity.Text = "Total Quantity";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Location = new System.Drawing.Point(410, 348);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(99, 13);
            this.lblTotalQuantity.TabIndex = 18;
            this.lblTotalQuantity.Text = "Calculated Quantity";
            // 
            // New_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuantityTag);
            this.Controls.Add(this.lblEngravingTag);
            this.Controls.Add(this.lblItemTag);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblOrdStat);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblSysDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rdbEngrave);
            this.Controls.Add(this.rdbPrint);
            this.Controls.Add(this.lblOrdType);
            this.Controls.Add(this.lblAutoGenOrdNum);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.lblSalesId);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.lblSalesPerson);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lbl1);
            this.Name = "lblOrdNum";
            this.Text = "New_Order";
            this.Load += new System.EventHandler(this.New_Order_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblSalesPerson;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblSalesId;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblAutoGenOrdNum;
        private System.Windows.Forms.TextBox lblOrdType;
        private System.Windows.Forms.RadioButton rdbPrint;
        private System.Windows.Forms.RadioButton rdbEngrave;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSysDate;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblOrdStat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbItem5;
        private System.Windows.Forms.ComboBox cmbItem4;
        private System.Windows.Forms.ComboBox cmbItem3;
        private System.Windows.Forms.ComboBox cmbItem2;
        private System.Windows.Forms.ComboBox cmbItem1;
        private System.Windows.Forms.NumericUpDown numItem5;
        private System.Windows.Forms.NumericUpDown numItem4;
        private System.Windows.Forms.NumericUpDown numItem3;
        private System.Windows.Forms.NumericUpDown numItem2;
        private System.Windows.Forms.NumericUpDown numItem1;
        private System.Windows.Forms.TextBox txtEngOrd5;
        private System.Windows.Forms.TextBox txtEngOrd4;
        private System.Windows.Forms.TextBox txtEngOrd3;
        private System.Windows.Forms.TextBox txtEngOrd2;
        private System.Windows.Forms.TextBox txtEngOrd1;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.Label lblItemTag;
        private System.Windows.Forms.Label lblEngravingTag;
        private System.Windows.Forms.Label lblQuantityTag;
        private System.Windows.Forms.Label lblCostItm5;
        private System.Windows.Forms.Label lblCostItm4;
        private System.Windows.Forms.Label lblCostItm3;
        private System.Windows.Forms.Label lblCostItm2;
        private System.Windows.Forms.Label lblCostItm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCst;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label lblTotQuantity;
    }
}