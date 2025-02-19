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

    public partial class GameForm : Form
    {
        public GameForm(string name)
        {
            InitializeComponent();
            Text = name;
            nameLab.Text = name;
            gamePic.Load("../../pictures/" + name + ".jpg");
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
