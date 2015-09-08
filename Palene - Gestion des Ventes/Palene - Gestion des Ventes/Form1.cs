using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.Odbc;
using objAccApp = Microsoft.Office.Interop.Access;
using dao = DAO;

namespace Palene___Gestion_des_Ventes
{
    /// <summary>
    /// Classe principale contenant l'ensemble des operations effectuables à partir du logiciel
    /// </summary>
    public partial class Form1 : Form
    {
        string connexionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/" + Environment.UserName + "/Documents/Palene_Gest_Vente.accdb;Persist Security Info=False";
        static string Mot_de_Passe = "caissier";
        static string NomUser = "toubapalen3";
        private string CmdAdmin;
        private string type_user;

        /// <summary>
        /// Valeur de retour de la commande de l'admin : Affichage du Stock ou Edition des Etats
        /// </summary>
        public string ValeurCmdAdmin
        {
            get { return CmdAdmin; }
            set { CmdAdmin = value; }
        }
        public string ValeurTypeUser
        {
            get { return type_user; }
            set { type_user = value; }
        }

        public string ValeurMdpasse
        {
            get { return Mot_de_Passe; }
            set { Mot_de_Passe = value; }
        }

        public string ValeurUsername
        {
            get { return NomUser; }
            set { NomUser = value; }
        }

        private DataTable Vente_Jourtable = new DataTable();
        private DataTable Stock_table = new DataTable();
        private DataTable Historique_table = new DataTable();

