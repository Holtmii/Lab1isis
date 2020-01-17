using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:64195/");
                HttpResponseMessage response = client.GetAsync("api/products").Result;
                var setting = response.Content.ReadAsAsync<IEnumerable<Settings>>().Result;
                serviceGrid.DataSource = setting;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cl_ini ini = new Cl_ini("my.ini");

            int formWidth = Convert.ToInt32(ini.Read("F_Width"));
            int formHeight = Convert.ToInt32(ini.Read("F_Max_Width"));
            int width = Convert.ToInt32(ini.Read("F_Min_Width"));
            int height = Convert.ToInt32(ini.Read("F_Height"));
            int width1 = Convert.ToInt32(ini.Read("F_Max_Height"));
            int height1 = Convert.ToInt32(ini.Read("F_Min_Height"));
            int width2 = Convert.ToInt32(ini.Read("RB_Width"));
            int height2 = Convert.ToInt32(ini.Read("RB_Height"));
            int width3 = Convert.ToInt32(ini.Read("RB_Max_Height"));
            int height3 = Convert.ToInt32(ini.Read("RB_Max_Width"));
            string firstpath = ini.Read("Pathtext");
          
            AddProduct("F_Width", Convert.ToString(formWidth));
            AddProduct("F_Max_Width", Convert.ToString(formHeight));
            AddProduct("F_Min_Width", Convert.ToString(width));
            AddProduct("F_Height", Convert.ToString(height));
            AddProduct("F_Max_Height", Convert.ToString(width1));
            AddProduct("F_Min_Height", Convert.ToString(height1));
            AddProduct("RB_Width", Convert.ToString(width2));
            AddProduct("RB_Height", Convert.ToString(height2));
            AddProduct("RB_Max_Height", Convert.ToString(width3));
            AddProduct("RB_Max_Width", Convert.ToString(height3));
            AddProduct("Pathtext", Convert.ToString(firstpath));
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AddProduct(textBox2.Text, textBox3.Text);
                MessageBox.Show("Настройка добавлена");
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void AddProduct(string name, string val)
        {
            Settings s = new Settings();
            s.Name = name;
            s.Value = val;
            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(s);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("http://localhost:64195/api/products", content);
            };
        }

        private async void DeleteProduct(int delid)
        {
            using (var client = new HttpClient())
            {
                var result = await client.DeleteAsync(String.Format("{0}/{1}", "http://localhost:64195/api/products", delid));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteProduct(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Настройка удалена");
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
