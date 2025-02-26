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
    public partial class LogForm: Form
    {
        public static string name;
        public static string surename;
        public LogForm()
        {
            InitializeComponent();
        }

        private void logBut_Click(object sender, EventArgs e)
        {
            string[] strs = System.IO.File.ReadAllLines("users.txt");
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                if(logText.Text == parts[2] && passText.Text == parts[3])
                {
                    name = parts[0];
                    surename = parts[1];
                    MessageBox.Show("Вы успешно вошли в свой аккаунт");
                    Close();
                    return;
                }
            }
            MessageBox.Show("указан неверный логин или пароль");
        }

 
    }
}
