using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using VarnaTour.Data;
using VarnaTour.Models;

namespace VarnaTour.Pages.Beaches
{
    public class BeachesDetailsModel : PageModel
    {
        private readonly VarnaTour.Data.ApplicationDbContext _context;

        public BeachesDetailsModel(VarnaTour.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Beach> Beach { get;set; }

        public async Task OnGetAsync()
        {
            Beach = await _context.Beach.ToListAsync();
        }

        public void FilterBeaches(string flag)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-VarnaTour-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";

            sql = "SELECT * FROM dbo.Beaches WHERE " + flag + " = true";

            command = new SqlCommand(sql, cn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Beach tempBeach = new Beach();
                tempBeach.Title = dataReader.GetValue(1).ToString();
                tempBeach.Image = dataReader.GetValue(2).ToString();
                tempBeach.MiniContent = dataReader.GetValue(3).ToString();
                tempBeach.Content = dataReader.GetValue(4).ToString();
                tempBeach.HasRestourant = bool.Parse(dataReader.GetValue(5).ToString());
                tempBeach.HasLifeguard = bool.Parse(dataReader.GetValue(6).ToString());
                tempBeach.HasMedicalStaff = bool.Parse(dataReader.GetValue(7).ToString());
                tempBeach.IsSuitableForChildren = bool.Parse(dataReader.GetValue(8).ToString());
                tempBeach.HasDressingRoom = bool.Parse(dataReader.GetValue(9).ToString());
                tempBeach.HasShower = bool.Parse(dataReader.GetValue(10).ToString());
                tempBeach.HasParking = bool.Parse(dataReader.GetValue(11).ToString());
                tempBeach.HasCarAccess = bool.Parse(dataReader.GetValue(12).ToString());
                tempBeach.HasUmbrellaAndSunbed = bool.Parse(dataReader.GetValue(13).ToString());
                tempBeach.IsDisabilitiesFriendly = bool.Parse(dataReader.GetValue(14).ToString());
                Beach.Add(tempBeach);
                _ = OnGetAsync();
            }
            dataReader.Close();
            command.Dispose();

            cn.Close();
        }
    }
}

