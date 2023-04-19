using BL;
using Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RestaurantPS.UI
{
    public partial class AdminPage : Form
    {
        private UserService userService;
        private MeniuService meniuService;
        private ComandaService comandaService;
        public AdminPage()
        {
            InitializeComponent();
            this.userService = new UserService();
            this.meniuService = new MeniuService();
            this.comandaService = new ComandaService();
        }

        private void listAngajati_Click(object sender, EventArgs e)
        {
            List<User> userList = userService.getUsers();
            DataTable dt = new DataTable();
            // Add columns to the data table
            dt.Columns.Add("Nume", typeof(string));
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Rol", typeof(string));

            // Loop through the list of users and add each one to the data table
            foreach (User user in userList)
            {
                dt.Rows.Add(user.Username, user.Id, user.Role.ToString());
            }

            // Set the data source of the DataGridView to the data table
            this.diverseTable.DataSource = dt;
        }

        private void addAngajat_Click(object sender, EventArgs e)
        {

            User u = new User();
            string username = Interaction.InputBox("Introduceti username-ul angajatului: ", "Adauga angajat", "");
            string password;
            if (!username.Equals(""))
            {
                password = Interaction.InputBox("Introduceti parola angajatului: ", "Adauga angajat");
                if (!password.Equals(""))
                {
                    try
                    {
                        this.userService.AddUser(new User(username, password, Rol.ANGAJAT));
                        MessageBox.Show("Angajat adaugat cu succes", "Succes");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Utilizator deja existent!", "Eroare");
                    }
                }
            }
        }

        private void veziPreparate_Click(object sender, EventArgs e)
        {
            List<Preparat> prepList = meniuService.GetPreparate();
            DataTable dt = new DataTable();
            // Add columns to the data table
            dt.Columns.Add("Nume", typeof(string));
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Stoc", typeof(int));
            dt.Columns.Add("Pret", typeof(double));

            // Loop through the list of users and add each one to the data table
            foreach (Preparat preparat in prepList)
            {
                dt.Rows.Add(preparat.Nume, preparat.Id, preparat.Stoc, preparat.Pret);
            }

            // Set the data source of the DataGridView to the data table
            this.diverseTable.DataSource = dt;
        }

        private void adaugaPreparat_Click(object sender, EventArgs e)
        {
            string nume = Interaction.InputBox("Introduceti denumirea preparatului: ", "Adauga preparat", "");
            if (!nume.Equals(""))
            {
                string stoc = Interaction.InputBox("Introduceti stocul preparatului: ", "Adauga preparat", "");
                if (!stoc.Equals(""))
                {
                    string pret = Interaction.InputBox("Introduceti pretul preparatului: ", "Adauga preparat", "");
                    if (!pret.Equals(""))
                    {
                        try
                        {
                            int stocInt = int.Parse(stoc);
                            double pretDouble = double.Parse(pret);
                            try
                            {
                                meniuService.AddPreparat(new Preparat(nume, stocInt, pretDouble));
                                MessageBox.Show("Preparat adaugat cu succes!");
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show("Preparat deja existent sau informatii eronate!");
                            }
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Adaugarea a esuat. Ai mai multa grija la introducearea datelor despre preparat!");
                        }
                    }
                }
            }
        }

        private void stergePreparat_Click(object sender, EventArgs e)
        {
            try
            {
                string idString = Interaction.InputBox("Introduceti id-ul preparatului pe care doriti sa il stergeti: ", "Sterge preparat", "");
                if (!idString.Equals(""))
                {
                    int id = int.Parse(idString);
                    meniuService.DeletePreparat(id);
                    MessageBox.Show("Preparat sters cu succes!");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Eroare la stergerea preparatului, verifica ID-ul introdus!");
            }
        }

        private void statisticiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = comandaService.GetMostOrderedDishes();
                this.diverseTable.DataSource = dt;
            }
            catch(Exception exc)
            {
                MessageBox.Show("Eroare neasteptata!");
            }
        }


        private void modificaPreparatBtn_Click(object sender, EventArgs e)
        {
            AdminModificaPreparatForm mpf = new AdminModificaPreparatForm();
            mpf.Show();
        }

        private void genereazaRaportBtn_Click(object sender, EventArgs e)
        {
            AdminRapoarteForm rp = new AdminRapoarteForm();
            rp.Show();
        }

        private void AdminPage_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
