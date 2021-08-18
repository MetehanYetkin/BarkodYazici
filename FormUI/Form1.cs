using Bussiness.Concrate;
using DataAccess.EntityFramework;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> addList = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
             string üretici = comboBox1.SelectedItem.ToString();
           
                addList.Add(üretici.Substring(0,1));
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malzeme = comboBox2.SelectedItem.ToString();
            addList.Add(malzeme);
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makaraTipi = comboBox3.SelectedItem.ToString();
            addList.Add(makaraTipi.Substring(0,1));

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string üretimAyı = comboBox4.SelectedItem.ToString();
            addList.Add(üretimAyı);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string üretimYılı = comboBox5.SelectedItem.ToString();
            addList.Add(üretimYılı.Substring(0,2));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        public void button1_Click(object sender, EventArgs e)
        {
            string üretici = comboBox1.SelectedItem.ToString().Substring(0,1);
            string malzeme = comboBox2.SelectedItem.ToString();
            string makaraTipi = comboBox3.SelectedItem.ToString().Substring(0,1);
            string üretimAyı = comboBox4.SelectedItem.ToString();
            string üretimYılı = comboBox5.SelectedItem.ToString().Substring(0,2);
            textBox1.Text = üretimYılı + üretimAyı + makaraTipi + malzeme + üretici;
            BarkodManager barkodManager = new BarkodManager(new EfBarkodDal());
            Barkod _barkod;
            _barkod = new Barkod
            {
                Material = malzeme,
                MonthOfProduction = üretimAyı,
                Producer = üretici,
                PulleyType = Convert.ToInt32(makaraTipi),
                //UniqueNumber = 007,
                YearOfProduction = Convert.ToInt32(üretimYılı),
            };
            barkodManager.Add(_barkod);



        }

    }
}
