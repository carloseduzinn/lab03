using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class FormBuscarmagrm : Form
    {
        public FormBuscarmagrm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            openFileDialogbuscar.Filter = "Arquivos bmp| *.bmp | Arquivos jpg |*.jpg";
            openFileDialogbuscar.ShowDialog();
            if(openFileDialogbuscar.ShowDialog() == DialogResult.OK )
            {
                pictureBoxscreen.ImageLocation = openFileDialogbuscar.FileName;
            }
        }
    }
}
