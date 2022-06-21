using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmUpdateCustomer : Form
    {
        CustomerManagement customerManagement = new CustomerManagement();

        private readonly FrmFoodManagement frmFoodManagement1;

        public FrmUpdateCustomer(FrmFoodManagement frmFoodManagement)
        {
            InitializeComponent();
            frmFoodManagement1 = frmFoodManagement;
        }
        private void FrmUpdateCustomer_Load(object sender, EventArgs e)
        {
            loadCustomerDetail();
        }
        private void loadCustomerDetail()
        {
            SqlDataReader drCustomer = customerManagement.getDatails(FrmFoodManagement.customerId.ToString());
            if (drCustomer.Read())
            {
                txt_CustomerName.Text = drCustomer.GetString(1);
                txt_CustomerAddress.Text = drCustomer.GetString(2);
                txt_CustomerPhoneNumber.Text = drCustomer.GetString(3);
                txt_CustomerEmail.Text = drCustomer.GetString(4);
                txt_CustomerMoreInfo.Text = drCustomer.GetString(5);
                dt_CustomerContactDate.Value = drCustomer.GetDateTime(6);
            }
            customerManagement.closeConnection();
        }
        private void btn_CustomerSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerId = FrmFoodManagement.customerId,
                DisplayNameCustomer = txt_CustomerName.Text.Trim(),
                Address = txt_CustomerAddress.Text.Trim(),
                Phone = txt_CustomerPhoneNumber.Text.Trim(),
                Email = txt_CustomerEmail.Text.Trim(),
                MoreInfo = txt_CustomerMoreInfo.Text.Trim(),
                ContractDate = dt_CustomerContactDate.Value
            };
            // 
            int result = customerManagement.UpdateCustomer(customer);
            if (result < 0)
            {
                Status.Text = "Save error!!!";
            }
            else
            {
                Status.Text = "Create successfully !!!";
            }
            frmFoodManagement1.loadCustomerData();
        }

        private void btn_CloseFrm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
