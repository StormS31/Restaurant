using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using RestaurantPS.Util;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPS.UI
{
    public partial class AngajatComenziPage : Form
    {
        private ComandaService comandaService;
        public AngajatComenziPage()
        {
            InitializeComponent();
            this.comandaService = new ComandaService();
            veziComenzi();
        }
        private void veziComenzi()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Total", typeof(int));
            dt.Columns.Add("Status", typeof(Status));
            dt.Columns.Add("Data", typeof(DateTime));
            List<Comanda> comenzi = this.comandaService.GetComenzi();
            foreach (Comanda c in comenzi)
            {
                dt.Rows.Add(c.Id, c.Pret, c.Statuss, c.Data);
            }
            this.comandaTable.DataSource = dt;
        }
        private void veziComenziBtn_Click(object sender, EventArgs e)
        {
            veziComenzi();
        }

        private void modificaStatusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idTextBox.Text);
                try
                {
                    Comanda c = comandaService.GetComanda(id);
                    string status = this.statusComboBox.Text;
                    c.Statuss = Util.Util.GetStatus(status);
                    comandaService.UpdateComanda(c);
                    veziComenzi();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                    //MessageBox.Show("Comanda cu id-ul introdus nu exista!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Id-ul nu este un numar!");
            }
        }
    }
}
