﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ModernFlatUI.ProductList;
using static ModernFlatUI.DefineTheProduct;
using static ModernFlatUI.Form1;
using static ModernFlatUI.Reports;
using System.Threading;

namespace ModernFlatUI
{
    public partial class MainForm : Form
    {
        private readonly Form _frmDefineTheProduct = new DefineTheProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private readonly Form _frmProductList = new ProductList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private readonly Form _frmCashRegisterSystem = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private readonly Form _frmReports = new Reports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


        internal static MainForm Mainform;

        public MainForm()
        {
            this.Icon = Properties.Resources.cash_register_icon_157312;
            InitializeComponent();
            Mainform = this;
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            pnlProductMaintenance.Visible = false;
            pnlReports.Visible = false;
        }

        public void HideSubMenu()
        {
            if (pnlProductMaintenance.Visible == true)
                pnlProductMaintenance.Visible = false;
            if (pnlReports.Visible == true)
                pnlReports.Visible = false;
        }

        private void ShowSubMenu(Control subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        public void ShowFormDefineTheProduct()
        {
            pnlMain.Controls.Add(_frmDefineTheProduct);
            _frmDefineTheProduct.Show();
        }

        public void ShowFormReports()
        {
            pnlMain.Controls.Add(_frmReports);
            _frmReports.Show();
        }

        public void ShowFormProductList()
        {

            pnlMain.Controls.Add(_frmProductList);
            _frmProductList.Show();
        }

        public void ShowFormCashRegisterSystem()
        {
            pnlMain.Controls.Add(_frmCashRegisterSystem);
            _frmCashRegisterSystem.Show();
        }

        private void RefreshCashRegisterSystemFromTheStart()
        {
        }

        #region Reports
        private void btnReports_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            pnlMain.Controls.Clear();
            FrmReports.rtxtbReportContent.Text = "";
            FrmReports.btnTop10Products.Enabled = true;
            FrmReports.btnMakeTheReport.Enabled = true;

            ShowFormReports();
        }

        private void btnTotalSalesReport_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            pnlMain.Controls.Clear();
            FrmReports.rtxtbReportContent.Text = "";
            FrmReports.btnTop10Products.Enabled = true;
            FrmReports.btnMakeTheReport.Enabled = true;

            ShowFormReports();
        }

        private void btnTenMostSoldItems_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            pnlMain.Controls.Clear();
            FrmReports.rtxtbReportContent.Text = "";
            FrmReports.btnTop10Products.Enabled = false;
            FrmReports.btnMakeTheReport.Enabled = false;
            ShowFormReports();

        }
        #endregion

        #region ProductMaintenance
        private void btnDefineTheProduct_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            FrmDefineTheProduct.ClearTheInfoInDefineTheProduct();
            FrmDefineTheProduct.btnAddTheProduct.Enabled = false;
            FrmDefineTheProduct.btnChangeTheProductInfo.Enabled = false;
            pnlMain.Controls.Clear();
            ShowFormDefineTheProduct();
        }

        private void btnListOfProducts_Click(object sender, EventArgs e)
        {
            //DO TIME OUT SO IT WON'T LOAD WITH A LAG

            // HideSubMenu();
            pnlMain.Controls.Clear();
            FrmProductList.products.Clear();
            FrmProductList.GetTheProductInfo();
            FrmProductList.dgvProductList.Rows.Clear();
            for (var i = 0; i < FrmProductList.products.Count; i++)
            {
                FrmProductList.dgvProductList.Rows.Add(FrmProductList.products[i].Name, FrmProductList.products[i].Price, FrmProductList.products[i].Quantity, FrmProductList.products[i].Description);
            }
            ShowFormProductList();
        }

        private void btnProductMaintenance_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlProductMaintenance);
        }
        #endregion

        private void btnCashRegister_Click(object sender, EventArgs e)
        {
            FrmForm1.button3.PerformClick();
            {
                HideSubMenu();
                pnlMain.Controls.Clear();
                RefreshCashRegisterSystemFromTheStart();
                if (FrmForm1.txtName.Text == "")
                    FrmForm1.textBox1.ReadOnly = true;
                ShowFormCashRegisterSystem();
            }

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "My Application", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