        private BindingSource Vente_JourbindingSource = new BindingSource();
        private BindingSource Stock_bindingSource = new BindingSource();
        private BindingSource Historique_bindingSource = new BindingSource();
        /// <summary>
        /// Formulaire Principale
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void DataReload()
        {
          
            try
            {
               
                
                WhipeData(Vente_JourdataGridView, Vente_Jourtable);
                WhipeData(Stock_dataGridView, Stock_table);
                WhipeData(Historique_dataGridView, Historique_table);

                Vente_JourdataGridView.DataSource = Vente_JourbindingSource;
                GetData("SELECT Désignation,Quantité_Vendue,Prix,Date_de_Vente FROM Palene_Historique WHERE Date_de_Vente=Date()", Vente_JourbindingSource, Vente_Jourtable);
                Vente_JourdataGridView.Columns[0].HeaderText = "Désignation";
                Vente_JourdataGridView.Columns[1].HeaderText = "Quantité Vendue";
                Vente_JourdataGridView.Columns[2].HeaderText = "Prix";
                Vente_JourdataGridView.Columns[3].HeaderText = "Date de Vente";
                Vente_JourdataGridView.AutoResizeColumns();


                Stock_dataGridView.DataSource = Stock_bindingSource;
                GetData("select Designation,QuantInitiale,QuantVendue,Prix,Stock from Palene_Gest_Vente", Stock_bindingSource, Stock_table);
                Stock_dataGridView.Columns[0].HeaderText = "Désignation";
                Stock_dataGridView.Columns[1].HeaderText = "Quantité Initiale";
                Stock_dataGridView.Columns[2].HeaderText = "Quantité Vendue";
                Stock_dataGridView.Columns[3].HeaderText = "Prix";
                Stock_dataGridView.Columns[4].HeaderText = "Stock";
                Stock_dataGridView.AutoResizeColumns();

                Historique_dataGridView.DataSource = Historique_bindingSource;
                GetData("SELECT Désignation,Quantité_Vendue,Prix,Date_de_Vente,Effectuepar FROM Palene_Historique", Historique_bindingSource, Historique_table);
                Historique_dataGridView.Columns[0].HeaderText = "Désignation";
                Historique_dataGridView.Columns[1].HeaderText = "Quantité Vendue";
                Historique_dataGridView.Columns[2].HeaderText = "Prix";
                Historique_dataGridView.Columns[3].HeaderText = "Date de Vente";
                Historique_dataGridView.Columns[4].HeaderText = "Effectue Par";
                Historique_dataGridView.AutoResizeColumns();

                string updatedata = "UPDATE Palene_Gest_Vente SET Palene_Gest_Vente.Stock = Palene_Gest_Vente.QuantInitiale-Palene_Gest_Vente.QuantVendue";
                UpdateData(updatedata);
                
            }
            catch(Exception ex)
            {
               throw ex;
            }
        
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {


            DataReload();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                  if (Vente_JourdataGridView.CurrentCellAddress.X.Equals(0))
                    {
                        Article_textBox.Text = Vente_JourdataGridView.CurrentCell.Value.ToString();
                    }
                  else if(Stock_dataGridView.CurrentCellAddress.X.Equals(0))
                  {
                      Designation_textBox.Text = Stock_dataGridView.CurrentCell.Value.ToString();
                  }
                  else if (Historique_dataGridView.CurrentCellAddress.X.Equals(0))
                  {

                      Article_textBox.Text = Vente_JourdataGridView.CurrentCell.Value.ToString();
                  }

            
        }

    

        private void Annuler_Click(object sender, EventArgs e)
        {
            string avert = "Voulez- vous vraiment annuler la vente ?";

                
               var result = MessageBox.Show(avert, avert, MessageBoxButtons.YesNo,MessageBoxIcon.Question);
               if (result == DialogResult.Yes)
               {


                   try
                   {
                       string requete = "DELETE * FROM Palene_Historique WHERE Date_de_Vente=Date() AND Désignation='" + Article_textBox.Text + "' and Prix =" + Prix_textBox2.Text;

                       OleDbConnection annuler = new OleDbConnection(connexionstring);

                       OleDbCommand effectuevente = new OleDbCommand(requete, annuler);


                       annuler.Open();
                       effectuevente.ExecuteReader();
                       MessageBox.Show("Vente Annulé");
                       annuler.Close();
                       DataReload();
                       totalcaisse();
                   }
                   catch (Exception)
                   {
                       MessageBox.Show("Erreur de Suppression !!! Veuillez ressayer SVP");
                   }
               }
            
            
        }

        private void Vendre_Click(object sender, EventArgs e)
        {
         try
             {
            string requete = "INSERT INTO Palene_Historique (Désignation,Quantité_Vendue,Prix,Date_de_vente,Effectuepar) values ('"+Article_textBox.Text+"',"+QuantVendue_textBox.Text+","+Prix_textBox2.Text+",Date(),'"+ValeurTypeUser+"')";
            OleDbConnection vendre = new OleDbConnection(this.connexionstring);

            OleDbCommand effectuevente = new OleDbCommand();
            
            if(Article_textBox.TextLength == 0 || QuantVendue_textBox.TextLength == 0 || Prix_textBox2.TextLength == 0)
            {
                MessageBox.Show("Un ou plusieurs champs sont vide veuillez remplir tout les champs SVP !!!");
            }
            else
            {
                string test = "select Stock from Palene_Gest_Vente where Designation = '" + Article_textBox.Text + "' ";
                string updatedata = "Update Palene_Gest_Vente set QuantVendue = QuantVendue + " + QuantVendue_textBox.Text + " where Designation = '" + Article_textBox.Text + "'";
                
                vendre.Open();
                effectuevente = new OleDbCommand(test, vendre);
                int stock = int.Parse(effectuevente.ExecuteScalar().ToString());
                if (stock <= int.Parse(QuantVendue_textBox.Text))
                {
                    MessageBox.Show("Le stock est inferieur à la quantité vendue !!!");
                }
                else
                {
            effectuevente = new OleDbCommand(requete, vendre);
            effectuevente.ExecuteNonQuery();
            UpdateData(updatedata);
            updatedata="UPDATE Palene_Gest_Vente SET Palene_Gest_Vente.Stock = Palene_Gest_Vente.QuantInitiale-Palene_Gest_Vente.QuantVendue";
            UpdateData(updatedata);
                MessageBox.Show("Vente Effectué");
                DataReload();
                totalcaisse();
            vendre.Close();
            }
            }
             }
             catch(Exception)
         {
             MessageBox.Show("Erreur de vente !!! Veuillez ressayer SVP");
             }

        }


        private void GetData(string selectCommand, BindingSource a, DataTable b)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.

               
                // Create a new data adapter based on the specified query.
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectCommand,connexionstring);

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

        private void WhipeData(DataGridView a,DataTable b)
        {
            
            b.Clear();
            a.DataBindings.Clear();
            a.DataSource = null;
                 
        }

        private void Stock_MouseClick(object sender, MouseEventArgs e)
        {
            WhipeData(Stock_dataGridView,Stock_table);
            Stock_dataGridView.DataSource = Stock_bindingSource;
            GetData("select Designation,QuantInitiale,QuantVendue,Prix,Stock from Palene_Gest_Vente", Stock_bindingSource, Stock_table);
            Stock_dataGridView.AutoResizeColumns();
            tabControl1.TabPages[1].Hide();
        }

     

