using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;


namespace ADO_DEMO.Models
{
    public class EmployeeCRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public EmployeeCRUD()
        {
            string connstr = ConfigurationManager.ConnectionStrings["default connection"].ConnectionString;
            con = new SqlConnection(connstr);
        }
        public List<Department> GetDepartment()
        {
            List<Department> list1 = new List<Department>();
            //step-1 write a query
            string qry = "select * from Department";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Department d = new Department();
                    d.Did = Convert.ToInt32(dr["Did"]);
                    d.Dname = dr["Dname"].ToString();
                    list1.Add(d);
                }
            }
            con.Close();
            return list1;
        }
        public int AddEmployee(Employee employee)
        {
            string str = "insert into Employee Values(@eid,@ename,@salary,@did)";
            //step-2 Assign comand
            cmd = new SqlCommand(str, con);
            // step-3 pass value
            cmd.Parameters.AddWithValue("@eid", employee.Eid);
            cmd.Parameters.AddWithValue("@ename", employee.Ename);
            cmd.Parameters.AddWithValue("@salary", employee.ESalary);
            cmd.Parameters.AddWithValue("@did", employee.Did);
            // step-4 fire the query
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public int UpdateEmployee(Employee employee)
        {
            string str = "update Employee set ename=@Ename,salary=@Esalary,did=@Did where eid=@eid";
            //step-2 Assign comand
            cmd = new SqlCommand(str, con);
            // step-3 pass value
            cmd.Parameters.AddWithValue("@ename", employee.Ename);
            cmd.Parameters.AddWithValue("@esalary", employee.ESalary);
            cmd.Parameters.AddWithValue("@did", employee.Did);
            cmd.Parameters.AddWithValue("@eid", employee.Eid);

            // step-4 fire the query
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
            
        }
        public int DeleteEmployee(int Eid)
        {
            string str = "delete from Employee where eid=@eid";
            //step-2 Assign comand
            cmd = new SqlCommand(str, con);
            // step-3 pass values

            cmd.Parameters.AddWithValue("@eid", Eid);

            // step-4 fire the query
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public Employee GetEmployeeById(int eid)
        {
            Employee employee = new Employee();
            string qry = "select * from Employee where eid=@eid";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@eid", eid);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    employee.Eid = Convert.ToInt32(dr["eid"]);
                    employee.Ename = dr["ename"].ToString();
                    employee.ESalary= Convert.ToInt32(dr["salary"]);
                    employee.Did = Convert.ToInt32(dr["did"]);
                }
            }
            con.Close();
            return employee;
        }

    }
}
