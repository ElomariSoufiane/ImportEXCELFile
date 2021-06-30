namespace ImportExcel
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
            this.DgvAjout = new System.Windows.Forms.DataGridView();
            this.btnCharger = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAjout)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAjout
            // 
            this.DgvAjout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAjout.Location = new System.Drawing.Point(12, 12);
            this.DgvAjout.Name = "DgvAjout";
            this.DgvAjout.Size = new System.Drawing.Size(1392, 578);
            this.DgvAjout.TabIndex = 0;
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(1270, 610);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(134, 32);
            this.btnCharger.TabIndex = 1;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 676);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.DgvAjout);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAjout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAjout;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

