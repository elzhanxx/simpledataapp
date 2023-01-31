namespace SimpleDataApp
{
    partial class FillOrCancel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindByOrderID = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идентификатор заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "При заполнении заказа укажите дату заполнения";
            // 
            // btnFindByOrderID
            // 
            this.btnFindByOrderID.Location = new System.Drawing.Point(417, 39);
            this.btnFindByOrderID.Name = "btnFindByOrderID";
            this.btnFindByOrderID.Size = new System.Drawing.Size(97, 23);
            this.btnFindByOrderID.TabIndex = 2;
            this.btnFindByOrderID.Text = "Найти заказ";
            this.btnFindByOrderID.UseVisualStyleBackColor = true;
            this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(95, 357);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(108, 23);
            this.btnCancelOrder.TabIndex = 3;
            this.btnCancelOrder.Text = "Отменить заказ";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.Location = new System.Drawing.Point(209, 357);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(106, 23);
            this.btnFillOrder.TabIndex = 4;
            this.btnFillOrder.Text = "Заполнить заказ";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.Location = new System.Drawing.Point(452, 357);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(75, 23);
            this.btnFinishUpdates.TabIndex = 5;
            this.btnFinishUpdates.Text = "Готово";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(430, 117);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(97, 23);
            this.dtpFillDate.TabIndex = 6;
            this.dtpFillDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(95, 183);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.ReadOnly = true;
            this.dgvCustomerOrders.RowHeadersVisible = false;
            this.dgvCustomerOrders.RowTemplate.Height = 25;
            this.dgvCustomerOrders.Size = new System.Drawing.Size(432, 150);
            this.dgvCustomerOrders.TabIndex = 7;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(273, 39);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(126, 23);
            this.txtOrderID.TabIndex = 8;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.dgvCustomerOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnFindByOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FillOrCancel";
            this.Text = "Заполнение или отмена заказов";
            this.Load += new System.EventHandler(this.FillOrCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnFindByOrderID;
        private Button btnCancelOrder;
        private Button btnFillOrder;
        private Button btnFinishUpdates;
        private DateTimePicker dtpFillDate;
        private DataGridView dgvCustomerOrders;
        private TextBox txtOrderID;
    }
}