using System;
using System.Data;
using System.Data.SqlClient;


namespace HRMS
{
    //internal class DataBase
    //{
    //    private string connectionString = @"YourConnectionStringHere"; // Укажите вашу строку подключения

    //    // Метод для получения данных пользователей
    //    public DataTable GetUsers()
    //    {
    //        DataTable usersTable = new DataTable();

    //        using (SqlConnection connection = new SqlConnection(connectionString))
    //        {
    //            string query = "SELECT UserID, Username, Role, Email, FirstName, LastName, Position, Department, HireDate, Salary, Status FROM UsersAndVacancies"; // Запрос для получения пользователей

    //            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
    //            connection.Open();
    //            dataAdapter.Fill(usersTable);
    //        }

    //        return usersTable;
    //    }
    //}
}
