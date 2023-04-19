using BL;
using Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RestaurantPS.UI
{
    public partial class AngajatPage : Form
    {
        private MeniuService meniuService;
        private ComandaService comandaService;
        public AngajatPage()
        {
            InitializeComponent();
            this.meniuService = new MeniuService();
            this.comandaService = new ComandaService();
            this.veziPreparate();
        }

        private void veziPreparate()
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

        private void adaugaPreparaLaComandatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string res = Interaction.InputBox("Introduceti id-ul preparatului pe care doriti sa il adaugati la comanda: ", "Adauga preparat la comanda actuala", "");
                int id=-1;
                if (!res.Equals(""))
                    id = int.Parse(res);
                try
                {
                    if (id != -1)
                    {
                        Preparat p = meniuService.GetPreparat(id);
                        int resAdd = comandaService.AddToComandaActuala(p);
                        if (resAdd == 0)
                            MessageBox.Show("Stoc insuficient!");
                        else { 
                            veziPreparate();
                            updateComandaTable();
                            this.totalValLbl.Text = comandaService.TotalPrice().ToString();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Id nerecunoscut!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Id-ul citit nu este un numar!");
            }
        }

        private void stergePreparatDinComandaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string resBox = Interaction.InputBox("Introduceti id-ul preparatului pe care doriti sa il stergeti din comanda: ", "Sterge preparat din comanda actuala", "");
                int id = -1;
                if (!resBox.Equals(""))
                    id = int.Parse(resBox);
                int res = comandaService.StergeDinComandaActuala(id);
                if (res == 0 && id != -1)
                {
                    MessageBox.Show("Id neexistent in comanda!");
                }
                else
                {
                    updateComandaTable();
                    veziPreparate();
                    this.totalValLbl.Text = comandaService.TotalPrice().ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Id-ul citit nu este un numar!");
            }
        }
        private void updateComandaTable()
        {
            List<Preparat> prepList = comandaService.ComandaActuala;
            DataTable dt = new DataTable();
            // Add columns to the data table
            dt.Columns.Add("Nume", typeof(string));
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Pret", typeof(double));

            // Loop through the list of users and add each one to the data table
            foreach (Preparat preparat in prepList)
            {
                dt.Rows.Add(preparat.Nume, preparat.Id, preparat.Pret);
            }

            // Set the data source of the DataGridView to the data table
            this.comandaTable.DataSource = dt;
        }

        private void AngajatPage_Closing(object sender, EventArgs e) => comandaService.EmptyComandaActuala();

        private void veziComenziBtn_Click(object sender, EventArgs e)
        {
            AngajatComenziPage acp = new AngajatComenziPage();
            acp.Show();
        }

        private void adaugaComandaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                comandaService.AddComanda();
                MessageBox.Show("Comanda adaugata cu succes!");
                updateComandaTable();
                this.totalValLbl.Text = "0.0";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
