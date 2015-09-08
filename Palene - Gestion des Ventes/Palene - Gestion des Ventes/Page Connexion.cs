using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Palene___Gestion_des_Ventes
{
    public partial class Page_Connexion : Form
    {
        string connexionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/" + Environment.UserName + "/Documents/Palene_Gest_Vente.accdb;Persist Security Info=False";
        static string Mot_de_Passe = "elhadjfall";
        static string NomUser = "elhadjfa11";
        static string TypeUser = "caissier";
        private  string AdminCmd = "Connexion";
        private Form1 frmParent;
        
        public Page_Connexion()
        {
            InitializeComponent();
        }

        public Page_Connexion(string CmdAdmin, Form1 frm)
        {
            InitializeComponent();
            AdminCmd = CmdAdmin;
            frmParent = frm;


        }
     

        private void Valider_Click(object sender, EventArgs e)
        {
            OleDbConnection testconnexion = new OleDbConnection(connexionstring);
            OleDbCommand cmdconnexion = new OleDbCommand();
            string test = "select type_user from Users where username = '" + Username.Text + "' AND password = '" + Password.Text + "'";
            
               
            try
            {

                testconnexion.Open();
                cmdconnexion = new OleDbCommand(test, testconnexion);

                switch(AdminCmd)
                {
                    case "Connexion":
                        try
                        {
                            string stock = cmdconnexion.ExecuteScalar().ToString();
                            if (stock == "admin")
                            {
                                TypeUser = stock;
                                Form1 palene = new Form1();
                                palene.Opacity = 0;
                                palene.Visible = false;
                                palene.Show();
                                this.Hide();
                                palene.Visible = true;
                                palene.Opacity = 100;
                                palene.ValeurTypeUser = stock;
                                palene.ValeurMdpasse = Password.Text;
                                palene.ValeurUsername = Username.Text;
                                palene.UpdateData("UPDATE Users SET Users.[last_connexion] =Date()  WHERE (((Users.[username])='" + Username.Text + "')) OR (((Users.[password])='" + Password.Text + "'));");

                            }
                            else if (stock == "caissier")
                            {
                                Form1 palene = new Form1();
                                palene.Opacity = 0;
                                palene.Visible = false;
                                palene.Show();
                                this.Hide();
                                palene.Visible = true;
                                palene.Opacity = 100;
                                palene.ValeurTypeUser = stock;
                                palene.ValeurMdpasse = Password.Text;
                                palene.ValeurUsername = Username.Text;
                                palene.UpdateData("UPDATE Users SET Users.[last_connexion] =Date()  WHERE (((Users.[username])='" + Username.Text + "')) OR (((Users.[password])='" + Password.Text + "'));");

                            }
                            else
                            {
                                MessageBox.Show("Erreur Nom d'utilisateur ou Mot de Passe Erroné !!!");
                            }
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Erreur Nom d'utilisateur ou Mot de Passe Erroné !!!");
                        }
                break;
                    case "Stock":
                try
                {
                    string stock = cmdconnexion.ExecuteScalar().ToString();
                    if (stock == "admin")
                    {
                        TypeUser = stock;
                        Form1 palene = new Form1();
                        palene.Opacity = 0;
                        palene.Visible = false;
                        palene.Show();
                        this.Hide();
                        palene.Visible = true;
                        palene.Opacity = 100;
                        palene.ValeurTypeUser = stock;
                        palene.ValeurMdpasse = Password.Text;
                        palene.ValeurUsername = Username.Text;
                        palene.UpdateData("UPDATE Users SET Users.[last_connexion] =Date()  WHERE (((Users.[username])='" + Username.Text + "')) OR (((Users.[password])='" + Password.Text + "'));");

                    }
                    else if (stock == "caissier")
                    {
                        Form1 palene = new Form1();
                        palene.Opacity = 0;
                        palene.Visible = false;
                        palene.Show();
                        this.Hide();
                        palene.Visible = true;
                        palene.Opacity = 100;
                        palene.ValeurTypeUser = stock;
                        palene.ValeurMdpasse = Password.Text;
                        palene.ValeurUsername = Username.Text;
                        palene.UpdateData("UPDATE Users SET Users.[last_connexion] =Date()  WHERE (((Users.[username])='" + Username.Text + "')) OR (((Users.[password])='" + Password.Text + "'));");

                    }
                    else
                    {
                        MessageBox.Show("Erreur Nom d'utilisateur ou Mot de Passe Erroné !!!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur Nom d'utilisateur ou Mot de Passe Erroné !!!");
                }
                        break;
                    case "Etat":
                        try
                        {
                            string stock = cmdconnexion.ExecuteScalar().ToString();
                            if (stock == "admin")
                            {
                                TypeUser = stock;
                                Form1 palene = new Form1();
                                palene.Opacity = 0;
                                palene.Visible = false;
                                palene.Show();
                                this.Hide();
                                palene.Visible = true;
                                palene.Opacity = 100;
                                palene.ValeurTypeUser = stock;
                                palene.ValeurMdpasse = Password.Text;
                                palene.ValeurUsername = Username.Text;
                                palene.UpdateData("UPDATE Users SET Users.[last_connexion] =Date()  WHERE (((Users.[username])='" + Username.Text + "')) OR (((Users.[password])='" + Password.Text + "'));");

                            }
                            else if (stock == "caissier")
                            {
                                Form1 palene = new Form1();
                                palene.Opacity = 0;
                                palene.Visible = false;
                                palene.Show();
                                this.Hide();
                                palene.Visible = true;
                                palene.Opacity = 100;
                                palene.ValeurTypeUser = stock;
                                palene.ValeurMdpasse = Password.Text;
                                palene.ValeurUsername = Username.Text;
                                palene.UpdateData("UPDATE Users SET Users.[last_connexion] =Date()  WHERE (((Users.[username])='" + Username.Text + "')) OR (((Users.[password])='" + Password.Text + "'));");

                            }
                            else
                            {
                                MessageBox.Show("Erreur Nom d'utilisateur ou Mot de Passe Erroné !!!");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erreur Nom d'utilisateur ou Mot de Passe Erroné !!!");
                        }
                        break;
                    default :
                        break;
            }
            }
            catch(Exception)
            {
                MessageBox.Show("Erreur de Connexion !!! Veuillez ressayer SVP");

            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            
            try
            {
                switch (AdminCmd)
                {
                    case "Connexion":
                       
                            Username.Text = "";
                            Password.Text = "";
                            break;
                    case "Stock":
                            this.Hide();
                            frmParent.Show();
                        break;
                    case "Etat":
                        this.Hide();
                            frmParent.Show();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Erreur !!!");
            }
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(Password.UseSystemPasswordChar == true)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
	        {
        Password.UseSystemPasswordChar = true;
	        }

        }

        private void Page_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void Page_Connexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
       

     
    }
}
