using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;

namespace VarnaTour.Pages
{
    public class UserURLModel : PageModel
    {
        [BindProperty]
        public int IdSite { get; set; }

        [BindProperty]
        public string UserName { get; set; }


        public void OnGet(int id)
        {
            IdSite = id;
            var user = this.User.Identity;
            UserName = user.Name;

            InsertIntoDB();
        }

        private void InsertIntoDB()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-VarnaTour-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, IdUser = "";

            sql = "SELECT Id FROM dbo.AspNetUsers WHERE UserName = '" + UserName +   "'";

            command = new SqlCommand(sql, cn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                IdUser = dataReader.GetValue(0).ToString(); //+ " - " + dataReader.GetValue(1) + "</br>";
            }
            dataReader.Close();

            sql = "SELECT * FROM dbo.Site_AspNetUsers WHERE IdUser = '" + IdUser + "'" + " AND IdSite = '" + IdSite + "'";
            command = new SqlCommand(sql, cn);
            dataReader = command.ExecuteReader();

            if (!dataReader.Read())
            {
                dataReader.Close();
                sql = "INSERT INTO dbo.Site_AspNetUsers(IdUser, IdSite) VALUES('" + IdUser + "', '" + IdSite + "')";
                command = new SqlCommand(sql, cn);

                try
                {
                    command.ExecuteReader();
                }
                catch (Exception)
                {

                    IdSite = -1;
                }

                
            }

            dataReader.Close();
            command.Dispose();

            cn.Close();

        }
    }
}
