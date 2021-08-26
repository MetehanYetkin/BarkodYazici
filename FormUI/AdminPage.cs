using Bussiness.Concrate;
using DataAccess.EntityFramework;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        AdminManager adminManager = new  AdminManager(new EfAdminDal(),new EfEmployeeDal());
        private void simpleButton1_Click(object sender, EventArgs e)//ADD EMPLOYEE
        {
          var result= adminManager.AddEmployee(new Employee{ name=textEdit1
           .Text,surname=textEdit2.Text,password=textEdit3.Text});
            MessageBox.Show(result.Message);
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)//DELETE EMPLOYEE
        {
          var result=  adminManager.DeleteEmployee((new Employee
            {
                Id=Convert.ToInt32(textEdit7.Text),
                name = textEdit1
           .Text,
                surname = textEdit2.Text,
                password = textEdit3.Text
            }));
            MessageBox.Show(result.Message);
        }

        private void simpleButton3_Click(object sender, EventArgs e)//UPDATE EMPLOYEE
        {
         var result=   adminManager.UpdateEmployee((new Employee
            {
                Id = Convert.ToInt32(textEdit7.Text),
                name = textEdit1
           .Text,
                surname = textEdit2.Text,
                password = textEdit3.Text
            }));
            MessageBox.Show(result.Message);
        }

        private void simpleButton6_Click(object sender, EventArgs e)//ADMİN EKLE
        {
          var result =   adminManager.Add(new Admins { Name = textEdit4.Text, Surname = textEdit5.Text, Password = textEdit6.Text });
            MessageBox.Show(result.Message);
        }

        private void simpleButton5_Click(object sender, EventArgs e)//ADMİN SİL
        {
           var result= adminManager.Delete(new Admins { Name = textEdit4.Text, Surname = textEdit5.Text, Password = textEdit6.Text ,Id=Convert.ToInt32(textEdit8.Text)});
            MessageBox.Show(result.Message);

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
          var result=  adminManager.Update(new Admins { Name = textEdit4.Text, Surname = textEdit5.Text, Password = textEdit6.Text, Id = Convert.ToInt32(textEdit8.Text) });
            MessageBox.Show(result.Message);

        }
    }
}
