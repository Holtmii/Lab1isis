using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class mdi : Form


    {
    
   
        public mdi()
        {
            InitializeComponent();

            
        }
       

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Child newForm = new Child();

            newForm.MdiParent = this;

            newForm.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)

                ActiveMdiChild.Close();

            
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            Form[] form = MdiChildren;

            foreach (Form f in form)

                f.Close();
        }

        private void каскадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void горизонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
