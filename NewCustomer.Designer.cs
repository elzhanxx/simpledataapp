namespace SimpleDataApp
{
    partial class NewCustomer
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddAnotherAccount = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(293, 78);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(128, 23);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(346, 107);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(75, 23);
            this.txtCustomerID.TabIndex = 1;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавление учетной записи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя заказчика:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Идентификатор клиента:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(450, 125);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(151, 23);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Создать учетную запись";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Создание заказа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сумма заказа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Дата заказа:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(482, 257);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(119, 23);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "Разместить заказ";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnAddAnotherAccount
            // 
            this.btnAddAnotherAccount.Location = new System.Drawing.Point(391, 321);
            this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Size = new System.Drawing.Size(210, 23);
            this.btnAddAnotherAccount.TabIndex = 10;
            this.btnAddAnotherAccount.Text = "Добавить другую учетную запись";
            this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
            this.btnAddAnotherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Location = new System.Drawing.Point(226, 321);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(104, 23);
            this.btnAddFinish.TabIndex = 11;
            this.btnAddFinish.Text = "Готово";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(331, 220);
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numOrderAmount.Size = new System.Drawing.Size(120, 23);
            this.numOrderAmount.TabIndex = 12;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "DD.MM.YYYY";
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(331, 249);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(120, 23);
            this.dtpOrderDate.TabIndex = 13;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.numOrderAmount);
            this.Controls.Add(this.btnAddFinish);
            this.Controls.Add(this.btnAddAnotherAccount);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "NewCustomer";
            this.Text = "Новая учетная запись и заказ";
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCustomerName;
        private TextBox txtCustomerID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCreateAccount;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnPlaceOrder;
        private Button btnAddAnotherAccount;
        private Button btnAddFinish;
        private NumericUpDown numOrderAmount;
        private DateTimePicker dtpOrderDate;
    }
}