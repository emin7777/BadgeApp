using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace LocalDataBaseAppp
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KA79T7LO;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            label7.Parent = pictureBox1;
            label7.Top = label7.Top - 17;
            label7.Left = label7.Left - 50;
            label7.Font = new Font("Arial", 20, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)  //---Create source code---\\ 
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table1 (name, Surname, Age) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            MessageBox.Show("Daxil olundu..");
            disp_data();


        }

        public void disp_data()   //---Datani ekranda gosterir---\\
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name, Surname ,Age from Table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }

        private void Form1_Load(object sender, EventArgs e)  //------Country table -daki Olkelerin adlarini Badge e cixarir-------\\
        {
            disp_data();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Country ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[1].ToString());
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e) //---Delete source code---\\
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Table1 where name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Melumat silindi !");
            disp_data();
        }

        private void button3_Click(object sender, EventArgs e)  //---Update source code---\\
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Table1 set name='" + textBox1.Text + "' where name='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Melumat yenilendi");
            disp_data();
        }

        private void button5_Click(object sender, EventArgs e)  //---------Tab1 background source code----------\\
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                pictureBox1.ImageLocation = picPath;

            }
        }

        private void button6_Click(object sender, EventArgs e)  //-----3x4 picture source code------\\
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                pictureBox2.ImageLocation = picPath;
            }
        }

        private void button7_Click(object sender, EventArgs e)  //-Tab2 background source code \\
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                pictureBox3.ImageLocation = picPath;
            }
        }


        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)  //-----------  Data siyahidan Ad ve soyadi textboxa cixarir  --------------\\
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox5.Text = row.Cells["name"].Value.ToString();
                textBox5.Text += " " + row.Cells["Surname"].Value.ToString();

                
            }
        }



        //************************************************************    Buttons   ********************************************************************//

        private void cButtonclass1_Click(object sender, EventArgs e)

        {
            if (buttonno.BackColor == Color.Green)
            {
                buttonno.BackColor = Color.Blue;
            }
            else
            {
                buttonno.BackColor = Color.Green;
            }
        }

        private void cButtonclass1_Click_1(object sender, EventArgs e)
        {
            if (cButtonclass1.BackColor == Color.Green)
            {
                cButtonclass1.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass1.BackColor = Color.Green;
            }
        }

        private void cButtonclass2_Click(object sender, EventArgs e)
        {
            if (cButtonclass2.BackColor == Color.Green)
            {
                cButtonclass2.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass2.BackColor = Color.Green;
            }
        }

        private void cButtonclass3_Click(object sender, EventArgs e)
        {
            if (cButtonclass3.BackColor == Color.Green)
            {
                cButtonclass3.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass3.BackColor = Color.Green;
            }
        }

        private void cButtonclass4_Click(object sender, EventArgs e)
        {
            if (cButtonclass4.BackColor == Color.Green)
            {
                cButtonclass4.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass4.BackColor = Color.Green;
            }
        }

        private void cButtonclass5_Click(object sender, EventArgs e)
        {
            if (cButtonclass5.BackColor == Color.Green)
            {
                cButtonclass5.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass5.BackColor = Color.Green;
            }
        }

        private void cButtonclass6_Click(object sender, EventArgs e)
        {
            if (cButtonclass6.BackColor == Color.Green)
            {
                cButtonclass6.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass6.BackColor = Color.Green;
            }
        }

        private void cButtonclass7_Click(object sender, EventArgs e)
        {
            if (cButtonclass7.BackColor == Color.Green)
            {
                cButtonclass7.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass7.BackColor = Color.Green;
            }
        }

        private void cButtonclass8_Click(object sender, EventArgs e)
        {
            if (cButtonclass8.BackColor == Color.Green)
            {
                cButtonclass8.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass8.BackColor = Color.Green;
            }
        }

        private void cButtonclass9_Click(object sender, EventArgs e)
        {
            if (cButtonclass9.BackColor == Color.Green)
            {
                cButtonclass9.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass9.BackColor = Color.Green;
            }
        }

        private void cButtonclass10_Click(object sender, EventArgs e)
        {
            if (cButtonclass10.BackColor == Color.Green)
            {
                cButtonclass10.BackColor = Color.Blue;
            }
            else
            {
                cButtonclass10.BackColor = Color.Green;
            }
        }


        
        /// ////////////////////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)  ///////?????Combobox???????////////
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table2 ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string price = (string)dr["Price"].ToString();
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)     //Country combobox daki olkeleri badge e cixarir...\\
        {


            string queryString = "select * from Country where CountryN ='" + comboBox1.Text + "'";

            con.Open();

            SqlCommand command = new SqlCommand(queryString, con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                pictureBox4.ImageLocation = @"C:\Users\Emin\source\repos\LocalDataBaseAppp\LocalDataBaseAppp\Flags\" + reader[2].ToString();
                label5.Text = reader[1].ToString();
            }

            reader.Close();
            con.Close();
        }




        // Mission default olaraq deyisir.textboxa yazilir.\\\\


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label7.Text = textBox3.Text;
        }




        //Print Control\\
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
        ///////////?????????????????????????????????????????????????????????????//////////////////////////










        //******************************************************************----------------------------------*****************************************************************************\\







    }
}
