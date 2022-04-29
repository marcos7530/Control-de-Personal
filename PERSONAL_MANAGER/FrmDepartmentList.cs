﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONAL_MANAGER
{
    public partial class FrmDepartmentList : Form
    {
        public FrmDepartmentList()
        {
            InitializeComponent();
        }

 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            this.Close();
            frm.ShowDialog();
            frm.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            this.Close();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
