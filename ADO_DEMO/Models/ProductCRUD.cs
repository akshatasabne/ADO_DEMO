using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADO_DEMO.Models
{
    public class ProductCRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public ProductCRUD()
        {
            string connstr = ConfigurationManager.ConnectionStrings["default connection"].ConnectionString;
            con = new SqlConnection(connstr);
        }
        public List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();
            //step-1 write a query
            string qry = "select * from category";
            cmd=new SqlCommand(qry, con);
            con.Open();
            dr= cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    Category c = new Category();
                    c.Cid = Convert.ToInt32(dr["Cid"]);
                    c.Cname = dr["cname"].ToString();
                    list.Add(c);
                }
            }
            con.Close();
            return list;
        }
        public int AddProduct(Product1 product)
        {
            string str = "insert into Product1 Values(@name,@price,@cid)";
            //step-2 Assign comand
            cmd=new SqlCommand(str, con);
            // step-3 pass value
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@cid", product.Cid);
            // step-4 fire the query
            con.Open();
            int res=cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public int UpdateProduct(Product1 product)
        {
            string str = "update Product1 set name=@name,price=@price,cid=@cid where id=@id";
            //step-2 Assign comand
            cmd = new SqlCommand(str, con);
            // step-3 pass value
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@cid", product.Cid);
            cmd.Parameters.AddWithValue("@id", product.Id);

            // step-4 fire the query
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public int DeleteProduct(int id)
        {
            string str = "delete from Product1 where id=@id";
            //step-2 Assign comand
            cmd = new SqlCommand(str, con);
            // step-3 pass value
            
            cmd.Parameters.AddWithValue("@id", id);

            // step-4 fire the query
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public Product1 GetProductById(int id)
        {
            Product1 product = new Product1();
            string qry = "select * from Product1 where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    product.Id = Convert.ToInt32(dr["id"]);
                    product.Name = dr["name"].ToString();
                    product.Price = Convert.ToInt32(dr["price"]);
                    product.Cid = Convert.ToInt32(dr["cid"]);
                }
            }
            con.Close();
            return product;
        }

        public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            string qry = "select * from Product";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
            }
            con.Close();
            return dt;
        }





    }
}

