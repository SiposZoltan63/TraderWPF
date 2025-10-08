using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderWpf
{
    internal class DatabaseStatements
    {
        Connect conn = new Connect();

        public object AddNewUser(object user)
        {
            conn._connection.Open();

            string sql = "INSERT INTO `users`(`UserName`, `FullName`, `PASSWORD`, `Salt`, `Email`) VALUES ('@username','@fullname','@password','@salt','@email');";

            MySqlCommand cmd = new MySqlCommand(sql, conn._connection);

            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@fullname", user);
            cmd.Parameters.AddWithValue("@password", user);
            cmd.Parameters.AddWithValue("@salt", user);
            cmd.Parameters.AddWithValue("@email", user);

            cmd.ExecuteNonQuery();

            conn._connection.Close();

            return new {message = "Sikeres hozzáadás."};
        }
    }
}
