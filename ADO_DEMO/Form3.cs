using ADO_DEMO.Models;
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

namespace ADO_DEMO
{
    public partial class Form3 : Form
    {
        ProductDisconnected crud;
        DataTable table;

        public Form3()
        {
            InitializeComponent();
            crud = new ProductDisconnected();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable table = crud.GetAllCategories();
            comboCompany.DataSource = table;
            comboCompany.DisplayMember = "Cname";
            comboCompany.ValueMember = "Cid";


        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = crud.GetProductById(Convert.ToInt32(textId.Text));
                if (prod.Id > 0)
                {
                    List<Category> list = new List<Category>();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        Category c = new Category();
                        c.Cid = Convert.ToInt32(table.Rows[i]["cid"]);
                        c.Cname = table.Rows[i]["cname"].ToString();
                        list.Add(c);
                    }
                    foreach (Category item in list)
                    {
                        if (item.Cid == prod.Cid)
                        {
                            comboCompany.Text = item.Cname;
                            break;
                        }
                    }
                    textName.Text = prod.Name;
                    textPrice.Text = prod.Price.ToString();

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
    

        private void butsave_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 p = new Product1();
                p.Name = textName.Text;
                p.Price = Convert.ToInt32(textPrice.Text);
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

        private void butShowAll_Click(object sender, EventArgs e)
        {

                 DataSet ds = crud.GetAllProducts();
            dataGridView1.DataSource = ds.Tables["Product1"];

            
        }
    }
}