        private void Ajouter_Click(object sender, EventArgs e)
        {


            string test = "Select * from Palene_Gest_Vente where Designation='"+Designation_textBox.Text+"'";
            string ladate = System.DateTime.Today.Date.ToShortDateString().ToString();
            string requete = "INSERT INTO Palene_Gest_Vente (Designation,QuantInitiale,Stock,Prix_de_Vente,Prix) values ('" + Designation_textBox.Text + "'," + QuantInitial_textBox.Text + "," + QuantInitial_textBox.Text + "," + Prix_textBox.Text + "," + Prix_textBox.Text + ")";
            OleDbConnection ajout = new OleDbConnection(connexionstring);
            OleDbCommand effectuevente = new OleDbCommand(test, ajout);
            
            ajout.Open();

           
            if(effectuevente.ExecuteReader().HasRows)
            {
            MessageBox.Show("Cet Article existe déja dans la base de données");
            ajout.Close();
            }
            else
            {
                if(Designation_textBox.TextLength == 0 || QuantInitial_textBox.TextLength == 0 || Prix_textBox.TextLength == 0)
                {
                    MessageBox.Show("Un ou Plusieurs champs sont vides veuillez remplir tous les champs S'IL VOUS PLAIT !!! ");
                }
                else
                {
                ajout.Close();

            effectuevente = new OleDbCommand(requete, ajout);


            ajout.Open();
            effectuevente.ExecuteNonQuery();
            MessageBox.Show("Ajout Effectué");
            DataReload();
            ajout.Close();
                }
            }
        }

        private void Annuler_Ajout_Click(object sender, EventArgs e)
        {
            Designation_textBox.Text="";
            QuantInitial_textBox.Text = "";
            Prix_textBox.Text = "";

        }

