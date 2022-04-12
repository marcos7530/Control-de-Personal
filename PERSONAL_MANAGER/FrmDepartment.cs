using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;//capa de logica de negocios
using DAL;//capa de 

namespace PERSONAL_MANAGER
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DEPARTMENT department = new DEPARTMENT();
            department.DepartamentName = txtDepartmentName.Text;
            DepartmentBLL.AddDepartment(department);
        }
    }
}
