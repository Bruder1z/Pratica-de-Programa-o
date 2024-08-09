using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
   namespace ParaCasa1
{
    public partial class CadLivrosUIL : Form
    {
        Livro umlivro = new Livro();
        public CadLivrosUIL()
        {
            InitializeComponent();
        }

        private void CadLivrosUIL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDLivrosDataSet.TabLivro' table. You can move, or remove it, as needed.
            this.tabLivroTableAdapter.Fill(this.bDLivrosDataSet.TabLivro);
            LivroBLL.inicializa();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                Application.Exit();
            }
        }

        private void CadLivrosUIL_FormClosed(object sender, FormClosedEventArgs e)
        {
            LivroBLL.finaliza();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            bDLivrosDataSet.WriteXml("teste.Xml");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(bDLivrosDataSet);
            Console.WriteLine(json);
            File.WriteAllText("teste.json", json);
        }
    }
}
