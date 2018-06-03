namespace Sklad
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStock = new System.Windows.Forms.ListBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCM = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbML = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbManf = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbMinLot = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPriceList = new System.Windows.Forms.Button();
            this.btnStockList = new System.Windows.Forms.Button();
            this.btnLotInfo = new System.Windows.Forms.Button();
            this.tbStNum = new System.Windows.Forms.TextBox();
            this.lbStNum = new System.Windows.Forms.Label();
            this.btnStDelete = new System.Windows.Forms.Button();
            this.btnStInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbStock
            // 
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbStock.FormattingEnabled = true;
            this.lbStock.HorizontalScrollbar = true;
            this.lbStock.ItemHeight = 20;
            this.lbStock.Location = new System.Drawing.Point(2, 36);
            this.lbStock.Margin = new System.Windows.Forms.Padding(1);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(749, 264);
            this.lbStock.TabIndex = 2;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbProductName.Location = new System.Drawing.Point(-2, 9);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(110, 20);
            this.lbProductName.TabIndex = 3;
            this.lbProductName.Text = "Product Name";
            this.lbProductName.MouseHover += new System.EventHandler(this.lbProductName_MouseHover);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPrice.Location = new System.Drawing.Point(289, 9);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(98, 20);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price for one";
            // 
            // lbCM
            // 
            this.lbCM.AutoSize = true;
            this.lbCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCM.Location = new System.Drawing.Point(146, 9);
            this.lbCM.Name = "lbCM";
            this.lbCM.Size = new System.Drawing.Size(104, 20);
            this.lbCM.TabIndex = 5;
            this.lbCM.Text = "Manufacturer";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbQuantity.Location = new System.Drawing.Point(435, 9);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(68, 20);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Quantity";
            this.lbQuantity.MouseHover += new System.EventHandler(this.lbQuantity_MouseHover);
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNum.Location = new System.Drawing.Point(545, 9);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(69, 20);
            this.lbNum.TabIndex = 7;
            this.lbNum.Text = "№ Stock";
            // 
            // lbML
            // 
            this.lbML.AutoSize = true;
            this.lbML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbML.Location = new System.Drawing.Point(652, 9);
            this.lbML.Name = "lbML";
            this.lbML.Size = new System.Drawing.Size(99, 20);
            this.lbML.TabIndex = 8;
            this.lbML.Text = "Minimum Lot";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbName.Location = new System.Drawing.Point(12, 316);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(106, 26);
            this.tbName.TabIndex = 9;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbManf
            // 
            this.tbManf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbManf.Location = new System.Drawing.Point(150, 316);
            this.tbManf.Name = "tbManf";
            this.tbManf.Size = new System.Drawing.Size(100, 26);
            this.tbManf.TabIndex = 10;
            this.tbManf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbManf_KeyPress);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPrice.Location = new System.Drawing.Point(293, 316);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(133, 26);
            this.tbPrice.TabIndex = 11;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbQuantity.Location = new System.Drawing.Point(452, 316);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(114, 26);
            this.tbQuantity.TabIndex = 12;
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            // 
            // tbStock
            // 
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbStock.Location = new System.Drawing.Point(581, 316);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(78, 26);
            this.tbStock.TabIndex = 13;
            // 
            // tbMinLot
            // 
            this.tbMinLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbMinLot.Location = new System.Drawing.Point(673, 316);
            this.tbMinLot.Name = "tbMinLot";
            this.tbMinLot.Size = new System.Drawing.Size(78, 26);
            this.tbMinLot.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(293, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPriceList
            // 
            this.btnPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPriceList.Location = new System.Drawing.Point(12, 366);
            this.btnPriceList.Name = "btnPriceList";
            this.btnPriceList.Size = new System.Drawing.Size(106, 29);
            this.btnPriceList.TabIndex = 16;
            this.btnPriceList.Text = "Price List";
            this.btnPriceList.UseVisualStyleBackColor = true;
            this.btnPriceList.Click += new System.EventHandler(this.btnPriceList_Click);
            // 
            // btnStockList
            // 
            this.btnStockList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStockList.Location = new System.Drawing.Point(150, 366);
            this.btnStockList.Name = "btnStockList";
            this.btnStockList.Size = new System.Drawing.Size(100, 29);
            this.btnStockList.TabIndex = 17;
            this.btnStockList.Text = "Stock List";
            this.btnStockList.UseVisualStyleBackColor = true;
            this.btnStockList.Click += new System.EventHandler(this.btnStockInfo_Click);
            // 
            // btnLotInfo
            // 
            this.btnLotInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLotInfo.Location = new System.Drawing.Point(452, 366);
            this.btnLotInfo.Name = "btnLotInfo";
            this.btnLotInfo.Size = new System.Drawing.Size(114, 29);
            this.btnLotInfo.TabIndex = 18;
            this.btnLotInfo.Text = "Min Lot Info";
            this.btnLotInfo.UseVisualStyleBackColor = true;
            this.btnLotInfo.Click += new System.EventHandler(this.btnLotInfo_Click);
            // 
            // tbStNum
            // 
            this.tbStNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbStNum.Location = new System.Drawing.Point(12, 487);
            this.tbStNum.Name = "tbStNum";
            this.tbStNum.Size = new System.Drawing.Size(106, 26);
            this.tbStNum.TabIndex = 19;
            // 
            // lbStNum
            // 
            this.lbStNum.AutoSize = true;
            this.lbStNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbStNum.Location = new System.Drawing.Point(21, 464);
            this.lbStNum.Name = "lbStNum";
            this.lbStNum.Size = new System.Drawing.Size(87, 20);
            this.lbStNum.TabIndex = 20;
            this.lbStNum.Text = "Stock Num";
            // 
            // btnStDelete
            // 
            this.btnStDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStDelete.Location = new System.Drawing.Point(150, 487);
            this.btnStDelete.Name = "btnStDelete";
            this.btnStDelete.Size = new System.Drawing.Size(117, 26);
            this.btnStDelete.TabIndex = 21;
            this.btnStDelete.Text = "Delete(Stock)";
            this.btnStDelete.UseVisualStyleBackColor = true;
            this.btnStDelete.Click += new System.EventHandler(this.btnStDelete_Click);
            // 
            // btnStInfo
            // 
            this.btnStInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStInfo.Location = new System.Drawing.Point(306, 487);
            this.btnStInfo.Name = "btnStInfo";
            this.btnStInfo.Size = new System.Drawing.Size(100, 26);
            this.btnStInfo.TabIndex = 22;
            this.btnStInfo.Text = "Stock Info";
            this.btnStInfo.UseVisualStyleBackColor = true;
            this.btnStInfo.Click += new System.EventHandler(this.btnStInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(410, 406);
            this.listBox1.Margin = new System.Windows.Forms.Padding(1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 184);
            this.listBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 600);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStInfo);
            this.Controls.Add(this.btnStDelete);
            this.Controls.Add(this.lbStNum);
            this.Controls.Add(this.tbStNum);
            this.Controls.Add(this.btnLotInfo);
            this.Controls.Add(this.btnStockList);
            this.Controls.Add(this.btnPriceList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMinLot);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbManf);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbML);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbCM);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbStock);
            this.Name = "Form1";
            this.Text = "Product-сountry deliver and warehouse storage selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStock;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbCM;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbML;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbManf;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbMinLot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPriceList;
        private System.Windows.Forms.Button btnStockList;
        private System.Windows.Forms.Button btnLotInfo;
        private System.Windows.Forms.TextBox tbStNum;
        private System.Windows.Forms.Label lbStNum;
        private System.Windows.Forms.Button btnStDelete;
        private System.Windows.Forms.Button btnStInfo;
        private System.Windows.Forms.ListBox listBox1;
    }
}

