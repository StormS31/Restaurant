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
    public partial class AdminRapoarteForm : Form
    {
        private ComandaService comandaService;
        public AdminRapoarteForm()
        {
            InitializeComponent();
            this.comandaService = new ComandaService();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DateTime dataStart = this.dataInceput.Value;
            DateTime dataFinal = this.dataFinal.Value;
            List<Comanda> comenzi = comandaService.GetComandaBetweenDates(dataStart, dataFinal);
        }
    }
}
