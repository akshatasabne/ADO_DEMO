using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ADO_DEMO.Models;


namespace ADO_DEMO
{
    public partial class Form2 : Form
    {
        EmployeeCRUD Crud;
        List<Department> list1;
        public Form2()
        {
            InitializeComponent();
           Crud = new EmployeeCRUD();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            list1 = Crud.GetDepartment();
            cmbDepartment.DataSource = list1;
            cmbDepartment.DisplayMember = "Dname";
            cmbDepartment.ValueMember = "Did";


        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Eid = Convert.ToInt32(texteid.Text);
                employee.Ename = textename.Text;
                employee.ESalary = Convert.ToInt32(textesalary.Text);
                employee.Did = Convert.ToInt32(cmbDepartment.SelectedValue);
                int res = Crud.AddEmployee(employee);
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

        private void butUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Eid = Convert.ToInt32(texteid.Text);
                employee.Ename = textename.Text;
                employee.ESalary = Convert.ToInt32(textesalary.Text);
                employee.Did= Convert.ToInt32(cmbDepartment.SelectedValue);
                int res = Crud.UpdateEmployee(employee);
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

        private void butSearch_Click(object sender, EventArgs e)
        {

            try
            {
                Employee employee = Crud.GetEmployeeById(Convert.ToInt32(texteid.Text));
                if (employee.Eid > 0)
                {
                    foreach (Department item in list1)
                    {
                        if (item.Did == employee.Eid)
                        {
                            cmbDepartment.Text = item.Dname;
                            break;
                        }
                    }
                    textename.Text = employee.Ename;
                    textesalary.Text = employee.ESalary.ToString();

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

        private void butDel_Click(object sender, EventArgs e)
        {
            try
            {

                int res = Crud.DeleteEmployee(Convert.ToInt32(texteid.Text));
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
    }
    }
    

