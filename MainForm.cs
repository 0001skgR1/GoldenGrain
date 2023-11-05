using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoldenGrain
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void UpdateBlank()
        {
            DateTime currentDate = DateTime.Now;

            string formatedDate = currentDate.ToString("dd.MM.yyyy");
            PCDate.Text = formatedDate.ToString();

            string formatedTime = currentDate.ToString("HH.mm");
            PCTime.Text = formatedTime.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateBlank();

            //Надпись сверху
            YouAuthLabel.Text = "Вы авторизованны как: " + DataBank.LoginLab;

            //Путь к базе данных
            string dbPath = @"D:\refque\Программа\GoldenGrain\database\goldi.db";

            // Строка подключения к базе данных
            string DataPathTo = $"Data Source={dbPath}; version=3; ReadOnly=true";

            //Создание записей в ComboBox - виды товара
            using (SQLiteConnection connection = new SQLiteConnection(DataPathTo))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    string ProductColumn = "SELECT [Product_Name] FROM [Products]";

                    using (SQLiteCommand command = new SQLiteCommand(ProductColumn, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string SecondColumn = reader.GetString(0);
                                ProductType.Items.Add(SecondColumn);
                            }
                        }

                    }
                    transaction.Commit();
                }
                connection.Close();
            }

            using (SQLiteConnection connection = new SQLiteConnection(DataPathTo))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    string TransactionToDesc = "SELECT Login, Pass, Description FROM [Access_LVL] WHERE Login = @VaultDesc AND Pass = @VaultPass";

                    using (SQLiteCommand command = new SQLiteCommand(TransactionToDesc, connection))
                    {
                        command.Parameters.AddWithValue("@VaultDesc", DataBank.LoginLab);
                        command.Parameters.AddWithValue("@VaultPass", DataBank.PassLab);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string DescToVault = reader["Description"].ToString();
                                // Теперь у вас есть значения столбцов "Login" и "Description" для заданного значения "VaultDesc"

                                // Теперь проверяем, если "Description" равно "Corp_Name" в таблице "Cooperation"
                                string checkCorpQuery = "SELECT Corp_ID FROM Cooperation WHERE Corp_Name = @CorpName";
                                using (SQLiteCommand corpCommand = new SQLiteCommand(checkCorpQuery, connection))
                                {
                                    corpCommand.Parameters.AddWithValue("@CorpName", DescToVault);

                                    using (SQLiteDataReader corpReader = corpCommand.ExecuteReader())
                                    {
                                        if (corpReader.Read())
                                        {
                                            //int corpID = (int)corpReader["Corp_ID"];
                                            int corpID = corpReader.GetInt32(corpReader.GetOrdinal("Corp_ID"));
                                            // Теперь у вас есть значение "Corp_ID" для соответствующего "Corp_Name"

                                            DataBank.CorpID = corpID;
                                        }

                                    }
                                }
                            }
                        }
                    }
                    transaction.Commit();
                }
                connection.Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Exiete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewOrderBut_Click(object sender, EventArgs e)
        {
            //Путь к базе данных
            string dbPath = @"D:\refque\Программа\GoldenGrain\database\goldi.db";

            // Строка подключения к базе данных
            string DataPathTo = $"Data Source={dbPath}; version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(DataPathTo))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {

                    using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Orders ([Corp_ID], [Product_ID], [Product_Mass], [Data], [CTimes]) VALUES (@repoinst, @prodtype, @prodmass, @pcdate, @pctimev)", connection))
                    {
                            // Задайте значения параметров
                            command.Parameters.AddWithValue("@repoinst", DataBank.CorpID);
                            command.Parameters.AddWithValue("@prodtype", ProductType.Text);
                            command.Parameters.AddWithValue("@prodmass", ProdMass.Text);
                            command.Parameters.AddWithValue("@pcdate", PCDate.Text);
                            command.Parameters.AddWithValue("@pctimev", PCTime.Text);

                            // Выполнение команды вставки
                            command.ExecuteNonQuery();


                            transaction.Commit();

                        DataBank.stt = true;
                    }
                }
                    connection.Close();
            }

            if (DataBank.stt == true)
            {
                string pdt = ProductType.Text;
                string pdm = ProdMass.Text;

                EnterOrderLab.Text = $"Заказ на вид товара {pdt} в объёме {pdm} тонн оформлен! Ожидайте ответа";
                EnterOrderLab.Visible = true;
            }
            else
            {
                EnterOrderLab.Text = "Что то пошло не так... Заказ не был оформлен!";
                EnterOrderLab.Visible = true;
            }
        }
    }
}
