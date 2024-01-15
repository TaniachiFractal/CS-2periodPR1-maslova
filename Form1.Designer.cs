
namespace _2semPR1_maslova
{
    partial class ShopForm
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbName_ComboB = new System.Windows.Forms.ComboBox();
            this.tbCount_NumUD = new System.Windows.Forms.NumericUpDown();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbReceipt = new System.Windows.Forms.GroupBox();
            this.tbReceipt = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.gbFinal = new System.Windows.Forms.GroupBox();
            this.tbToPay = new System.Windows.Forms.TextBox();
            this.lbToPay = new System.Windows.Forms.Label();
            this.tbSumDiscount = new System.Windows.Forms.TextBox();
            this.lbSumDiscount = new System.Windows.Forms.Label();
            this.tbSumProduct = new System.Windows.Forms.TextBox();
            this.lbSumProduct = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount_NumUD)).BeginInit();
            this.gbReceipt.SuspendLayout();
            this.gbFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Beige;
            this.gbInfo.Controls.Add(this.tbName_ComboB);
            this.gbInfo.Controls.Add(this.tbCount_NumUD);
            this.gbInfo.Controls.Add(this.tbDiscount);
            this.gbInfo.Controls.Add(this.lbDiscount);
            this.gbInfo.Controls.Add(this.lbCount);
            this.gbInfo.Controls.Add(this.tbPrice);
            this.gbInfo.Controls.Add(this.lbPrice);
            this.gbInfo.Controls.Add(this.lbName);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(426, 208);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Сведения о товаре";
            // 
            // tbName_ComboB
            // 
            this.tbName_ComboB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbName_ComboB.FormattingEnabled = true;
            this.tbName_ComboB.Location = new System.Drawing.Point(136, 34);
            this.tbName_ComboB.MaxDropDownItems = 5;
            this.tbName_ComboB.Name = "tbName_ComboB";
            this.tbName_ComboB.Size = new System.Drawing.Size(272, 33);
            this.tbName_ComboB.Sorted = true;
            this.tbName_ComboB.TabIndex = 5;
            // 
            // tbCount_NumUD
            // 
            this.tbCount_NumUD.Location = new System.Drawing.Point(232, 113);
            this.tbCount_NumUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.tbCount_NumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbCount_NumUD.Name = "tbCount_NumUD";
            this.tbCount_NumUD.Size = new System.Drawing.Size(176, 33);
            this.tbCount_NumUD.TabIndex = 8;
            this.tbCount_NumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbCount_NumUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCount_NumUD_KeyPress);
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(232, 152);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(176, 33);
            this.tbDiscount.TabIndex = 7;
            this.tbDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbDiscount_KeyPress);
            this.tbDiscount.Leave += new System.EventHandler(this.TbDiscount_Leave);
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(19, 155);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(89, 25);
            this.lbDiscount.TabIndex = 6;
            this.lbDiscount.Text = "Скидка%:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(19, 116);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(113, 25);
            this.lbCount.TabIndex = 4;
            this.lbCount.Text = "Количество:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(232, 74);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(176, 33);
            this.tbPrice.TabIndex = 3;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPrice_KeyPress);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(19, 77);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 25);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Цена:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(19, 38);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(96, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Название:";
            // 
            // gbReceipt
            // 
            this.gbReceipt.BackColor = System.Drawing.Color.Beige;
            this.gbReceipt.Controls.Add(this.tbReceipt);
            this.gbReceipt.Location = new System.Drawing.Point(12, 231);
            this.gbReceipt.Name = "gbReceipt";
            this.gbReceipt.Size = new System.Drawing.Size(426, 346);
            this.gbReceipt.TabIndex = 1;
            this.gbReceipt.TabStop = false;
            this.gbReceipt.Text = "Чек";
            // 
            // tbReceipt
            // 
            this.tbReceipt.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReceipt.Location = new System.Drawing.Point(15, 32);
            this.tbReceipt.Multiline = true;
            this.tbReceipt.Name = "tbReceipt";
            this.tbReceipt.ReadOnly = true;
            this.tbReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbReceipt.Size = new System.Drawing.Size(393, 297);
            this.tbReceipt.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 585);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(426, 43);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Добавить товар в корзину";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btClear
            // 
            this.btClear.Enabled = false;
            this.btClear.Location = new System.Drawing.Point(12, 634);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(211, 43);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Очистить корзину";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(229, 634);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(209, 43);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // gbFinal
            // 
            this.gbFinal.BackColor = System.Drawing.Color.Beige;
            this.gbFinal.Controls.Add(this.tbToPay);
            this.gbFinal.Controls.Add(this.lbToPay);
            this.gbFinal.Controls.Add(this.tbSumDiscount);
            this.gbFinal.Controls.Add(this.lbSumDiscount);
            this.gbFinal.Controls.Add(this.tbSumProduct);
            this.gbFinal.Controls.Add(this.lbSumProduct);
            this.gbFinal.Location = new System.Drawing.Point(12, 685);
            this.gbFinal.Name = "gbFinal";
            this.gbFinal.Size = new System.Drawing.Size(426, 175);
            this.gbFinal.TabIndex = 2;
            this.gbFinal.TabStop = false;
            this.gbFinal.Text = "Итог";
            // 
            // tbToPay
            // 
            this.tbToPay.Location = new System.Drawing.Point(232, 120);
            this.tbToPay.Name = "tbToPay";
            this.tbToPay.ReadOnly = true;
            this.tbToPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbToPay.Size = new System.Drawing.Size(176, 33);
            this.tbToPay.TabIndex = 14;
            // 
            // lbToPay
            // 
            this.lbToPay.AutoSize = true;
            this.lbToPay.Location = new System.Drawing.Point(19, 123);
            this.lbToPay.Name = "lbToPay";
            this.lbToPay.Size = new System.Drawing.Size(89, 25);
            this.lbToPay.TabIndex = 13;
            this.lbToPay.Text = "К оплате:";
            // 
            // tbSumDiscount
            // 
            this.tbSumDiscount.Location = new System.Drawing.Point(232, 75);
            this.tbSumDiscount.Name = "tbSumDiscount";
            this.tbSumDiscount.ReadOnly = true;
            this.tbSumDiscount.Size = new System.Drawing.Size(176, 33);
            this.tbSumDiscount.TabIndex = 12;
            // 
            // lbSumDiscount
            // 
            this.lbSumDiscount.AutoSize = true;
            this.lbSumDiscount.Location = new System.Drawing.Point(19, 78);
            this.lbSumDiscount.Name = "lbSumDiscount";
            this.lbSumDiscount.Size = new System.Drawing.Size(131, 25);
            this.lbSumDiscount.TabIndex = 11;
            this.lbSumDiscount.Text = "Сумма скидок:";
            // 
            // tbSumProduct
            // 
            this.tbSumProduct.Location = new System.Drawing.Point(232, 32);
            this.tbSumProduct.Name = "tbSumProduct";
            this.tbSumProduct.ReadOnly = true;
            this.tbSumProduct.Size = new System.Drawing.Size(176, 33);
            this.tbSumProduct.TabIndex = 10;
            // 
            // lbSumProduct
            // 
            this.lbSumProduct.AutoSize = true;
            this.lbSumProduct.Location = new System.Drawing.Point(19, 35);
            this.lbSumProduct.Name = "lbSumProduct";
            this.lbSumProduct.Size = new System.Drawing.Size(194, 25);
            this.lbSumProduct.TabIndex = 9;
            this.lbSumProduct.Text = "Сумма покупок с НДС:";
            // 
            // ShopForm
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(451, 873);
            this.Controls.Add(this.gbFinal);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.gbReceipt);
            this.Controls.Add(this.gbInfo);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ShopForm";
            this.Text = "Консоль продавца";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopForm_FormClosing);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount_NumUD)).EndInit();
            this.gbReceipt.ResumeLayout(false);
            this.gbReceipt.PerformLayout();
            this.gbFinal.ResumeLayout(false);
            this.gbFinal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbReceipt;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox gbFinal;
        private System.Windows.Forms.NumericUpDown tbCount_NumUD;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbReceipt;
        private System.Windows.Forms.TextBox tbToPay;
        private System.Windows.Forms.Label lbToPay;
        private System.Windows.Forms.TextBox tbSumDiscount;
        private System.Windows.Forms.Label lbSumDiscount;
        private System.Windows.Forms.TextBox tbSumProduct;
        private System.Windows.Forms.Label lbSumProduct;
        private System.Windows.Forms.ComboBox tbName_ComboB;
    }
}

