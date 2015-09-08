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
    public partial class UserHandlingForm : Form
    {
        string connexionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/" + Environment.UserName + "/Documents/Palene_Gest_Vente.accdb;Persist Security Info=False";
        string oldusername = "";
        string oldpassword = "";
        private DataTable Usertable = new DataTable();
        private BindingSource UserbindingSource = new BindingSource();

        /// <summary>
        /// constructeur du gestion des utilisateurs
        /// </summary>
        public UserHandlingForm()
        {
            InitializeComponent();
           
        }

        private void DataReload()
        {
            WhipeData(dataGridView1, Usertable);

            dataGridView1.DataSource = UserbindingSource;
            GetData("SELECT username,password,last_connexion,type_user FROM Users ", UserbindingSource, Usertable);
            dataGridView1.Columns[0].HeaderText = "Nom d'utilisateur";
            dataGridView1.Columns[1].HeaderText = "Mot de Passe";
            dataGridView1.Columns[2].HeaderText = "Derniere connexion";
            dataGridView1.Columns[3].HeaderText = "Type d'Utilisateur";
            dataGridView1.AutoResizeColumns();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "caissier";
            string newuser = textBox1.Text;
            string newmdp = textBox2.Text;
            string test = "select username from Users where username='" + textBox1.Text + "'";
            OleDbConnection userhandlingconn = new OleDbConnection(connexionstring);
            OleDbCommand cmduserhandling = new OleDbCommand();
            
            try
            {
              
                if (textBox1.Text.Length ==0 || textBox2.Text.Length ==0|| comboBox1.SelectedItem.ToString().Length ==0)
                {
                    MessageBox.Show("Un ou plusieur champs sont vides !!!");
                }
                
                else
                {
                    try
                    {
                        cmduserhandling = new OleDbCommand(test, userhandlingconn);
                        userhandlingconn.Open();
                        string verif = cmduserhandling.ExecuteScalar().ToString();
                        userhandlingconn.Close();
                        if (verif.Length > 0)
                        {
                            MessageBox.Show("Cet utilisateur existe deja dans la base de données");
                        }

                    }
                    catch (NullReferenceException)
                    {
                        userhandlingconn.Close();
                        string adduser = "INSERT INTO Users ( username, [password], last_connexion, type_user ) values ('" + newuser + "','" + newmdp + "',Date(),'" + comboBox1.SelectedItem.ToString() + "');";
                        userhandlingconn.Open();
                        cmduserhandling = new OleDbCommand(adduser, userhandlingconn);
                        cmduserhandling.ExecuteNonQuery();
                        MessageBox.Show("Ajout effectué");
                        userhandlingconn.Close();
                    }
                    
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Erreur !!!");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedItem = "";
                DataReload();
            }
            
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            string newuser = textBox1.Text;
            string newmdp = textBox2.Text;
            comboBox1.SelectedItem = "caissier";
            try
            {

            if(oldpassword == "" || oldusername =="" || comboBox1.SelectedItem.ToString().Length==0 || textBox2.Text.Length==0)
            {
                MessageBox.Show("Veuillez selectionner un utilisateur a modifier et/ou completer certains champs");
            }
            else
            {
            
            string upduser = "UPDATE Users SET Users.[username] ='"+newuser+"', Users.[password] ='"+newmdp+"' WHERE (((Users.[username])='"+oldusername+"')) OR (((Users.[password])='"+oldpassword+"'));";
            OleDbConnection userhandlingconn = new OleDbConnection(connexionstring);
            OleDbCommand cmduserhandling = new OleDbCommand();
            cmduserhandling = new OleDbCommand(upduser, userhandlingconn);
            userhandlingconn.Open();
            cmduserhandling.ExecuteNonQuery();
            MessageBox.Show("Modification effectué");
            DataReload();
            }
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
               // MessageBox.Show("Erreur !!!");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedItem = "";
                DataReload();
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                string test = "SELECT username FROM Users where username='"+oldusername+"' OR password='"+oldpassword+"'";
                OleDbConnection userhandlingconn = new OleDbConnection(connexionstring);
                    OleDbCommand cmduserhandling = new OleDbCommand();
                    userhandlingconn.Open();
                    cmduserhandling = new OleDbCommand(test, userhandlingconn);
                string verif = cmduserhandling.ExecuteScalar().ToString();
                userhandlingconn.Close();
                if(verif.Length>0)
                {
                    
            string deluser = "DELETE * FROM Users where username ='"+oldusername+"' OR password='"+oldpassword+"'";
         
            userhandlingconn.Open();
            cmduserhandling = new OleDbCommand(deluser, userhandlingconn);
            cmduserhandling.ExecuteNonQuery();
            
            MessageBox.Show("Suppresion effectue");
            userhandlingconn.Close();
            DataReload();
                }
               
             }
            catch(Exception ex)
            {
                MessageBox.Show("Veuillez selectionner un utilisateur a supprimer");
                //MessageBox.Show(ex.ToString());
               // MessageBox.Show("Erreur !!!");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedItem = "";
                DataReload();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentCellAddress.X.Equals(0))
            {
                oldusername = dataGridView1.CurrentCell.Value.ToString();
                oldpassword = dataGridView1.CurrentCell.Value.ToString();
                textBox1.Text = dataGridView1.CurrentCell.Value.ToString();
                textBox2.Text = "123456";
                comboBox1.SelectedItem = "caissier";
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
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
               // MessageBox.Show("Erreur !!! ");


            }
        }

        private void WhipeData(DataGridView a, DataTable b)
        {

            b.Clear();
            a.DataBindings.Clear();
            a.DataSource = null;

        }

        private void UserHandlingForm_Load(object sender, EventArgs e)
        {
            DataReload();
               
        }
       
    }
}
