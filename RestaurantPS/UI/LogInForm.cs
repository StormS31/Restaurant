using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPS.UI
{
    public partial class LogInForm : Form
    {
        private UserService userService;
        public LogInForm()
        { 
            InitializeComponent();
            userService = new UserService();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string user = this.userBox.Text;
            string pass = this.PassBox.Text;
            User thisUser = userService.LogIn(user, pass);
            //Console.WriteLine(getMd5Hash(pass));
            if (thisUser != null)
            {
                switch (thisUser.Role)
                {
                    case Rol.ANGAJAT:
                        AngajatPage f2 = new AngajatPage();
                        f2.Show();
                        this.SetVisibleCore(false);
                        break;
                    case Rol.ADMIN:
                        AdminPage f3 = new AdminPage();
                        f3.Show();
                        this.SetVisibleCore(false);
                        break;
                    default:
                        MessageBox.Show("Status neidentificat");
                        break;
                }

            }
            else MessageBox.Show("Credentiale invalide!");
        }
    }
}
