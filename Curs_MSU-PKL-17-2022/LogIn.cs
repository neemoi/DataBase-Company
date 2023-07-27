using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;

namespace Curs_MSU_PKL_17_2022
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void textBoxPasswordUser_TextChanged(object sender, EventArgs e)
        {
            textBoxPasswordUser.PasswordChar = '*';
            textBoxPasswordUser.MaxLength = 50;
            textBoxLoginUser.MaxLength = 50;
        }

        private void buttonLogUser_Click(object sender, EventArgs e)
        {
            string LogUser = textBoxLoginUser.Text;
            string PasUser = textBoxPasswordUser.Text;

            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (textBoxLoginUser.Text.Length > 0)
            {
                if (textBoxPasswordUser.Text.Length > 0)
                {
                    MySqlConnection connection = new MySqlConnection("server=localhost; port=8889; username=root; password=root; database=msu_pkl_17_2022; SSL Mode=None");
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @lu AND `Password` = @lp", connection);
                    command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = LogUser;
                    command.Parameters.Add("@lp", MySqlDbType.VarChar).Value = PasUser;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                }
                else
                {
                    MessageBox.Show("Введите Password", "Ошибка!");
                }

                if (table.Rows.Count > 0)
                {
                    if (LogUser == "admin")
                    {
                        if (PasUser == "admin")
                        {
                            MessageBox.Show("ОК");
                            MainAdmin main = new MainAdmin();
                            this.Hide();
                            main.ShowDialog();
                        }
                    }
                    MessageBox.Show("ОК");
                    MainUser mainUser = new MainUser();
                    this.Hide();
                    mainUser.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Такого аккаунта не существует", "Ошибка!");
                }
            }
            else
            {
                MessageBox.Show("Введите Login", "Ошибка!");
            }
          
        }
        private void Close_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5RegisterUserLink_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
        }

    }
}
