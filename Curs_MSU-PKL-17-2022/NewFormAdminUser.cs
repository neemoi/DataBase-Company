using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Curs_MSU_PKL_17_2022
{
    public partial class NewFormAdminUser : Form
    {
        DataBase dataBase = new DataBase();

        public NewFormAdminUser()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdmin = new MainAdmin();
            this.Hide();
            mainAdmin.ShowDialog();
        }

        private void button4SaveNewFormAdminFirm_Click(object sender, EventArgs e)
        {
            var login = textBox2LoginNew.Text;
            var pass = textBox3PasswordNew.Text;
            var email = textBox4EmailNew.Text;
            var namecompany = textBox5NameCompanyNew.Text;

            dataBase.OpenConnection();

            if (true)
            {
                MySqlCommand command = new MySqlCommand($"INSERT INTO `users` (Login, Password, Email, NameCompany) " + $"VALUES ('{login}', '{pass}', '{email}', '{namecompany}')", dataBase.GetConnection());

                command.ExecuteNonQuery();

                MessageBox.Show("Данные усешно добавлены!");
            }
            dataBase.CloseConnection();
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewFormAdminUser_Load(object sender, EventArgs e)
        {

        }
    }
}
