using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageCinema.DAO;
using ManageCinema.DTO;

namespace ManageCinema
{
    public partial class frmCustomer : Form
    {

        public Customer customer;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DataTable data = CustomerDAO.GetCustomerMember(txtCustomerID.Text, txtCustomerName.Text);

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("ID hoặc Họ tên của Khách Hàng không chính xác!\nVui lòng nhập lại thông tin.");
                return;
            }
            customer = new Customer(data.Rows[0]);

            DialogResult = DialogResult.OK;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
