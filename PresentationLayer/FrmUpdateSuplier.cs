using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmUpdateSuplier : Form
    {

        SupilerManagement supilerManagement = new SupilerManagement();

        private readonly FrmFoodManagement frmFoodManagement1;


        public FrmUpdateSuplier(FrmFoodManagement frmFoodManagement)
        {
            InitializeComponent();
            frmFoodManagement1 = frmFoodManagement;

        }

        private void FrmUpdateSuplier_Load(object sender, EventArgs e)
        {
            loadSuplierDetail();
        }

        private void loadSuplierDetail()
        {
            SqlDataReader drSuplier = supilerManagement.getDatails(FrmFoodManagement.suplierId.ToString());
            if (drSuplier.Read())
            {
                txt_SuplierName.Text = drSuplier.GetString(1);
                txt_SuplierAddress.Text = drSuplier.GetString(2);
                txt_SuplierPhoneNumber.Text = drSuplier.GetString(3);
                txt_SuplierEmail.Text = drSuplier.GetString(4);
                txt_SuplierMoreInfo.Text = drSuplier.GetString(5);
                dt_ContactDate.Value = drSuplier.GetDateTime(6);
            }
            supilerManagement.closeConnection();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Suplier newSuplier = new Suplier()
            {
                Id = FrmFoodManagement.suplierId,
                DisplayName = txt_SuplierName.Text.Trim(),
                Address = txt_SuplierAddress.Text.Trim(),
                Phone = txt_SuplierPhoneNumber.Text.Trim(),
                Email = txt_SuplierEmail.Text.Trim(),
                MoreInfo = txt_SuplierMoreInfo.Text.Trim(),
                ContractDate = dt_ContactDate.Value
            };
            int result = supilerManagement.UpdateSuplier(newSuplier);
            if (result < 0)
            {
                statusNotification.Text = "Fail!";
            }
            else
            {
                frmFoodManagement1.loadSuplierData();
                statusNotification.Text = "Successfully!";
            }
        }
    }
}
