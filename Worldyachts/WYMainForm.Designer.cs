namespace Worldyachts
{
    partial class WYMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aListOfEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yachtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersByEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesByGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.yachtsToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.realizationToolStripMenuItem,
            this.toPrintToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.aListOfEmployeesToolStripMenuItem,
            this.specializationToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.staffToolStripMenuItem.Text = "Персонал";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.employeeToolStripMenuItem.Text = "Сотрудник";
            // 
            // aListOfEmployeesToolStripMenuItem
            // 
            this.aListOfEmployeesToolStripMenuItem.Name = "aListOfEmployeesToolStripMenuItem";
            this.aListOfEmployeesToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.aListOfEmployeesToolStripMenuItem.Text = "Список сотрудников";
            // 
            // specializationToolStripMenuItem
            // 
            this.specializationToolStripMenuItem.Name = "specializationToolStripMenuItem";
            this.specializationToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.specializationToolStripMenuItem.Text = "Специализация";
            // 
            // yachtsToolStripMenuItem
            // 
            this.yachtsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.productTypeToolStripMenuItem});
            this.yachtsToolStripMenuItem.Name = "yachtsToolStripMenuItem";
            this.yachtsToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.yachtsToolStripMenuItem.Text = "Яхты";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.productToolStripMenuItem.Text = "Продукт";
            // 
            // productTypeToolStripMenuItem
            // 
            this.productTypeToolStripMenuItem.Name = "productTypeToolStripMenuItem";
            this.productTypeToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.productTypeToolStripMenuItem.Text = "Вид продукции";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.viewOrdersToolStripMenuItem,
            this.ordersByEmployeeToolStripMenuItem});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.bookingToolStripMenuItem.Text = "Бронирование";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.newOrderToolStripMenuItem.Text = "Новый заказ";
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            this.viewOrdersToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.viewOrdersToolStripMenuItem.Text = "Просмотр заказов";
            // 
            // ordersByEmployeeToolStripMenuItem
            // 
            this.ordersByEmployeeToolStripMenuItem.Name = "ordersByEmployeeToolStripMenuItem";
            this.ordersByEmployeeToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.ordersByEmployeeToolStripMenuItem.Text = "Заказы по сотрудникам";
            // 
            // realizationToolStripMenuItem
            // 
            this.realizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSaleToolStripMenuItem,
            this.salesByGoodsToolStripMenuItem});
            this.realizationToolStripMenuItem.Name = "realizationToolStripMenuItem";
            this.realizationToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.realizationToolStripMenuItem.Text = "Реализация";
            // 
            // toPrintToolStripMenuItem
            // 
            this.toPrintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceListToolStripMenuItem,
            this.orderCostToolStripMenuItem});
            this.toPrintToolStripMenuItem.Name = "toPrintToolStripMenuItem";
            this.toPrintToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.toPrintToolStripMenuItem.Text = "На печать";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // addSaleToolStripMenuItem
            // 
            this.addSaleToolStripMenuItem.Name = "addSaleToolStripMenuItem";
            this.addSaleToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.addSaleToolStripMenuItem.Text = "Добавить продажу";
            // 
            // salesByGoodsToolStripMenuItem
            // 
            this.salesByGoodsToolStripMenuItem.Name = "salesByGoodsToolStripMenuItem";
            this.salesByGoodsToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.salesByGoodsToolStripMenuItem.Text = "Продажи по товарам";
            // 
            // priceListToolStripMenuItem
            // 
            this.priceListToolStripMenuItem.Name = "priceListToolStripMenuItem";
            this.priceListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.priceListToolStripMenuItem.Text = "Прайс-лист";
            // 
            // orderCostToolStripMenuItem
            // 
            this.orderCostToolStripMenuItem.Name = "orderCostToolStripMenuItem";
            this.orderCostToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.orderCostToolStripMenuItem.Text = "Стоимость заказа";
            // 
            // WYMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WYMainForm";
            this.Text = "Worldyachts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aListOfEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yachtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toPrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersByEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesByGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderCostToolStripMenuItem;
    }
}

