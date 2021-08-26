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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
        AdminManager adminManager = new AdminManager(new EfAdminDal(), new EfEmployeeDal());
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private bool checkManager()
        {
            if (employeeManager.CheckEmployee(new Employee { name = textEdit1.Text, surname = textEdit2.Text, password = textEdit3.Text }))
            {
                MessageBox.Show("Giriş Başarılı");
                return true;
            }
            else
            {
                MessageBox.Show("Girilen Bilgiler Hatalı");
                return false;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (checkManager())
            {
                QRCodePage qRCodePage = new QRCodePage();
                qRCodePage.Show();
                this.Hide();
            }
            else return;
        }
        private bool checkManagerAdmins()
        {
            if (adminManager.CheckAdmin(new Admins { Name = textEdit6.Text, Surname = textEdit5.Text, Password = textEdit4.Text }))
            {
                MessageBox.Show("Giriş Başarılı");
                return true;
            }
            else
            {
                MessageBox.Show("Girilen Bilgiler Hatalı");
                return false;
            }

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (checkManagerAdmins())
            {
                AdminPage adminPage = new AdminPage();
                adminPage.Show();
                this.Hide();
            }
            else return;
           
        }
    }
}
