using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class dashForm : Form
    {
        public dashForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            mediPanel.Visible = false;
            panelInvoice.Visible = false;
            panelCorress.Visible = false;
        }

        private void hideSubMenu()
        {
            if(mediPanel.Visible == true)
                mediPanel.Visible = false;
            if (panelInvoice.Visible == true)
                panelInvoice.Visible = false;
            if (panelCorress.Visible == true)
                panelCorress.Visible = false;
            
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void mediPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dash_Load(object sender, EventArgs e)
        {

        }

        private void mediListBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new MedicineListForm());
            hideSubMenu();
        }

        private void mediBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(mediPanel);
        }

        private void PrescriptionRegisterBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new prescriptionRegisterForm());
        }

        private void pricelistFilebtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PriceListFileForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInvoice);
        }

        private void cusBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerInvoiceForm());
            hideSubMenu();
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new SupplierInvoiceForm());
            hideSubMenu();
        }

        private void purchasebtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PurchaseForm());
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesForm());
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new StockForm());
        }

        private void corresBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCorress);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchild.Controls.Add(childForm);
            panelchild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuForm());
        }

        private void IAbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new IAMediForm());
        }

        private void IBbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new IBMediForm());
        }

        private void IIBbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new IIBMediForm());
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new settings());
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Info());
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Help());
        }

        private void lettersBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new letters());
        }
    }
}
