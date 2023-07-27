using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Curs_MSU_PKL_17_2022
{
    public partial class MainAdmin : Form
    {
        DataBase dataBase = new DataBase();

        int selectRow;

        enum RowState
        {
            Existed,
            New,
            ModifiedNew,
            Deleted
        }

        public MainAdmin()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //USERS
        private void CreatColumnsdataGridView1()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Login", "Login");
            dataGridView1.Columns.Add("Password", "Password");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("NameCompany", "NameCompany");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView1(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshdataGridView1(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView1(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[5].Visible = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView1();
            RefreshdataGridView1(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView1();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectRow];

                textBox1ID.Text = row.Cells[0].Value.ToString();
                textBox2Login.Text = row.Cells[1].Value.ToString();
                textBox3Password.Text = row.Cells[2].Value.ToString();
                textBox4Email.Text = row.Cells[3].Value.ToString();
                textBox5NameCompany.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button1NewEntryFirm_Click(object sender, EventArgs e)
        {
            NewFormAdminUser newFormAdmin = new NewFormAdminUser();
            newFormAdmin.Show();
        }

        private void Search(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `users` WHERE CONCAT (ID, Login, Password, Email, NameCompany) LIKE '%" + textBox1Search.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView1(dataGrid, read);
            }

            read.Close();
        }

        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }



        //АВТОМОБИЛЬ
        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void CreatColumnsdataGridView2()
        {
            dataGridView2.Columns.Add("ID Автомобиля", "ID Автомобиля");
            dataGridView2.Columns.Add("Марка", "Марка");
            dataGridView2.Columns.Add("Номер", "Номер");
            dataGridView2.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView2(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void RefreshdataGridView2(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `автомобиль`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView2(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[3].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView2();
            RefreshdataGridView2(dataGridView2);
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView2();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectRow];

                textBoxIDAuto.Text = row.Cells[0].Value.ToString();
                textBox5Marka.Text = row.Cells[1].Value.ToString();
                textBox4Number.Text = row.Cells[2].Value.ToString();
            }
        }

        private void SearchDataGrid2(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `автомобиль` WHERE CONCAT (`ID Автомобиля`, `Марка`, `Номер`) LIKE '%" + textBox1.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView2(dataGrid, read);
            }

            read.Close();

            dataGrid.Columns[3].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid2(dataGridView2);
        }



        //БАНК
        private void CreatColumnsdataGridView15()
        {
            dataGridView15.Columns.Add("ID Банка", "ID Банка");
            dataGridView15.Columns.Add("Название банка", "Название банка");
            dataGridView15.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView15(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }

        private void RefreshdataGridView15(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `банк`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView15(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[2].Visible = false;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView15();
            RefreshdataGridView15(dataGridView15);
        }

        private void dataGridView15_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView15();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView15.Rows[selectRow];

                textBox79.Text = row.Cells[0].Value.ToString();
                textBox78.Text = row.Cells[1].Value.ToString();
            }
        }

        private void SearchDataGrid15(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `банк` WHERE CONCAT (`ID Банка`, `Название банка`) LIKE '%" + textBox74.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView15(dataGrid, read);
            }

            read.Close();
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid15(dataGridView15);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }
        private void label97_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //СЧЕТ
        private void label83_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }

        private void CreatColumnsdataGridView13()
        {
            dataGridView13.Columns.Add("№ Счета", "№ Счета");
            dataGridView13.Columns.Add("ID Банка", "ID Банк");
            dataGridView13.Columns.Add("Дата", "Дата");
            dataGridView13.Columns.Add("Кредит", "Кредит");
            dataGridView13.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView13(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshdataGridView13(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `счет`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView13(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[4].Visible = false;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView13();
            RefreshdataGridView13(dataGridView13);
        }

        private void SearchDataGrid13(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `счет` WHERE CONCAT (`№ Счета`, `ID Банка`, `Дата`, `Кредит`) LIKE '%" + textBox62.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView13(dataGrid, read);
            }

            read.Close();
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid13(dataGridView13);
        }


        //ФИРМА
        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatColumnsdataGridView5()
        {
            dataGridView5.Columns.Add("ID Фирмы", "ID Фирмы");
            dataGridView5.Columns.Add("Название фирмы", "Название фирмы");
            dataGridView5.Columns.Add("Адрес фирмы", "Адрес фирмы");
            dataGridView5.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView5(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        
        private void RefreshdataGridView5(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `фирма`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView5(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[3].Visible = false;
        }

        private void SearchDataGrid5(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `фирма` WHERE CONCAT (`ID Фирмы`, `Название фирмы`, `Адрес фирмы`) LIKE '%" + textBox8.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView5(dataGrid, read);
            }

            read.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView5();
            RefreshdataGridView5(dataGridView5);
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView5();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView5.Rows[selectRow];

                textBox10IDFirm.Text = row.Cells[0].Value.ToString();
                textBox9NameFirm.Text = row.Cells[1].Value.ToString();
                textBox10.Text = row.Cells[1].Value.ToString();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid5(dataGridView5);
        }



        //ТОВАР
        private void label40_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatColumnsdataGridView7()
        {
            dataGridView7.Columns.Add("ID Товара", "ID Товара");
            dataGridView7.Columns.Add("Название товара", "Название товара");
            dataGridView7.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView7(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }

        private void RefreshdataGridView7(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `товар`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView7(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[2].Visible = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView7();
            RefreshdataGridView7(dataGridView7);
        }
       

        private void SearchDataGrid7(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `товар` WHERE CONCAT (`ID Товара`, `Название товара`) LIKE '%" + textBox26.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView5(dataGrid, read);
            }

            read.Close();

            dataGrid.Columns[2].Visible = false;
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView7();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView7.Rows[selectRow];

                textBox30.Text = row.Cells[0].Value.ToString();
                textBox31.Text = row.Cells[1].Value.ToString();
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid7(dataGridView7);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }



        //ПРЕДДПРИЯТИЕ
        private void label31_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatColumnsdataGridView6()
        {
            dataGridView6.Columns.Add("ID Предприятия", "ID Предприятия");
            dataGridView6.Columns.Add("ID Товара", "ID Товара");
            dataGridView6.Columns.Add("Цена", "Цена");
            dataGridView6.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView6(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void RefreshdataGridView6(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `предприятие`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView6(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[3].Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView6();
            RefreshdataGridView6(dataGridView6);
        }

        private void SearchDataGrid6(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `предприятие` WHERE CONCAT (`ID Предприятия`, `ID Товара`, `Цена`) LIKE '%" + textBox9.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView5(dataGrid, read);
            }

            read.Close();

            dataGrid.Columns[4].Visible = false;
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView6();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView6.Rows[selectRow];

                textBox20.Text = row.Cells[0].Value.ToString();
                textBox19.Text = row.Cells[1].Value.ToString();
                textBox12.Text = row.Cells[2].Value.ToString();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid6(dataGridView6);
        }



        
        //СКЛАД
        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatColumnsdataGridView3()
        {
            dataGridView3.Columns.Add("ID Склада", "ID Склад");
            dataGridView3.Columns.Add("ID Фирмы", "ID Фирм");
            dataGridView3.Columns.Add("№ Доставки", "№ Доставки");
            dataGridView3.Columns.Add("Адрес склада", "Адрес склада");
            dataGridView3.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView3(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshdataGridView3(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `склад`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView3(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[4].Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView3();
            RefreshdataGridView3(dataGridView3);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView3();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectRow];

                textBox6.Text = row.Cells[0].Value.ToString();
                textBox5.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
                textBox7.Text = row.Cells[3].Value.ToString();
            }
        }

        private void SearchDataGrid3(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `склад` WHERE CONCAT (`ID Склада`, `ID Фирмы`, `№ Доставки`, `Адрес склада`) LIKE '%" + textBox2.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView5(dataGrid, read);
            }

            read.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid3(dataGridView3);
        }



        //ВОДИТЕЛЬ
        private void label47_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatColumnsdataGridView8()
        {
            dataGridView8.Columns.Add("ID Водителя", "ID Водителя");
            dataGridView8.Columns.Add("ID Автомобиля", "ID Автомобиля");
            dataGridView8.Columns.Add("ID Фирмы", "ID Фирмы");
            dataGridView8.Columns.Add("Имя водителя", "Имя водителя");
            dataGridView8.Columns.Add("Фамилия водителя", "Фамилия водителя");
            dataGridView8.Columns.Add("Отчество водителя", "Отчество водителя");
            dataGridView8.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView8(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }

        private void RefreshdataGridView8(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `водитель`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView8(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[6].Visible = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView8();
            RefreshdataGridView8(dataGridView8);
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView8();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView8.Rows[selectRow];

                textBox37.Text = row.Cells[0].Value.ToString();
                textBox36.Text = row.Cells[1].Value.ToString();
                textBox35.Text = row.Cells[2].Value.ToString();
                textBox34.Text = row.Cells[3].Value.ToString();
                textBox33.Text = row.Cells[4].Value.ToString();
                textBox3.Text = row.Cells[5].Value.ToString();
            }
        }

        private void SearchDataGrid8(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `водитель` WHERE CONCAT (`ID Водителя`, `ID Автомобиля`, `ID Фирмы`, `Имя водителя`, `Фамилия водителя`, `Отчество водителя`) LIKE '%" + textBox32.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView8(dataGrid, read);
            }

            read.Close();
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid8(dataGridView8);
        }



        //НАКЛАДНАЯ
        private void label55_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatColumnsdataGridView9()
        {
            dataGridView9.Columns.Add("№ Накладной", "№ Накладной");
            dataGridView9.Columns.Add("ID Автомобиля", "ID Автомобиля");
            dataGridView9.Columns.Add("№ Заказа", "№ Заказа");
            dataGridView9.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView9(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void RefreshdataGridView9(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `накладная`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView9(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[3].Visible = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView9();
            RefreshdataGridView9(dataGridView9);
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView9();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView9.Rows[selectRow];

                textBox43.Text = row.Cells[0].Value.ToString();
                textBox42.Text = row.Cells[1].Value.ToString();
                textBox41.Text = row.Cells[2].Value.ToString();
            }
        }

        private void SearchDataGrid9(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `водитель` WHERE CONCAT (`№ Накладной`, `ID Автомобиля`, `№ Заказа`) LIKE '%" + textBox38.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView9(dataGrid, read);
            }

            read.Close();
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid9(dataGridView9);
        }



        //ЗАКАЗ
        private void label69_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }

        private void CreatColumnsdataGridView11()
        {
            dataGridView11.Columns.Add("№ Заказа", "№ Заказа");
            dataGridView11.Columns.Add("ID Клиента", "ID Клиента");
            dataGridView11.Columns.Add("Дата перевозки", "Дата перевозки");
            dataGridView11.Columns.Add("IsNew", string.Empty);
        }
       

        private void ReadSingleRowdataGridView11(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetDateTime(3), RowState.ModifiedNew);
        }

        private void RefreshdataGridView11(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `заказ`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView11(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[3].Visible = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView11();
            RefreshdataGridView11(dataGridView11);
        }




        //КЛИЕНТ
        private void label76_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }

        private void CreatColumnsdataGridView12()
        {
            dataGridView12.Columns.Add("ID Клиента", "ID Клиента");
            dataGridView12.Columns.Add("№ Счета", "№ Счета");
            dataGridView12.Columns.Add("Имя клиента", "Имя клиента");
            dataGridView12.Columns.Add("Фамилия клиента", "Фамилия клиента");
            dataGridView12.Columns.Add("Отчество клиента", "Отчество клиента");
            dataGridView12.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView12(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshdataGridView12(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `клиент`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView12(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[5].Visible = false;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            CreatColumnsdataGridView12();
            RefreshdataGridView12(dataGridView12);
        }

        private void dataGridView12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatColumnsdataGridView12();

            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView12.Rows[selectRow];

                textBox61.Text = row.Cells[0].Value.ToString();
                textBox60.Text = row.Cells[1].Value.ToString();
                textBox59.Text = row.Cells[2].Value.ToString();
                textBox58.Text = row.Cells[3].Value.ToString();
                textBox57.Text = row.Cells[4].Value.ToString();
            }
        }

        private void SearchDataGrid12(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string sql = $"SELECT * FROM `клиент` WHERE CONCAT (`ID Клиента`, `№ Счета`, `Имя клиента`, `Фамилия клиента`, `Отчество клиента`) LIKE '%" + textBox56.Text + "%'";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowdataGridView12(dataGrid, read);
            }

            read.Close();
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            SearchDataGrid12(dataGridView12);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
