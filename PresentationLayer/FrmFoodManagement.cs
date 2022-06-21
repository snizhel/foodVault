using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;

namespace PresentationLayer
{
    public partial class FrmFoodManagement : Form
    {
        SupilerManagement supilerManagement = new SupilerManagement();
        FoodManagement foodManagement = new FoodManagement();


        BindingSource bs;
        BindingSource bindingSuplierData = new BindingSource();


        //Init variable
        public static int suplierId;


        public FrmFoodManagement()
        {
            InitializeComponent();
        }

        private void FrmFoodManagement_Load(object sender, EventArgs e)
        {
            loadFoodData();
            loadSuplierData();
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

        public void loadSuplierData()
        {
            DataSet ds = supilerManagement.ViewSupilers();
            bindingSuplierData.DataSource = ds.Tables[0];
            gv_SuplierDataSource.DataSource = bindingSuplierData;
        }

        private void loadFoodDataSuplierTabs()
        {
            BindingSource bindingSource = new BindingSource();
            DataSet dsFood = foodManagement.listFoodById(suplierId);
            bindingSource.DataSource = dsFood.Tables[0];
            gv_SuplierTabsFoodData.DataSource = bindingSource;
        }


        private void btn_AddSuplier_Click(object sender, EventArgs e)
        {
            FrmAddSuplier frmAddSuplier = new FrmAddSuplier(this);
            frmAddSuplier.Show();
        }

        private void gv_SuplierDataSource_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_SuplierDataSource.SelectedRows.Count > 0)
            {
                suplierId = int.Parse(gv_SuplierDataSource.SelectedRows[0].Cells["Id"].Value.ToString());
                loadFoodDataSuplierTabs();

            }

        }

        private void btn_UpdateSuplier_Click(object sender, EventArgs e)
        {
            FrmUpdateSuplier frmUpdateSuplier = new FrmUpdateSuplier(this);
            frmUpdateSuplier.Show();
        }

        private void btn_DeleteSuplier_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "CONFIRMATION", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                int result = supilerManagement.DeleteSuplier(suplierId);
                if (result < 0)
                {
                    MessageBox.Show("Can not delete Item!");
                }
                else
                {
                    loadSuplierData();
                    MessageBox.Show("Successful!");
                }
            }
            else MessageBox.Show("Nothing be changed!");
        }
    }
}
