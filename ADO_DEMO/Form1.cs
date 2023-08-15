using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ADO_DEMO.Models;

namespace ADO_DEMO
{
    public partial class Form1 : Form
    {
        ProductCRUD crud;
        List<Category> list;
        public Form1()
        {
            InitializeComponent();
           crud  = new ProductCRUD();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 p = new Product1();
                p.Name = textName .Text;
                p.Price = Convert.ToInt32(textPrice .Text);
                p.Cid = Convert.ToInt32(comboCompany.SelectedValue);
                int res = crud.AddProduct(p);
                if (res > 0)
                {
                    MessageBox.Show("Record inserted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = crud.GetCategories();
            comboCompany.DataSource = list;
            comboCompany.DisplayMember = "cname";
            comboCompany.ValueMember = "Cid";

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 product = crud.GetProductById(Convert.ToInt32(textId .Text));
                if (product.Id > 0)
                {
                    foreach (Category item in list)
                    {
                        if (item.Cid == product.Cid)
                        {
                           comboCompany .Text = item.Cname;
                            break;
                        }
                    }
                    textName.Text = product.Name;
                    textPrice.Text = product.Price.ToString();

                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int res = crud.DeleteProduct(Convert.ToInt32(textId.Text));
                if (res > 0)
                {
                    MessageBox.Show("Record deleted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 p = new Product1();
                p.Id = Convert.ToInt32(textId.Text);
                p.Name = textName.Text;
                p.Price = Convert.ToInt32(textPrice.Text);
                p.Cid = Convert.ToInt32(comboCompany.SelectedValue);
                int res = crud.UpdateProduct(p);
                if (res > 0)
                {
                    MessageBox.Show("Record updated..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butShowAll_Click(object sender, EventArgs e)
        {
            DataTable table = crud.GetAllProducts();
            dataGridView1.DataSource = table;

        }
    }
}
