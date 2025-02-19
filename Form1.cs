using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace каталог
{
    public struct Game
    {
        public string name;
        public string style;
        public string mode;
        public int price;
        public PictureBox pb;
        public Label lb;
        
        public Game(string _name, string _style,string _mode,int _price)
        {
            name = _name;
            style = _style;
            mode = _mode;
            price = _price;
            pb = new PictureBox();
            pb.Load("../../pictures/" + name + ".jpg");
            lb = new Label();
            lb.Text = name;

        }

    }
    public partial class mainForm : Form
    {
        Game[] gamelist = new Game[5];
        public mainForm()
        {
            InitializeComponent();
            filtrPanel.Height = hideBut.Height;


            gamelist[0] = new Game("Half-Life", "Шутер от первого лица", "однопользовательский", 200);
            gamelist[1] = new Game("Dota2", "Стратегия", "многопользовательский", 400);
            gamelist[2] = new Game("Mafia2", "Экшен", "однопользовательский", 300);
            gamelist[3] = new Game("Assassin`s Creed II", "Приключения", "однопользовательский", 100);
            gamelist[4] = new Game("S.T.A.L.K.E.R", "Ролевая игра", "однопользовательский", 500);


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
            PictureBox pb = (PictureBox)sender;

            GameForm gameForm = new GameForm(pb.Tag.ToString());
            gameForm.ShowDialog();

        }

  
    }
}
