using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoldenGrain
{
	public partial class RegForm : Form
	{
		public RegForm()
		{
			InitializeComponent();
		}

		private void RegButton_Click(object sender, EventArgs e)
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
					string pvt = insertLogin.Text;
					string pfc = insertPass.Text;
					string pdb = PassChecker.Text;
					string baselvl = "CLI";
					string typ = "Client";
					string dst = CoopBox.Text;

					if (pfc == pdb)
					{
						DataBank.splt = pfc;
					}

					string PoluchenieZapisi = "INSERT INTO Access_LVL (LVL, Login, Pass, User_Type, Description) VALUES(@Level, @Login, @Pass, @UserType, @JTDesc)"; ;

					using (SQLiteCommand command = new SQLiteCommand(PoluchenieZapisi, connection))
					{
						command.Parameters.AddWithValue("Level", baselvl);
						command.Parameters.AddWithValue("@Login", pvt);
						command.Parameters.AddWithValue("@Pass", DataBank.splt);
						command.Parameters.AddWithValue("@UserType", typ);
                        command.Parameters.AddWithValue("@JTDesc", dst);

                        transaction.Commit();
					}
					connection.Close();
				}
			}
		}
	}
}
