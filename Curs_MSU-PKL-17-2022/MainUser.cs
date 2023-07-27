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
    public partial class MainUser : Form
    {
        DataBase dataBase = new DataBase();

        enum RowState
        {
            Existed,
            New,
            ModifiedNew,
            Deleted
        }
        public MainUser()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }


        //ФИРМА
        private void CreatColumbFirm()
        {
            dataGridView1.Columns.Add("ID Фирмы", "ID Фирмы");
            dataGridView1.Columns.Add("Название фирмы", "Название фирмы");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }
        
        
        private void ReadSingleRowdataGridView1(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }


        private void RefreshdataGridView1(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `фирма`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView1(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[2].Visible = false;
        }



        //ТОВАР
        private void CreatColumnTovar()
        {
            dataGridView1.Columns.Add("ID Товара", "ID Товара");
            dataGridView1.Columns.Add("Название товара", "Название товара");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView2(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }

        private void RefreshdataGridView2(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `товар`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView2(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[2].Visible = false;
        }



        //СКЛАД
        private void CreatColumnsdataGridView3()
        {
            dataGridView1.Columns.Add("ID Склада", "ID Склад");
            dataGridView1.Columns.Add("ID Фирмы", "ID Фирм");
            dataGridView1.Columns.Add("№ Доставки", "№ Доставки");
            dataGridView1.Columns.Add("Адрес склада", "Адрес склада");
            dataGridView1.Columns.Add("IsNew", string.Empty);
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



        //Предприятие
        private void CreatColumnsdataGridView4()
        {
            dataGridView1.Columns.Add("ID Предприятия", "ID Предприятия");
            dataGridView1.Columns.Add("ID Товара", "ID Товара");
            dataGridView1.Columns.Add("Цена", "Цена");
            dataGridView1.Columns.Add("Название предприятия", "Название предприятия");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView4(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshdataGridView4(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `предприятие`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView4(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[4].Visible = false;
        }


        //Водитель*
        private void CreatColumnsdataGridView5()
        {
            dataGridView1.Columns.Add("ID Водителя", "ID Водителя");
            dataGridView1.Columns.Add("ID Автомобиля", "ID Автомобиля");
            dataGridView1.Columns.Add("ID Фирмы", "ID Фирмы");
            dataGridView1.Columns.Add("Имя водителя", "Имя водителя");
            dataGridView1.Columns.Add("Фамилия водителя", "Фамилия водителя");
            dataGridView1.Columns.Add("Отчество водителя", "Отчество водителя");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView5(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }

        private void RefreshdataGridView5(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `водитель`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView5(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[6].Visible = false;
        }



        //Автомобиль
        private void CreatColumnsdataGridView6()
        {
            dataGridView1.Columns.Add("ID Автомобиля", "ID Автомобиля");
            dataGridView1.Columns.Add("Марка", "Марка");
            dataGridView1.Columns.Add("Номер", "Номер");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView6(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void RefreshdataGridView6(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `автомобиль`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView6(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[3].Visible = false;
        }



        //Накладная
        private void CreatColumnsdataGridView7()
        {
            dataGridView1.Columns.Add("№ Накладной", "№ Накладной");
            dataGridView1.Columns.Add("ID Автомобиля", "ID Автомобиля");
            dataGridView1.Columns.Add("№ Заказа", "№ Заказа");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView7(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2),  RowState.ModifiedNew);
        }

        private void RefreshdataGridView7(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `накладная`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView7(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[5].Visible = false;
        }


        //Заказ
        private void CreatColumnsdataGridView8()
        {
            dataGridView1.Columns.Add("№ Заказа", "№ Заказа");
            dataGridView1.Columns.Add("ID Клиента", "ID Клиента");
            dataGridView1.Columns.Add("Дата перевозки", "Дата перевозки");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView8(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshdataGridView8(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `заказ`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView8(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[3].Visible = false;
        }



        //Клиент
        private void CreatColumnsdataGridView9()
        {
            dataGridView1.Columns.Add("ID Клиента", "ID Клиента");
            dataGridView1.Columns.Add("№ Счета", "№ Счета");
            dataGridView1.Columns.Add("Имя клиента", "Имя клиента");
            dataGridView1.Columns.Add("Фамилия клиента", "Фамилия клиента");
            dataGridView1.Columns.Add("Отчество клиента", "Отчество клиента");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView9(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshdataGridView9(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `клиент`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView9(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[5].Visible = false;
        }



        //Счет
        private void CreatColumnsdataGridView10()
        {
            dataGridView1.Columns.Add("№ Счета", "№ Счета");
            dataGridView1.Columns.Add("ID Банка", "ID Банк");
            dataGridView1.Columns.Add("Дата", "Дата");
            dataGridView1.Columns.Add("Кредит", "Кредит");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView10(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshdataGridView10(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `счет`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView10(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[4].Visible = false;
        }


        //Банк
        private void CreatColumnsdataGridView11()
        {
            dataGridView1.Columns.Add("ID Банка", "ID Банка");
            dataGridView1.Columns.Add("Название банка", "Название банка");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView11(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }

        private void RefreshdataGridView11(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `банк`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView11(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[2].Visible = false;
        }


        //Доставка
        private void CreatColumnsdataGridView12()
        {
            dataGridView1.Columns.Add("№ Доставки", "№ Доставки");
            dataGridView1.Columns.Add("ID Предприятия", "ID Предприятия");
            dataGridView1.Columns.Add("Номер автомобиля", "Номер автомобиля");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRowdataGridView12(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void RefreshdataGridView12(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `доставка`", dataBase.GetConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowdataGridView12(dataGrid, reader);
            }
            reader.Close();

            dataGrid.Columns[3].Visible = false;
        }


        private void button32_Click(object sender, EventArgs e)
        {
            String TableName = comboBox1.Text;

            if (TableName == "Фирма")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumbFirm();
                RefreshdataGridView1(dataGridView1);
            }
            if (TableName == "Доставка")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView12();
                RefreshdataGridView12(dataGridView1);
            }
            if (TableName == "Товар")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnTovar();
                RefreshdataGridView2(dataGridView1);
            }
            if (TableName == "Склад")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView3();
                RefreshdataGridView3(dataGridView1);
            }
            if (TableName == "Предприятие")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView4();
                RefreshdataGridView4(dataGridView1);
            }
            if (TableName == "Водитель")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView5();
                RefreshdataGridView5(dataGridView1);
            }
            if (TableName == "Автомобиль")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView6();
                RefreshdataGridView6(dataGridView1);
            }
            if (TableName == "Накладная")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView7();
                RefreshdataGridView7(dataGridView1);
            }
            if (TableName == "Заказ")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView8();
                RefreshdataGridView8(dataGridView1);
            }
            if (TableName == "Клиент")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView9();
                RefreshdataGridView9(dataGridView1);
            }
            if (TableName == "Счет")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView10();
                RefreshdataGridView10(dataGridView1);
            }
            if (TableName == "Банк")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                CreatColumnsdataGridView11();
                RefreshdataGridView11(dataGridView1);
            }
        }

        private void label40_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }



        //1
        
        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        } 
        
        private void button12_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Clear();
            dataGridView5.Columns.Clear();

            dataBase.OpenConnection();

            MySqlCommand command = new MySqlCommand("CALL ProcedureCar(@1, @2) ", dataBase.GetConnection());
            
            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@2", MySqlDbType.Date).Value = DateTime.Parse(textBox3.Text);

            MySqlDataReader reader = command.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            foreach (DataRow row in schemaTable.Rows)
            {
                dataGridView5.Columns.Add(row.ItemArray[0] as string, row.ItemArray[0] as string);
            }

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                dataGridView5.Rows.Add(values);
            }
            reader.Close();

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить запрос");
            }

            dataBase.CloseConnection();
        }





        //2
        private void button3_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
        } 
        
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataBase.OpenConnection();

            MySqlCommand command = new MySqlCommand("CALL ProcedurePredpriatije(@1, @2) ", dataBase.GetConnection());

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = textBox6.Text;
            command.Parameters.Add("@2", MySqlDbType.Int32).Value = textBox5.Text;

            MySqlDataReader reader = command.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            foreach (DataRow row in schemaTable.Rows)
            {
                dataGridView2.Columns.Add(row.ItemArray[0] as string, row.ItemArray[0] as string);
            }

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                dataGridView2.Rows.Add(values);
            }
            reader.Close();

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить запрос");
            }

            dataBase.CloseConnection();
        }




        //3
        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView6.Rows.Clear();
            dataGridView6.Columns.Clear();
        
        }
        private void button15_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dataGridView6.Rows.Clear();
            dataGridView6.Columns.Clear();

            dataBase.OpenConnection();

            MySqlCommand command = new MySqlCommand("CALL ProcedureBank(@1, @2) ", dataBase.GetConnection());
            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@2", MySqlDbType.Date).Value = DateTime.Parse(textBox1.Text);

            MySqlDataReader reader = command.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            foreach (DataRow row in schemaTable.Rows)
            {
                dataGridView6.Columns.Add(row.ItemArray[0] as string, row.ItemArray[0] as string);
            }

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                dataGridView6.Rows.Add(values);
            }
            reader.Close();

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить запрос");
            }

            dataBase.CloseConnection();
        }



        //4
        private void button6_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            dataBase.OpenConnection();

            MySqlCommand command = new MySqlCommand("CALL ProcedureSclad(@1, @2) ", dataBase.GetConnection());
            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = textBox8.Text;
            command.Parameters.Add("@2", MySqlDbType.Int32).Value = textBox7.Text;

            MySqlDataReader reader = command.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            foreach (DataRow row in schemaTable.Rows)
            {
                dataGridView3.Columns.Add(row.ItemArray[0] as string, row.ItemArray[0] as string);
            }

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                dataGridView3.Rows.Add(values);
            }
            reader.Close();

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить запрос");
            }

            dataBase.CloseConnection();
        }


        //5
        private void button9_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();

            dataBase.OpenConnection();

            MySqlCommand command = new MySqlCommand("CALL Procedure5(@1, @2) ", dataBase.GetConnection());
            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = textBox10.Text;
            command.Parameters.Add("@2", MySqlDbType.Int32).Value = textBox9.Text;

            MySqlDataReader reader = command.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            foreach (DataRow row in schemaTable.Rows)
            {
                dataGridView4.Columns.Add(row.ItemArray[0] as string, row.ItemArray[0] as string);
            }

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                dataGridView4.Rows.Add(values);
            }
            reader.Close();

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить запрос");
            }

            dataBase.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
