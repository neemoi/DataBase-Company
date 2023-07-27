using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Curs_MSU_PKL_17_2022
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            var log = textBoxLoginRegisterUser.Text;
            var pass = textBoxPasswordRegisterUser.Text;
            var email = textBoxEmailRegisterUser.Text;
            var namecompany = textBoxNameCompanyRegisterUser.Text;

            dataBase.OpenConnection();

            if (textBoxLoginRegisterUser.Text.Length > 0)
            {
                if (textBoxPasswordRegisterUser.Text.Length > 0)
                {
                    if (textBoxEmailRegisterUser.Text.Length > 0)
                    {
                        string[] dataLogin = textBoxEmailRegisterUser.Text.Split('@');

                        if (dataLogin.Length == 2)
                        {
                            string[] data2Login = dataLogin[1].Split('.');

                            if (data2Login.Length == 2)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Укажите Email в форме х@x.x");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Укажите Email в форме х@x.x");
                            return;
                        }
                        if (textBoxNameCompanyRegisterUser.Text.Length > 0)
                        {
                            MySqlCommand command = new MySqlCommand($"INSERT INTO `users` (`Login`, `Password`, `Email`, `NameCompany`) VALUES ('{log}', '{pass}', '{email}', '{namecompany}')", dataBase.GetConnection());
                            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = log;
                            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
                            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
                            command.Parameters.Add("@nc", MySqlDbType.VarChar).Value = namecompany;

                            if (CheckUser())
                            {
                                return;
                            }

                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Аккаунт успешно создан!");
                                LogIn logIn = new LogIn();
                                this.Hide();
                                logIn.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Проверьте правильность заполнения данных!", "Ошибка!");
                            }

                            dataBase.CloseConnection();
                        }
                        else
                        {
                            MessageBox.Show("Введите данные в поле Name Company ", "Ошибка!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите данные в поле Email", "Ошибка!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные в поле Password", "Ошибка!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введите данные в поле Login", "Ошибка!");
                return;
            }
        }

        
        private Boolean CheckUser()
        {
            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            var log = textBoxLoginRegisterUser.Text;
            var pass = textBoxPasswordRegisterUser.Text;
            var email = textBoxEmailRegisterUser.Text;
            var namecompany = textBoxNameCompanyRegisterUser.Text;

            MySqlConnection connection = new MySqlConnection("server=localhost; port=8889; username=root; password=root; database=msu_pkl_17_2022; SSL Mode=None");
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @lg OR `Email` = @em", connection);
            command.Parameters.Add("@lg", MySqlDbType.VarChar).Value = log;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже создан!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBoxLoginRegisterUser_TextChanged(object sender, EventArgs e)
        { 
            textBoxPasswordRegisterUser.MaxLength = 50;
            textBoxLoginRegisterUser.MaxLength = 50;
            textBoxEmailRegisterUser.MaxLength = 50;
            textBoxNameCompanyRegisterUser.MaxLength = 50;
        }

        private void textBoxPasswordRegisterUser_TextChanged(object sender, EventArgs e)
        {
            textBoxPasswordRegisterUser.PasswordChar = '*';
        }
        
        private void label6_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
