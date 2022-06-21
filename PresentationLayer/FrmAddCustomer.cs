using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmAddCustomer : Form
    {
        CustomerManagement customerManagement = new CustomerManagement();
        private readonly FrmFoodManagement frmFoodManagement1;

        public FrmAddCustomer(FrmFoodManagement frmFoodManagement)
        {
            InitializeComponent();
            frmFoodManagement1 = frmFoodManagement;
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
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

        private void btn_CloseFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CustomerSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                DisplayNameCustomer = txt_CustomerName.Text,
                Address = txt_CustomerAddress.Text,
                Phone = txt_CustomerPhoneNumber.Text,
                Email = txt_CustomerEmail.Text,
                MoreInfo = txt_CustomerMoreInfo.Text,
                ContractDate = dt_CustomerContactDate.Value
            };
            // 
            int result = customerManagement.AddCustomer(customer);
            if (result < 0)
            {
                Status.Text = "Save error!!!";
            }
            else
            {

                Status.Text = "Create employee successfully !!!";
            }

            frmFoodManagement1.loadCustomerData();
        }


    }
}
