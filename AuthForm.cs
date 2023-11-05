using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GoldenGrain
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
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
                    string login = insertLogin.Text;
                    string pass = insertPass.Text;

                    string PoluchenieZapisi = "SELECT COUNT(*) FROM [Access_LVL] WHERE [Login] = @Login AND [Pass] = @Pass";

                    using (SQLiteCommand command = new SQLiteCommand(PoluchenieZapisi, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Pass", pass);

                        // Получаем количество строк, соответствующих введенным данным
                        int AuthorizationFlag = Convert.ToInt32(command.ExecuteScalar());

                        if (AuthorizationFlag > 0)
                        {
                            MainForm phew = new MainForm();

                            DataBank.LoginLab = insertLogin.Text;
                            DataBank.PassLab = insertPass.Text;

                            phew.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль!");

                            insertLogin.Text = "";
                            insertPass.Text = "";
                        }
                    }
                    transaction.Commit();
                }
                connection.Close();
            }
        }
    }
}
