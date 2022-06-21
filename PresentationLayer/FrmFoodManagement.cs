using BussinessLogicLayer_BLL;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmFoodManagement : Form
    {

        FoodManagement foodManagement = new FoodManagement();
        CustomerManagement customerManagement = new CustomerManagement();
        OutputInfoManagement outputInfoManagement = new OutputInfoManagement();

        BindingSource bs;
        BindingSource bindingCustomerData = new BindingSource();
        BindingSource bindingOutputInfoData = new BindingSource();

        //Init variable
        public static int customerId;
        public static int outputinfoId;

        public FrmFoodManagement()
        {
            InitializeComponent();
        }

        private void FrmFoodManagement_Load(object sender, EventArgs e)
        {
            loadFoodData();
            loadCustomerData();
        }
        private void loadFoodData()
        {
            DataSet ds = foodManagement.ViewFoods();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_Food.DataSource = bs;
        }


        private void txt_idfood_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_idfood.Text))
            {
                errorProvider1.SetError(txt_idfood, "ID is not left blank!");
            }
            else if (foodManagement.isExistIdFood(txt_idfood.Text))
            {
                errorProvider1.SetError(txt_idfood, "ID existed!!!");
            }
            else
            {
                errorProvider1.SetError(txt_idfood, null);
                e.Cancel = false;
            }
        }

        private void txt_namefood_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_namefood.Text))
            {
                errorProvider1.SetError(txt_namefood, "Name Food is not left blank!");
            }
            else
            {
                errorProvider1.SetError(txt_namefood, null);
                e.Cancel = false;
            }
        }

        private void txt_quantity_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_quantity.Text))
            {
                errorProvider1.SetError(txt_quantity, "Quantity is not left blank!");
            }
            else
            {
                errorProvider1.SetError(txt_quantity, null);
                e.Cancel = false;
            }
        }
        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txt_idsuplier_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_idsuplier.Text))
            {
                errorProvider1.SetError(txt_idsuplier, "ID Suplier is not left blank!");
            }
            else
            {
                errorProvider1.SetError(txt_idsuplier, null);
                e.Cancel = false;
            }
        }
        private void txt_idsuplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        //Tabs Suplier
        private void btn_AddSuplier_Click(object sender, EventArgs e)
        {
            FrmSuplierDetail frmAddSuplier = new FrmSuplierDetail();
            frmAddSuplier.Show();
        }


        //Tabs Customer
        public void loadCustomerData()
        {
            DataSet ds = customerManagement.ViewCustomers();
            bindingCustomerData.DataSource = ds.Tables[0];
            gv_CustomerDataSource.DataSource = bindingCustomerData;
        }

        private void loadOutputInfoDataCustomerTabs()
        {
            BindingSource bindingSource = new BindingSource();
            DataSet dsOutputInfo = outputInfoManagement.listOutputInfoById(customerId);
            bindingSource.DataSource = dsOutputInfo.Tables[0];
            gv_CustomerTabsOutputInfoData.DataSource = bindingSource;
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer(this);
            frmAddCustomer.Show();
        }

        private void gv_CustomerDataSource_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_CustomerDataSource.SelectedRows.Count > 0)
            {
                customerId = int.Parse(gv_CustomerDataSource.SelectedRows[0].Cells["CustomerId"].Value.ToString());

                loadOutputInfoDataCustomerTabs();
            }
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            FrmUpdateCustomer frmUpdateSuplier = new FrmUpdateCustomer(this);
            frmUpdateSuplier.Show();
        }

        private void lbl_searchCustomer_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_searchCustomer.Text.Trim() == "")
            {
                ds = customerManagement.searchByName(txt_searchCustomer.Text);
            }
            else
            {
                ds = customerManagement.searchByName(txt_searchCustomer.Text);
            }

            bindingCustomerData.DataSource = ds.Tables[0];
            gv_CustomerDataSource.DataSource = bindingCustomerData;
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            int result = customerManagement.RemoveCustomer(customerId);
            if (result < 0)
            {
                Status.Text = "Customers have inventory!!!";
            }
            else
            {
                Status.Text = "Delete done !!!";
            }
            loadCustomerData();
        }

    }
}
