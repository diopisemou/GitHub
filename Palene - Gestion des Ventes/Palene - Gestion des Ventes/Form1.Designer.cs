namespace Palene___Gestion_des_Ventes
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Vendre = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.Article_textBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Vendue = new System.Windows.Forms.TabPage();
            this.QuantVendue_textBox = new System.Windows.Forms.TextBox();
            this.Quantité = new System.Windows.Forms.Label();
            this.Prix = new System.Windows.Forms.Label();
            this.Article = new System.Windows.Forms.Label();
            this.Prix_textBox2 = new System.Windows.Forms.TextBox();
            this.Vente_JourdataGridView = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.TabPage();
            this.Supprimer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Annuler_Ajout = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Prix_textBox = new System.Windows.Forms.TextBox();
            this.QuantInitial_textBox = new System.Windows.Forms.TextBox();
            this.Designation_textBox = new System.Windows.Forms.TextBox();
            this.Stock_dataGridView = new System.Windows.Forms.DataGridView();
            this.Historique = new System.Windows.Forms.TabPage();
            this.Historique_dataGridView = new System.Windows.Forms.DataGridView();
            this.Etat = new System.Windows.Forms.TabPage();
            this.lstARReports = new System.Windows.Forms.ListBox();
            this.Imprimer = new System.Windows.Forms.Button();
            this.Chercher = new System.Windows.Forms.Button();
            this.APropos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GererUser = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Deconnexion = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Vendue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vente_JourdataGridView)).BeginInit();
            this.Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_dataGridView)).BeginInit();
            this.Historique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Historique_dataGridView)).BeginInit();
            this.Etat.SuspendLayout();
            this.APropos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vendre
            // 
            this.Vendre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Vendre.Location = new System.Drawing.Point(507, 231);
            this.Vendre.Name = "Vendre";
            this.Vendre.Size = new System.Drawing.Size(82, 23);
            this.Vendre.TabIndex = 0;
            this.Vendre.Text = "Vendre";
            this.Vendre.UseVisualStyleBackColor = true;
            this.Vendre.Click += new System.EventHandler(this.Vendre_Click);
            // 
            // Annuler
            // 
            this.Annuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Annuler.Location = new System.Drawing.Point(623, 231);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(70, 23);
            this.Annuler.TabIndex = 1;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Article_textBox
            // 
            this.Article_textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Affroid",
            "Allume Feu",
            "Ande/ \'Encensoire\'",
            "Assiette Plastique",
            "Bain de Bouche",
            "Baque",
            "Baque à Glace",
            "Barquette",
            "Bec à Gaz",
            "Biberon",
            "Bonnet",
            "Bougie",
            "Bouteille Vide",
            "Brochette",
            "Brosse à Dent",
            "Brosse Pied",
            "Brosse Toillete",
            "Carafe",
            "Chauffe Eau",
            "Chouchou",
            "Cirage",
            "Coton Tige",
            "Couche Belle",
            "Coupe Œuf",
            "Couteaux",
            "Crayon",
            "Creme Main",
            "Créme Pied",
            "Cure Dent",
            "Debouchoire",
            "Démaquillant",
            "Démélant",
            "Detergent",
            "Dis",
            "Dissolvant",
            "Diviseur Lave Main",
            "easgone",
            "Eau de Cologne",
            "Eau de Javel",
            "Emaille",
            "Emporte Pieces",
            "Enleve Tartre",
            "Eponge",
            "Eponge Nettoiante",
            "Etuit Brosse à Dent",
            "EyeLiner",
            "Fond de Tein",
            "Fouet",
            "Fourchettes",
            "Gant",
            "Gant de Bain",
            "Gel Bebe",
            "Glaciere",
            "Glaçon en Plastique",
            "Gommage",
            "Gourde",
            "Huile Cheveux",
            "Huile Massage",
            "Insecticide Deodorisant",
            "Krik",
            "Lait de Cheveux",
            "Lait de Corps",
            "Lait Insecte",
            "Lave Main",
            "Lave Vaisselle",
            "Lave Vitre",
            "Lignes",
            "Lingette",
            "LipoLevre",
            "Liquide apres Rasage",
            "Machine Broyeuse",
            "Mascara",
            "Mousitquaire Electrique",
            "Mousse à Raser",
            "Nana",
            "Nappe de Table",
            "Omo",
            "Paille",
            "Papier Aluminium",
            "Papier Film",
            "Papier Toilette",
            "Paquet Lime",
            "Parapluie",
            "Parfum de Chambre",
            "Parfum Femme",
            "Parfum Homme",
            "Parfum Toilette",
            "Pate Dentifrice",
            "Peigne",
            "Pele",
            "Pince à Linge",
            "Pinceau",
            "Plat à Jeter",
            "Plumot",
            "Poele",
            "Pommade",
            "Pompe à Bois",
            "Pompe à Eau",
            "Port Savon",
            "Porte Assiette",
            "Pot de Sucre",
            "Poubelle",
            "Poudre",
            "Poudre Insecte",
            "Protege Slip",
            "Purificateur",
            "Raclette",
            "Rasoire",
            "Rougé à Levre",
            "Rouleau Mouchoire",
            "Sachets Poubelle",
            "Savons",
            "Sechoire",
            "Semelles",
            "Serpier",
            "Serviette",
            "Shampoing Bebe",
            "Soucoupe",
            "Support Mouchoire",
            "Tasse à jeter",
            "Tasse Brosse",
            "Tasse Verre",
            "Termosse",
            "Tetine",
            "Thé",
            "Torchon",
            "Vaseline",
            "Verre",
            "Vitamine",
            "Wave"});
            this.Article_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Article_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Article_textBox.Location = new System.Drawing.Point(557, 45);
            this.Article_textBox.Name = "Article_textBox";
            this.Article_textBox.Size = new System.Drawing.Size(136, 20);
            this.Article_textBox.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Vendue);
            this.tabControl1.Controls.Add(this.Stock);
            this.tabControl1.Controls.Add(this.Historique);
            this.tabControl1.Controls.Add(this.Etat);
            this.tabControl1.Controls.Add(this.APropos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 346);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // Vendue
            // 
            this.Vendue.Controls.Add(this.textBox2);
            this.Vendue.Controls.Add(this.QuantVendue_textBox);
            this.Vendue.Controls.Add(this.Quantité);
            this.Vendue.Controls.Add(this.Prix);
            this.Vendue.Controls.Add(this.Article);
            this.Vendue.Controls.Add(this.Prix_textBox2);
            this.Vendue.Controls.Add(this.Annuler);
            this.Vendue.Controls.Add(this.Article_textBox);
            this.Vendue.Controls.Add(this.Vente_JourdataGridView);
            this.Vendue.Controls.Add(this.Vendre);
            this.Vendue.Location = new System.Drawing.Point(4, 22);
            this.Vendue.Name = "Vendue";
            this.Vendue.Padding = new System.Windows.Forms.Padding(3);
            this.Vendue.Size = new System.Drawing.Size(733, 320);
            this.Vendue.TabIndex = 0;
            this.Vendue.Text = "Vente Journaliére";
            this.Vendue.UseVisualStyleBackColor = true;
            // 
            // QuantVendue_textBox
            // 
            this.QuantVendue_textBox.Location = new System.Drawing.Point(557, 141);
            this.QuantVendue_textBox.Name = "QuantVendue_textBox";
            this.QuantVendue_textBox.Size = new System.Drawing.Size(136, 20);
            this.QuantVendue_textBox.TabIndex = 8;
            // 
            // Quantité
            // 
            this.Quantité.AutoSize = true;
            this.Quantité.Location = new System.Drawing.Point(504, 144);
            this.Quantité.Name = "Quantité";
            this.Quantité.Size = new System.Drawing.Size(47, 13);
            this.Quantité.TabIndex = 7;
            this.Quantité.Text = "Quantité";
            // 
            // Prix
            // 
            this.Prix.AutoSize = true;
            this.Prix.Location = new System.Drawing.Point(504, 92);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(24, 13);
            this.Prix.TabIndex = 6;
            this.Prix.Text = "Prix";
            // 
            // Article
            // 
            this.Article.AutoSize = true;
            this.Article.Location = new System.Drawing.Point(504, 48);
            this.Article.Name = "Article";
            this.Article.Size = new System.Drawing.Size(36, 13);
            this.Article.TabIndex = 5;
            this.Article.Text = "Article";
            // 
            // Prix_textBox2
            // 
            this.Prix_textBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "200",
            "250",
            "300",
            "500",
            "600",
            "750",
            "800",
            "1000",
            "1250",
            "1500",
            "2000",
            "2500",
            "3000",
            "3500",
            "4000",
            "5000",
            "7500"});
            this.Prix_textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Prix_textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Prix_textBox2.Location = new System.Drawing.Point(557, 92);
            this.Prix_textBox2.Name = "Prix_textBox2";
            this.Prix_textBox2.Size = new System.Drawing.Size(136, 20);
            this.Prix_textBox2.TabIndex = 4;
            // 
            // Vente_JourdataGridView
            // 
            this.Vente_JourdataGridView.AllowUserToAddRows = false;
            this.Vente_JourdataGridView.AllowUserToDeleteRows = false;
            this.Vente_JourdataGridView.AllowUserToOrderColumns = true;
            this.Vente_JourdataGridView.BackgroundColor = System.Drawing.Color.LightCoral;
            this.Vente_JourdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Vente_JourdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Vente_JourdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vente_JourdataGridView.Location = new System.Drawing.Point(3, 3);
            this.Vente_JourdataGridView.Name = "Vente_JourdataGridView";
            this.Vente_JourdataGridView.ReadOnly = true;
            this.Vente_JourdataGridView.Size = new System.Drawing.Size(487, 314);
            this.Vente_JourdataGridView.TabIndex = 1;
            this.Vente_JourdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Stock
            // 
            this.Stock.Controls.Add(this.Supprimer);
            this.Stock.Controls.Add(this.textBox1);
            this.Stock.Controls.Add(this.label4);
            this.Stock.Controls.Add(this.Annuler_Ajout);
            this.Stock.Controls.Add(this.Ajouter);
            this.Stock.Controls.Add(this.label3);
            this.Stock.Controls.Add(this.label2);
            this.Stock.Controls.Add(this.label1);
            this.Stock.Controls.Add(this.Prix_textBox);
            this.Stock.Controls.Add(this.QuantInitial_textBox);
            this.Stock.Controls.Add(this.Designation_textBox);
            this.Stock.Controls.Add(this.Stock_dataGridView);
            this.Stock.Location = new System.Drawing.Point(4, 22);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(3);
            this.Stock.Size = new System.Drawing.Size(733, 320);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stock_MouseClick);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(591, 255);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 13;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(618, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prix de Vente :";
            // 
            // Annuler_Ajout
            // 
            this.Annuler_Ajout.Location = new System.Drawing.Point(643, 196);
            this.Annuler_Ajout.Name = "Annuler_Ajout";
            this.Annuler_Ajout.Size = new System.Drawing.Size(75, 23);
            this.Annuler_Ajout.TabIndex = 10;
            this.Annuler_Ajout.Text = "Annuler";
            this.Annuler_Ajout.UseVisualStyleBackColor = true;
            this.Annuler_Ajout.Click += new System.EventHandler(this.Annuler_Ajout_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(544, 196);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 9;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prix d\'Achat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantité Initial :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Designation :";
            // 
            // Prix_textBox
            // 
            this.Prix_textBox.Location = new System.Drawing.Point(618, 129);
            this.Prix_textBox.Name = "Prix_textBox";
            this.Prix_textBox.Size = new System.Drawing.Size(100, 20);
            this.Prix_textBox.TabIndex = 3;
            // 
            // QuantInitial_textBox
            // 
            this.QuantInitial_textBox.Location = new System.Drawing.Point(618, 103);
            this.QuantInitial_textBox.Name = "QuantInitial_textBox";
            this.QuantInitial_textBox.Size = new System.Drawing.Size(100, 20);
            this.QuantInitial_textBox.TabIndex = 2;
            // 
            // Designation_textBox
            // 
            this.Designation_textBox.Location = new System.Drawing.Point(618, 77);
            this.Designation_textBox.Name = "Designation_textBox";
            this.Designation_textBox.Size = new System.Drawing.Size(100, 20);
            this.Designation_textBox.TabIndex = 1;
            // 
            // Stock_dataGridView
            // 
            this.Stock_dataGridView.AllowUserToAddRows = false;
            this.Stock_dataGridView.AllowUserToDeleteRows = false;
            this.Stock_dataGridView.AllowUserToOrderColumns = true;
            this.Stock_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stock_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.Stock_dataGridView.Name = "Stock_dataGridView";
            this.Stock_dataGridView.ReadOnly = true;
            this.Stock_dataGridView.Size = new System.Drawing.Size(487, 314);
            this.Stock_dataGridView.TabIndex = 0;
            this.Stock_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Historique
            // 
            this.Historique.Controls.Add(this.Historique_dataGridView);
            this.Historique.Location = new System.Drawing.Point(4, 22);
            this.Historique.Name = "Historique";
            this.Historique.Padding = new System.Windows.Forms.Padding(3);
            this.Historique.Size = new System.Drawing.Size(733, 320);
            this.Historique.TabIndex = 2;
            this.Historique.Text = "Historique";
            this.Historique.UseVisualStyleBackColor = true;
            // 
            // Historique_dataGridView
            // 
            this.Historique_dataGridView.AllowUserToAddRows = false;
            this.Historique_dataGridView.AllowUserToDeleteRows = false;
            this.Historique_dataGridView.AllowUserToOrderColumns = true;
            this.Historique_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Historique_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.Historique_dataGridView.Name = "Historique_dataGridView";
            this.Historique_dataGridView.ReadOnly = true;
            this.Historique_dataGridView.Size = new System.Drawing.Size(487, 314);
            this.Historique_dataGridView.TabIndex = 0;
            // 
            // Etat
            // 
            this.Etat.Controls.Add(this.lstARReports);
            this.Etat.Controls.Add(this.Imprimer);
            this.Etat.Controls.Add(this.Chercher);
            this.Etat.Location = new System.Drawing.Point(4, 22);
            this.Etat.Name = "Etat";
            this.Etat.Padding = new System.Windows.Forms.Padding(3);
            this.Etat.Size = new System.Drawing.Size(733, 320);
            this.Etat.TabIndex = 3;
            this.Etat.Text = "Etat";
            this.Etat.UseVisualStyleBackColor = true;
            // 
            // lstARReports
            // 
            this.lstARReports.FormattingEnabled = true;
            this.lstARReports.Location = new System.Drawing.Point(6, 6);
            this.lstARReports.Name = "lstARReports";
            this.lstARReports.Size = new System.Drawing.Size(384, 303);
            this.lstARReports.TabIndex = 2;
            // 
            // Imprimer
            // 
            this.Imprimer.Location = new System.Drawing.Point(589, 286);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(75, 23);
            this.Imprimer.TabIndex = 1;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = true;
            this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // Chercher
            // 
            this.Chercher.Location = new System.Drawing.Point(470, 286);
            this.Chercher.Name = "Chercher";
            this.Chercher.Size = new System.Drawing.Size(75, 23);
            this.Chercher.TabIndex = 0;
            this.Chercher.Text = "Generer";
            this.Chercher.UseVisualStyleBackColor = true;
            this.Chercher.Click += new System.EventHandler(this.Chercher_Click);
            // 
            // APropos
            // 
            this.APropos.Controls.Add(this.groupBox1);
            this.APropos.Location = new System.Drawing.Point(4, 22);
            this.APropos.Name = "APropos";
            this.APropos.Padding = new System.Windows.Forms.Padding(3);
            this.APropos.Size = new System.Drawing.Size(733, 320);
            this.APropos.TabIndex = 4;
            this.APropos.Text = "A propos";
            this.APropos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GererUser);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(213, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // GererUser
            // 
            this.GererUser.Location = new System.Drawing.Point(78, 200);
            this.GererUser.Name = "GererUser";
            this.GererUser.Size = new System.Drawing.Size(119, 23);
            this.GererUser.TabIndex = 1;
            this.GererUser.Text = "Gerer les Utilisateurs";
            this.GererUser.UseVisualStyleBackColor = true;
            this.GererUser.Click += new System.EventHandler(this.GererUser_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(6, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(273, 152);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Deconnexion
            // 
            this.Deconnexion.Location = new System.Drawing.Point(688, 12);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(79, 23);
            this.Deconnexion.TabIndex = 4;
            this.Deconnexion.Text = "Deconnexion";
            this.Deconnexion.UseVisualStyleBackColor = true;
            this.Deconnexion.Click += new System.EventHandler(this.Deconnexion_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(507, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.Vendre;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton = this.Annuler;
            this.ClientSize = new System.Drawing.Size(779, 346);
            this.Controls.Add(this.Deconnexion);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Palene - Boutique";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Vendue.ResumeLayout(false);
            this.Vendue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vente_JourdataGridView)).EndInit();
            this.Stock.ResumeLayout(false);
            this.Stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_dataGridView)).EndInit();
            this.Historique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Historique_dataGridView)).EndInit();
            this.Etat.ResumeLayout(false);
            this.APropos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vendre;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.TextBox Article_textBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Vendue;
        private System.Windows.Forms.TabPage Stock;
        private System.Windows.Forms.DataGridView Vente_JourdataGridView;
        private System.Windows.Forms.DataGridView Stock_dataGridView;
        private System.Windows.Forms.TextBox Prix_textBox2;
        private System.Windows.Forms.TabPage Historique;
        private System.Windows.Forms.DataGridView Historique_dataGridView;
        private System.Windows.Forms.TextBox QuantVendue_textBox;
        private System.Windows.Forms.Label Quantité;
        private System.Windows.Forms.Label Prix;
        private System.Windows.Forms.Label Article;
        private System.Windows.Forms.Button Annuler_Ajout;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prix_textBox;
        private System.Windows.Forms.TextBox QuantInitial_textBox;
        private System.Windows.Forms.TextBox Designation_textBox;
        private System.Windows.Forms.Button Deconnexion;
        private System.Windows.Forms.TabPage Etat;
        private System.Windows.Forms.Button Imprimer;
        private System.Windows.Forms.Button Chercher;
        private System.Windows.Forms.ListBox lstARReports;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.TabPage APropos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GererUser;
        private System.Windows.Forms.TextBox textBox2;
    }
}

