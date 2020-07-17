using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pharmacy
{
    public partial class CustomerInvoiceForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\pharmacy\DB\loginDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataAdapter dr;
        SqlDataReader read;
        public CustomerInvoiceForm()
        {
            InitializeComponent();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void custInvGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == custInvGridView.Columns["delete"].Index && e.RowIndex >= 0)
            {
                custInvGridView.Rows.Remove(custInvGridView.Rows[e.RowIndex]);

                int sum = 0;
                for (int row = 0; row < custInvGridView.Rows.Count; row++)
                {
                    sum = sum + Convert.ToInt32(custInvGridView.Rows[row].Cells[4].Value);
                }
                txtTol.Text = sum.ToString();

            }
        }

        private void txtdrugId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cmd = new SqlCommand("select * from product where id ='" + txtdrugId.Text + "'", connection);
                connection.Open();
                read = cmd.ExecuteReader();

                if (read.Read())
                {
                    string pname;
                    string price;

                    pname = read["productName"].ToString();
                    price = read["price"].ToString();

                    txtdruNam.Text = pname;
                    txtPrice.Text = price;
                }
                else
                {
                    MessageBox.Show("No Barcode found");
                }
                connection.Close();
            }
            connection.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string dcode = txtdrugId.Text;
            string dname = txtdruNam.Text;
            double price = double.Parse(txtPrice.Text);
            double qty = double.Parse(txtqty.Text);

            double tot = price * qty;

            this.custInvGridView.Rows.Add(dcode,dname ,price,qty,tot);

            int sum = 0;

            for(int row=0; row< custInvGridView.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(custInvGridView.Rows[row].Cells[4].Value);
            }
            txtTol.Text = sum.ToString();

            txtdrugId.Clear();
            txtdruNam.Clear();
            txtPrice.Clear();
            txtqty.Clear();

        }


        public void SalesSave()
        {
            string total = txtTol.Text;
            string pay = txtPay.Text;
            string bal = txtBal.Text;

            string sql1;
            string sql2;

            sql1 = "insert into salesIn(subtotal,pay,bal) values(@subtotal,@pay,@bal) select @@identity;";
            connection.Open();
            cmd = new SqlCommand(sql1, connection);
            cmd.Parameters.AddWithValue("@subtotal", total);
            cmd.Parameters.AddWithValue("@pay", pay);
            cmd.Parameters.AddWithValue("@bal", bal);
            int lastid = int.Parse(cmd.ExecuteScalar().ToString());

            string dname;
            int price = 0;
            int qty = 0;
            int tot = 0;

            for(int row =0; row<custInvGridView.Rows.Count; row++)
            {
                dname = custInvGridView.Rows[row].Cells[1].Value.ToString();
                price = int.Parse(custInvGridView.Rows[row].Cells[2].Value.ToString());
                qty = int.Parse(custInvGridView.Rows[row].Cells[3].Value.ToString());
                tot = int.Parse(custInvGridView.Rows[row].Cells[4].Value.ToString());



                sql2 = "insert into salesProduct(salesIn_id, drugname,price,qty,total) values(@salesIn_id, @drugname,@price,@qty,@total)";
                cmd1 = new SqlCommand(sql2, connection);
                cmd1.Parameters.AddWithValue("@salesIn_id", lastid);
                cmd1.Parameters.AddWithValue("@drugname", dname); 
                cmd1.Parameters.AddWithValue("@price", price);
                cmd1.Parameters.AddWithValue("@qty", qty);
                cmd1.Parameters.AddWithValue("@total", tot);
                cmd1.ExecuteNonQuery();


            }
            MessageBox.Show("sales completed");
            print p = new print();
            p.SalesIn_id = lastid;
            p.Show();
            
            connection.Close();



        }





        private void PrintBtn_Click(object sender, EventArgs e)
        {
            
            
                double total = double.Parse(txtTol.Text);
                double pay = double.Parse(txtPay.Text);
                double bal = pay - total;
                txtBal.Text = bal.ToString();
                SalesSave();
        }
    }
}
