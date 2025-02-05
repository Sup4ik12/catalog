using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace каталог
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            filtrPanel.Height = hideBut.Height;
        }

        private void hideBut_Click(object sender, EventArgs e)
        {
            if(filtrPanel.Height>hideBut.Height)
            {
                filtrPanel.Height = hideBut.Height;
                hideBut.Text = "Развернуть";
            }
            else
            {
                filtrPanel.Height = 131;
                hideBut.Text = "Свернуть";
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
        }
    }
}
