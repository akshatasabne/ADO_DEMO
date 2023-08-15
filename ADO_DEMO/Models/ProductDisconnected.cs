using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_DEMO.Models
{
    public class ProductDisconnected
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public ProductDisconnected()
        {
            string connstr = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(connstr);

        }
        public DataSet GetAllProducts()
        {
            string qry = "select * from Product1";
            da = new SqlDataAdapter(qry, con);
            // we want to apply PK to the col which is in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // track the DataSet , generate the qry & pass to the DataAdapter
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Product1");// Product name is given to the table which is in DataSet
            return ds;
        }
        public DataTable GetAllCategories()
        {
            string qry = "select * from Category";
            da = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            da.Fill(ds, "Category");
            return ds.Tables["Category"];
        }

        public int AddProduct(Product1 product)
        {
            ds = GetAllProducts();
            // step1 create new row
            DataRow row = ds.Tables["Product1"].NewRow();
            // step2 - add record to the row
            row["name"] = product.Name;
            row["price"] = product.Price;
            row["cid"] = product.Cid;
            // step3 - attach the row to the DataSet
            ds.Tables["Product1"].Rows.Add(row);
            // step4 update the changes to DB
            int res = da.Update(ds.Tables["Product1"]);
            return res;
        }
        public int UpdateProduct(Product1 prod)
        {
            ds = GetAllProducts();
            int res = 0;
            // step1 find the row to modify
            DataRow row = ds.Tables["Product1"].Rows.Find(prod.Id);
            if (row != null)
            {
                // step2 - modify record to the row
                row["name"] = prod.Name;
                row["price"] = prod.Price;
                row["cid"] = prod.Cid;

                // step3 update the changes to DB
                res = da.Update(ds.Tables["Product1"]);
            }
            return res;
        }
        public int DeleteProduct(int id)
        {
            ds = GetAllProducts();
            int res = 0;
            // step1 find the row to modify
            DataRow row = ds.Tables["Product1"].Rows.Find(id);
            if (row != null)
            {
                // row will be deleted from the DataSet
                row.Delete();
                // step3 update the changes to DB
                res = da.Update(ds.Tables["Product1"]);
            }
            return res;
        }
        public Product1 GetProductById(int id)
        {
            ds = GetAllProducts();
            DataRow row = ds.Tables["Product1"].Rows.Find(id);
            Product1 prod = new Product1();
            prod.Id = Convert.ToInt32(row["id"]);
            prod.Name = row["name"].ToString();
            prod.Price = Convert.ToInt32(row["price"]);
            prod.Cid = Convert.ToInt32(row["cid"]);
            return prod;
        }
        


    }


}

