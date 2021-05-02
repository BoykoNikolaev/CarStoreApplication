using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class CarStoreForm : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource shoppingCartBindingSource = new BindingSource();
        

        public CarStoreForm()
        {
            InitializeComponent();
        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            decimal test = 0.0M;
            if(decimal.TryParse(txt_price.Text, out test))
            {
                Car newCar = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
                myStore.CarList.Add(newCar);
                carInventoryBindingSource.ResetBindings(false);
                txt_make.Text = "";
                txt_model.Text = "";
                txt_price.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Car selected = (Car)lst_inventory.SelectedItem;
            myStore.ShoppingCart.Add(selected);
            shoppingCartBindingSource.ResetBindings(false);
            UpdateTotalCost();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"You successfully paid {myStore.Total()} for {myStore.ShoppingCart.Count()} cars!"
                );
            UpdateTotalCost();
            myStore.CheckOut();
            shoppingCartBindingSource.ResetBindings(false);
        }

        private void CarStoreForm_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;
            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            shoppingCartBindingSource.DataSource = myStore.ShoppingCart;
            lst_cart.DataSource = shoppingCartBindingSource;
            lst_cart.DisplayMember = ToString();

        }
        private void UpdateTotalCost()
        {
            lbl_total.Text = myStore.Total().ToString();
        }
    }
}
