using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ImportExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private string ExcelConnection(string fileName)
        {
            return @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                   @"Data Source=" + fileName + ";" +
                   @"Extended Properties=" + Convert.ToChar(34).ToString() +
                   @"Excel 12.0 xml" + Convert.ToChar(34).ToString() + ";";
        }
        private void btnCharger_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string Fichier = openFileDialog1.FileName;
            DataSet dat = default(DataSet);
            dat = new DataSet();

            using (OleDbConnection Conn =
                new OleDbConnection(ExcelConnection(Fichier))) 
            {
                Conn.Open();
                //délaration du DataAdapter
                //notre requete sélectionne toute les cellules de la feuille spécifié

                using (OleDbDataAdapter adap = new OleDbDataAdapter("select * from [Transport$]", Conn))
                {
                    adap.TableMappings.Add("Table", "TestTable");
                    //Chargement du Dataset
                    adap.Fill(dat);
                    //On Charge les données sur le DGV
                    DgvAjout.DataSource = dat.Tables[0];
                }
                //libèrer les ressources 
                Conn.Close();
            }
        }
    }
}
    

