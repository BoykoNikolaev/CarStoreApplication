
namespace CarShopGUI
{
    partial class CarStoreForm
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
            this.CreateACarGroupBox = new System.Windows.Forms.GroupBox();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.CarInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.ShoppingCartGroupBox = new System.Windows.Forms.GroupBox();
            this.btn_create_car = new System.Windows.Forms.Button();
            this.lst_inventory = new System.Windows.Forms.ListBox();
            this.lst_cart = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.CreateACarGroupBox.SuspendLayout();
            this.CarInventoryGroupBox.SuspendLayout();
            this.ShoppingCartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateACarGroupBox
            // 
            this.CreateACarGroupBox.Controls.Add(this.txt_price);
            this.CreateACarGroupBox.Controls.Add(this.txt_model);
            this.CreateACarGroupBox.Controls.Add(this.txt_make);
            this.CreateACarGroupBox.Controls.Add(this.PriceLabel);
            this.CreateACarGroupBox.Controls.Add(this.ModelLabel);
            this.CreateACarGroupBox.Controls.Add(this.MakeLabel);
            this.CreateACarGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateACarGroupBox.Location = new System.Drawing.Point(55, 65);
            this.CreateACarGroupBox.Name = "CreateACarGroupBox";
            this.CreateACarGroupBox.Size = new System.Drawing.Size(262, 176);
            this.CreateACarGroupBox.TabIndex = 0;
            this.CreateACarGroupBox.TabStop = false;
            this.CreateACarGroupBox.Text = "Create a car";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeLabel.Location = new System.Drawing.Point(6, 37);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(54, 20);
            this.MakeLabel.TabIndex = 1;
            this.MakeLabel.Text = "Make:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(6, 80);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(59, 20);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Model:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(6, 125);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(53, 20);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price:";
            // 
            // txt_make
            // 
            this.txt_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_make.Location = new System.Drawing.Point(76, 37);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(180, 26);
            this.txt_make.TabIndex = 4;
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model.Location = new System.Drawing.Point(76, 80);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(180, 26);
            this.txt_model.TabIndex = 5;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(76, 125);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(180, 26);
            this.txt_price.TabIndex = 6;
            // 
            // CarInventoryGroupBox
            // 
            this.CarInventoryGroupBox.Controls.Add(this.lst_inventory);
            this.CarInventoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarInventoryGroupBox.Location = new System.Drawing.Point(345, 65);
            this.CarInventoryGroupBox.Name = "CarInventoryGroupBox";
            this.CarInventoryGroupBox.Size = new System.Drawing.Size(245, 474);
            this.CarInventoryGroupBox.TabIndex = 1;
            this.CarInventoryGroupBox.TabStop = false;
            this.CarInventoryGroupBox.Text = "Car inventory";
            // 
            // ShoppingCartGroupBox
            // 
            this.ShoppingCartGroupBox.Controls.Add(this.lst_cart);
            this.ShoppingCartGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartGroupBox.Location = new System.Drawing.Point(819, 65);
            this.ShoppingCartGroupBox.Name = "ShoppingCartGroupBox";
            this.ShoppingCartGroupBox.Size = new System.Drawing.Size(245, 368);
            this.ShoppingCartGroupBox.TabIndex = 2;
            this.ShoppingCartGroupBox.TabStop = false;
            this.ShoppingCartGroupBox.Text = "Shopping cart";
            // 
            // btn_create_car
            // 
            this.btn_create_car.Location = new System.Drawing.Point(131, 247);
            this.btn_create_car.Name = "btn_create_car";
            this.btn_create_car.Size = new System.Drawing.Size(105, 32);
            this.btn_create_car.TabIndex = 3;
            this.btn_create_car.Text = "Create a car";
            this.btn_create_car.UseVisualStyleBackColor = true;
            this.btn_create_car.Click += new System.EventHandler(this.btn_create_car_Click);
            // 
            // lst_inventory
            // 
            this.lst_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_inventory.FormattingEnabled = true;
            this.lst_inventory.ItemHeight = 20;
            this.lst_inventory.Location = new System.Drawing.Point(6, 37);
            this.lst_inventory.Name = "lst_inventory";
            this.lst_inventory.Size = new System.Drawing.Size(233, 424);
            this.lst_inventory.TabIndex = 0;
            // 
            // lst_cart
            // 
            this.lst_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_cart.FormattingEnabled = true;
            this.lst_cart.ItemHeight = 20;
            this.lst_cart.Location = new System.Drawing.Point(6, 37);
            this.lst_cart.Name = "lst_cart";
            this.lst_cart.Size = new System.Drawing.Size(233, 324);
            this.lst_cart.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(613, 247);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(184, 32);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add to shopping cart";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(904, 451);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(105, 32);
            this.btn_checkout.TabIndex = 5;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(750, 519);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(88, 20);
            this.TotalCostLabel.TabIndex = 6;
            this.TotalCostLabel.Text = "Total cost:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(844, 519);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(49, 20);
            this.lbl_total.TabIndex = 7;
            this.lbl_total.Text = "$0.00";
            // 
            // CarStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 561);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_create_car);
            this.Controls.Add(this.ShoppingCartGroupBox);
            this.Controls.Add(this.CarInventoryGroupBox);
            this.Controls.Add(this.CreateACarGroupBox);
            this.Name = "CarStoreForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CarStoreForm_Load);
            this.CreateACarGroupBox.ResumeLayout(false);
            this.CreateACarGroupBox.PerformLayout();
            this.CarInventoryGroupBox.ResumeLayout(false);
            this.ShoppingCartGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateACarGroupBox;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.GroupBox CarInventoryGroupBox;
        private System.Windows.Forms.GroupBox ShoppingCartGroupBox;
        private System.Windows.Forms.ListBox lst_inventory;
        private System.Windows.Forms.ListBox lst_cart;
        private System.Windows.Forms.Button btn_create_car;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label lbl_total;
    }
}

