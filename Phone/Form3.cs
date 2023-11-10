using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace Phone
{
    public partial class Form3 : KryptonForm
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=password;database=phones");
        string id_p;
        public Form3(string id)
        {
            InitializeComponent();
            id_p = id;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.MaximumSize = new Size(500, 0);

            conn.Open();

            string query = "SELECT name_phone, desc_phone, img from phones.models where id_phone=" + id_p;

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                kryptonLabel1.Text = reader.GetString("name_phone");
                label1.Text = reader.GetString("desc_phone");
                var imageData = (byte[])reader["img"];
                var memroyStream = new MemoryStream(imageData);
                pictureBox1.Image = Image.FromStream(memroyStream);
            }
            

            conn.Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm= new Form2();
            frm.ShowDialog();
        }
    }
}
