using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace каталог
{
    public partial class GameForm : Form
    {
        public GameForm(Game game)
        {
            InitializeComponent();
            Text = game.name;
            nameLab.Text = "Название: "+game.name;
            gamePic.Image = game.pb.Image;        
            styleLab.Text = "Жанр: "+game.style;
            priceLab.Text = "Цена: $" + game.price;
            deskText.Text = File.ReadAllText("../../pictures/" + game.name + ".txt");
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
