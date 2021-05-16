using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
namespace Meau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            Meau meau = new Meau();
            meau.section = Section_txt.Text;
            meau.name = Name_txt.Text;
            meau.description = description_txt.Text;
            meau.price = float.Parse(Price_txt.Text);
            XmlSerializer xs = new XmlSerializer(typeof(Meau));
            StreamWriter sw = new StreamWriter(@"E:\Modren Academy\year 3\part 2\Data Stroage\serialization & dserialization\Meau.xml");
            xs.Serialize(sw, meau);
            MessageBox.Show("Data Saved.");


        }

        private void restore_btn_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Meau));
            StreamReader sr = new StreamReader(@"E:\Modren Academy\year 3\part 2\Data Stroage\serialization & dserialization\Meau.xml");
            Meau meau = (Meau)xs.Deserialize(sr);
            Section_txt.Text = meau.section;
            Name_txt.Text = meau.name;
            description_txt.Text = meau.description;
            Price_txt.Text = meau.price.ToString();



        }
    }
}
