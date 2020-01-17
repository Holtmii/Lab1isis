using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Text.RegularExpressions;
using System.Xml.Linq;



namespace WindowsFormsApp1
{
    public partial class Child : Form
    {

    
        public Child()
        {
            InitializeComponent();

        }


        string MyFName = "";
        private void button1_Click(object sender, EventArgs e) 
        {
            label3.Text = " ";
            openFileDialog1.Filter = "Текстовые файлы  (*.txt) | *.txt;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyFName = openFileDialog1.FileName;
                richTextBox1.LoadFile(MyFName, RichTextBoxStreamType.PlainText);
            }
        }

        private void загрузитьТекстовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = " ";
            openFileDialog1.Filter = "Текстовые файлы  (*.txt) | *.txt;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyFName = openFileDialog1.FileName;
                richTextBox1.LoadFile(MyFName, RichTextBoxStreamType.PlainText);
            }
            
        }

       

       

       

       


       

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != String.Empty)
            {
                label3.Text = " ";
                button4.Enabled = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.RowCount = 10;
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].HeaderText = "Длинна";
                dataGridView1.Columns[1].HeaderText = "Количество";
                dataGridView1.Columns[2].HeaderText = "Частота,%";

                string[] s = richTextBox1.Lines;
                int[] array = new int[10];
                char[] delimiters = new char[] { ' ', '\r', '\n', ',', '?', '-', '!' };


                int countOfLet = 0;
                double sum = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    string[] newString = s[i].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < newString.Length; j++)
                    {

                        countOfLet = newString[j].Length;

                        if (countOfLet < 11)
                            array[countOfLet - 1] = array[countOfLet - 1] + 1;
                    }




                    countOfLet = 0;
                }


                for (int p = 0; p < array.Length; p++)
                {

                    sum = sum + array[p];
                }


                for (int k = 0; k < array.Length; k++)
                {
                    dataGridView1.Rows[k].Cells[0].Value = k + 1;
                    dataGridView1.Rows[k].Cells[1].Value = array[k];
                    dataGridView1.Rows[k].Cells[2].Value = Math.Round(((array[k] * 100) / sum), 2);
                }
            }
            else label3.Text = "Загрузите текст!";
        }

        private void статистикаВВидеТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != String.Empty)
            {
                label3.Text = " ";
                button4.Enabled = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.RowCount = 10;
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].HeaderText = "Длинна";
                dataGridView1.Columns[1].HeaderText = "Количество";
                dataGridView1.Columns[2].HeaderText = "Частота,%";

                string[] s = richTextBox1.Lines;
                int[] array = new int[10];
                char[] delimiters = new char[] { ' ', '\r', '\n', ',', '?', '-', '!' };


                int countOfLet = 0;
                double sum = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    string[] newString = s[i].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < newString.Length; j++)
                    {

                        countOfLet = newString[j].Length;

                        if (countOfLet < 11)
                            array[countOfLet - 1] = array[countOfLet - 1] + 1;
                    }




                    countOfLet = 0;
                }


                for (int p = 0; p < array.Length; p++)
                {

                    sum = sum + array[p];
                }


                for (int k = 0; k < array.Length; k++)
                {
                    dataGridView1.Rows[k].Cells[0].Value = k + 1;
                    dataGridView1.Rows[k].Cells[1].Value = array[k];
                    dataGridView1.Rows[k].Cells[2].Value = Math.Round(((array[k] * 100) / sum), 2);
                }
            }

            else label3.Text= "Загрузите текст!";

        }

       

       

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button4.Enabled = true;
           
            richTextBox1.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
           
            label3.Text = " ";
        }

        private void очиститьПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button4.Enabled = true;
            
            richTextBox1.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
          
            label3.Text = " ";
        }

      

        private Control GetControl(Control control, string name)
        {
            var fetchedControl = control.Controls[name];
            if (fetchedControl == null)
                foreach (Control c in control.Controls)
                {
                    fetchedControl = GetControl(c, name);
                    if (fetchedControl != null)
                        break;
                }
            return fetchedControl;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //int rowCounter = dataGridView1.RowCount;
            //int columnCount = dataGridView1.ColumnCount;
            //string[] line = new string[columnCount];
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "XML Files (*.txt)|*.txt";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    using (StreamWriter writer = new StreamWriter(sfd.FileName))
            //    {
            //        for (int i = 0; i < dataGridView1.RowCount; i++)
            //        {
            //            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            //            {
            //                line[j] = (string)(Convert.ToString(dataGridView1.Rows[i].Cells[j].Value));
            //            }
            //            writer.WriteLine(string.Join(";", line));
            //        }
            //    }
            //}

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "слова";
            dt.Columns.Add("Длинна");
            dt.Columns.Add("Количество");
            dt.Columns.Add("Частота");
            ds.Tables.Add(dt);

            var grid = GetControl(this, "grid") as DataGridView;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row = ds.Tables["слова"].NewRow();
                row["Длинна"] = r.Cells[0].Value;
                row["Количество"] = r.Cells[1].Value;
                row["Частота"] = r.Cells[2].Value;
                ds.Tables["слова"].Rows.Add(row);
            }
            ds.WriteXml(Environment.CurrentDirectory + "\\Data.xml");
            MessageBox.Show("XML файл успешно сохранен.", "Выполнено.");




        }

        private void копированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Child_FormClosing(object sender, FormClosingEventArgs e)
        {
            string s = richTextBox1.Text;
            Cl_ini ini = new Cl_ini("my.ini");
            ini.Write("F_Width", Convert.ToString(this.Size.Width));
            ini.Write("F_Max_Width", Convert.ToString(this.MaximumSize.Width));
            ini.Write("F_Min_Width", Convert.ToString(this.MinimumSize.Width));
            ini.Write("F_Height", Convert.ToString(this.Size.Height));
            ini.Write("F_Max_Height", Convert.ToString(this.MaximumSize.Height));
            ini.Write("F_Min_Height", Convert.ToString(this.MinimumSize.Height));
            ini.Write("RB_Width", Convert.ToString(richTextBox1.Size.Width));
            ini.Write("RB_Height", Convert.ToString(richTextBox1.Size.Height));
            ini.Write("RB_Max_Height", Convert.ToString(richTextBox1.MaximumSize.Height));
            ini.Write("RB_Max_Width", Convert.ToString(richTextBox1.MaximumSize.Width));
           
            if (MyFName != "")
                ini.Write("Pathtext", MyFName);

        }

        private void Child_Load(object sender, EventArgs e)
        {
            Cl_ini ini=new Cl_ini("my.ini");
            try
            {
                Width = Convert.ToInt32(ini.Read("FWidth"));
                Height = Convert.ToInt32(ini.Read("FHeight"));
            
                   
            }

            catch { };
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }
    }
    }

