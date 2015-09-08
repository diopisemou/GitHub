using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Palene___Gestion_des_Ventes
{
    public partial class avertstock : Form
    {
        string connexionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/" + Environment.UserName + "/Documents/Palene_Gest_Vente.accdb;Persist Security Info=False";

        private DataTable RuptStocktable = new DataTable();
        private BindingSource RuptStockbindingSource = new BindingSource();
        public avertstock()
        {
            InitializeComponent();
        }

        private void avertstock_Load(object sender, EventArgs e)
        {
            WhipeData(RuptStockdataGridView, RuptStocktable);

            RuptStockdataGridView.DataSource = RuptStockbindingSource;
            GetData("SELECT Designation,QuantInitiale,QuantVendue,Stock FROM Palene_Gest_Vente WHERE Stock<=20", RuptStockbindingSource, RuptStocktable);
            RuptStockdataGridView.Columns[0].HeaderText = "Désignation";
            RuptStockdataGridView.Columns[1].HeaderText = "Quantité Initiale";
            RuptStockdataGridView.Columns[2].HeaderText = "Quantité Vendue";
            RuptStockdataGridView.Columns[3].HeaderText = "Stock";
            RuptStockdataGridView.AutoResizeColumns();
        }
        private void GetData(string selectCommand, BindingSource a, DataTable b)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.


                // Create a new data adapter based on the specified query.
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectCommand, connexionstring);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.

                b.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(b);
                a.DataSource = b;

                // Resize the DataGridView columns to fit the newly loaded content.
                /* Vente_JourdataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                 Stock_dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                 Historique_dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);*/
            }
            catch (OleDbException)
            {
                MessageBox.Show("Erreur !!! ");


            }
        }

        private void WhipeData(DataGridView a, DataTable b)
        {

            b.Clear();
            a.DataBindings.Clear();
            a.DataSource = null;

        }
    }
}