        private void Deconnexion_Click(object sender, EventArgs e)
        {
            Page_Connexion b = new Page_Connexion("Connexion",this);
            b.Show();
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requeteupdate"></param>
        public void UpdateData(string requeteupdate)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                OleDbConnection ajout = new OleDbConnection(connexionstring);
                OleDbCommand misajour = new OleDbCommand(requeteupdate, ajout);
               
               
                ajout.Open();
                misajour.ExecuteNonQuery();
                ajout.Close();

                }
            catch (OleDbException)
            {
                MessageBox.Show(requeteupdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void InsertData(string requeteupdate)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                OleDbConnection ajout = new OleDbConnection(connexionstring);
                OleDbCommand misajour = new OleDbCommand(requeteupdate, ajout);


                ajout.Open();
                misajour.ExecuteNonQuery();
                ajout.Close();

            }
            catch (OleDbException)
            {
                MessageBox.Show(requeteupdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Chercher_Click(object sender, EventArgs e)
        {
            string strFileName = "C:/Users/" + Environment.UserName.ToString() + "/Documents/Palene_Gest_Vente.accdb"; //File Name To Open txtARSource.Text.Trim(); 
            OpenFileDialog ofdAccReport = new OpenFileDialog();
            ofdAccReport.FileName = strFileName;
                //Create New Open File Dialog

               //Set File Filter For OFD ofdAccReport.Filter = "Microsoft Access (*.accdb)|*.accdb)"; 

              /* if (strFileName.Length > 0) //If File Selected
               {

                   ofdAccReport.FileName = strFileName;

               }

               if (ofdAccReport.ShowDialog() == DialogResult.Cancel) //If Cancelled
               {

                   return;

               }
               
             */
               



            lstARReports.Items.Clear(); //Erase Previous ListBox Items

            objAccApp.Application app = new objAccApp.Application(); //Instantiate Access Object

            app.Visible = false; //Do Not Display Access Window

            app.OpenCurrentDatabase(ofdAccReport.FileName, false, ""); //Open Selected Access Database

            string strReportSQL = "SELECT [Name] FROM MSysObjects WHERE Type = -32764"; //Search All Access Reports

            
            dao.Database daoDB = (DAO.Database)app.CurrentDb(); //Open The Access Database

            dao.Recordset rsReports = daoDB.OpenRecordset(strReportSQL, Type.Missing, Type.Missing, Type.Missing); //Find All Reports

            while (!rsReports.EOF)
            {

                lstARReports.Items.Add(rsReports.Fields[0].Value); //Add Each Report Name To The ListBox

                rsReports.MoveNext(); //Continue

            }

            rsReports.Close(); //Close All Objects
            daoDB.Close();
            app.CloseCurrentDatabase();

            rsReports = null; //Release All Resources
            daoDB = null;
            app = null;
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            
         try{
             string strFileName = "Palene_Gest_Vente.accdb";
             string strAccReport = lstARReports.SelectedItem.ToString(); //Get Selected ListBox Item

                objAccApp.Application app = new objAccApp.Application(); //Instantiate Access Application Object

                //Open Database app.OpenCurrentDatabase(txtARSource.Text.Trim(), false, ""); 

                app.OpenCurrentDatabase(strFileName, false, "");
                app.Visible = false; //Do Not Show Access Window(s)
               
                
                app.DoCmd.OpenReport(strAccReport, Microsoft.Office.Interop.Access.AcView.acViewPreview, Type.Missing, Type.Missing, objAccApp.AcWindowMode.acWindowNormal, Type.Missing); //Open Selected Report

              // Print the document.
                 string formats =  "dd_MM_yyyy-HH_mm_ss";
                 string ReportFileName ="C:/Users/" + Environment.UserName.ToString() + "/Documents/" + lstARReports.SelectedItem.ToString() + " ("+System.DateTime.Now.ToString(formats)+").pdf" ;
                 
                

                 app.DoCmd.PrintOut(objAccApp.AcPrintRange.acPrintAll, Type.Missing, Type.Missing, objAccApp.AcPrintQuality.acHigh, Type.Missing, Type.Missing); //Print Report
                 
             //app.DoCmd.OutputTo(objAccApp.AcOutputObjectType.acOutputReport, Type.Missing, "PDF Format (*.pdf)", ReportFileName, Type.Missing, Type.Missing, objAccApp.AcPrintQuality.acHigh);

               app.CloseCurrentDatabase(); //Close Database

                app = null; //Release Resources
            }
            catch(NullReferenceException)
         {
            MessageBox.Show("Veuillez selectionner un etat à imprimer");
            }
            catch(Exception)
         {
             MessageBox.Show("Erreur d'impression !!! Veuillez ressayer SVP");

            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if ( tabControl1.SelectedIndex == 1 && type_user == "admin")
            {
                tabControl1.TabPages[1].Show();
            
            }
            else if(tabControl1.SelectedIndex == 1 && type_user == "caissier")
            {
                tabControl1.TabPages[1].Hide();

                Page_Connexion b = new Page_Connexion("Stock", this);
                b.Show();
                b.FormClosed += b_FormClosed;
                this.Hide();
            }
            else if (tabControl1.SelectedIndex == 3 && type_user == "admin")
            {
                tabControl1.TabPages[3].Show();
            }
            else if (tabControl1.SelectedIndex == 3 && type_user == "caissier")
            {
                tabControl1.TabPages[3].Hide();
                Page_Connexion b = new Page_Connexion("Etat", this);
                b.Show();
                b.FormClosed += b_FormClosed;
                this.Hide();
            }
            /*
             if (tabControl1.SelectedIndex == 1 )
              {
              tabControl1.TabPages[1].Hide();  
                
                Page_Connexion b = new Page_Connexion("Stock",this);
              b.Show();
              b.FormClosed += b_FormClosed; 
              this.Hide();
              
               
              }
              else if(tabControl1.SelectedIndex == 3)
              {
                tabControl1.TabPages[3].Hide();  
                
                Page_Connexion b = new Page_Connexion("Etat",this);
              b.Show();
              b.FormClosed += b_FormClosed;                  
              this.Hide();
                 
                 
              }
            */
             
        }

        void b_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                this.Show();
                if (CmdAdmin == "Stock")
                {
                    tabControl1.TabPages[1].Show();
                }
                else if(CmdAdmin == "Etat")
                {
                    tabControl1.TabPages[3].Show();
                   
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {

            string test = "Select * from Palene_Gest_Vente where Designation='" + Designation_textBox.Text + "'";
            string ladate = System.DateTime.Today.Date.ToShortDateString().ToString();
            string requete = "Delete * From Palene_Gest_Vente where Designation ='"+Designation_textBox.Text+"' and Prix_de_vente = 1000";
            OleDbConnection ajout = new OleDbConnection(connexionstring);
            OleDbCommand effectuevente = new OleDbCommand(test, ajout);

            ajout.Open();

            
               if (effectuevente.ExecuteReader().HasRows)
            {
                ajout.Close();

                effectuevente = new OleDbCommand(requete, ajout);


                ajout.Open();
                effectuevente.ExecuteNonQuery();
                MessageBox.Show("Suppression Effectué");
                DataReload();
                ajout.Close();
                
            }
            else
            {
                
                if (Designation_textBox.TextLength == 0 || QuantInitial_textBox.TextLength == 0 || Prix_textBox.TextLength == 0)
                {
                    MessageBox.Show("Un ou Plusieurs champs sont vides veuillez remplir tous les champs S'IL VOUS PLAIT !!! ");
                }
                else
                {
                    MessageBox.Show("Cet Article n'existe pas dans la base de données");
                   
                }
            }

        }

        private void GererUser_Click(object sender, EventArgs e)
        {
            if (type_user == "admin")
            {
                UserHandlingForm userhand = new UserHandlingForm();
                userhand.Show();
            }
            else
            {
                MessageBox.Show("Vous n'etes pas un administrateur veuillez vous connectez en tant qu'administrateur ");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void totalcaisse()
        {

            string requete = "SELECT SUM(Prix*Quantité_Vendue) FROM Palene_Historique WHERE Date_de_Vente=Date()";
            OleDbConnection totcaisse = new OleDbConnection(this.connexionstring);
            OleDbCommand sommecaisse = new OleDbCommand(requete,totcaisse);
            totcaisse.Open();
            int somme = int.Parse(sommecaisse.ExecuteScalar().ToString());
            textBox2.Text = "Total en Caisse : "+somme.ToString();
            totcaisse.Close();
        }

       

       

      

        
        
    }
}
