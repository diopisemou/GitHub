namespace Palene___Gestion_des_Ventes
{
    partial class avertstock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RuptStockdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RuptStockdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RuptStockdataGridView
            // 
            this.RuptStockdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RuptStockdataGridView.Location = new System.Drawing.Point(12, 87);
            this.RuptStockdataGridView.Name = "RuptStockdataGridView";
            this.RuptStockdataGridView.Size = new System.Drawing.Size(759, 272);
            this.RuptStockdataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mesquite Std", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(198, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attention ces produit sont en rupture de stock";
            // 
            // avertstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RuptStockdataGridView);
            this.Name = "avertstock";
            this.Text = "avertstock";
            this.Load += new System.EventHandler(this.avertstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RuptStockdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RuptStockdataGridView;
        private System.Windows.Forms.Label label1;
    }
}