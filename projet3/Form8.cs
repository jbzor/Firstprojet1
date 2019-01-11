using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace projet3
{
    public partial class Form8 : Form
    {
        MySqlConnection cnx;
        MySqlCommand cmd;

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            String chaine = "Database=gescol; Data Source=localhost; User Id=root; password=";
            cnx = new MySqlConnection(chaine);

        }
    }
}
