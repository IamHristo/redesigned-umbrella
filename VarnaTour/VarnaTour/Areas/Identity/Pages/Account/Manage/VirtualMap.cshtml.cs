using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using VarnaTour.Models;

namespace VarnaTour.Areas.Identity.Pages.Account.Manage
{
    public class VirtualMapModel : PageModel
    {

        [TempData]
        public string StatusMessage { get; set; }


        public List<Site> SiteList = new List<Site>();
        public void OnGet()
        {
            
            DisplayVisitedSites();

        }

        private void DisplayVisitedSites()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-VarnaTour-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, IdUser = "";
            var user = this.User.Identity;

            //SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate
            //FROM Orders
            //INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

            sql = "SELECT Id FROM dbo.AspNetUsers WHERE UserName = '" + user.Name + "'";

            command = new SqlCommand(sql, cn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                IdUser = dataReader.GetValue(0).ToString(); //+ " - " + dataReader.GetValue(1) + "</br>";
            }
            dataReader.Close();

            sql = "SELECT Name, Image, Address, Description FROM dbo.Site INNER JOIN dbo.Site_AspNetUsers ON dbo.Site.Id = dbo.Site_AspNetUsers.IdSite WHERE dbo.Site_AspNetUsers.IdUser = '" + IdUser + "'";


            command = new SqlCommand(sql, cn);
            
            dataReader = command.ExecuteReader();


            while (dataReader.Read())
            {
                SiteList.Add(new Site()
                {
                    Name = dataReader.GetValue(0).ToString(),
                    Image = dataReader.GetValue(1).ToString(),
                    Address = dataReader.GetValue(2).ToString(),
                    Description = dataReader.GetValue(3).ToString()
                });

                //IdUser = dataReader.GetValue(0).ToString() + " - " + dataReader.GetValue(1) + "</br>";
            }

            
            dataReader.Close();
            command.Dispose();

            cn.Close();
        }
    }
}
