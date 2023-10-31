using RestfulAPI.Models;
using System.Diagnostics;

namespace RestfulAPI.Utils
{
    public class Database
    {
        //Scaffold-DbContext "Server=localhost;Database=database;Password=1234;User=root" "Pomelo.EntityFrameworkCore.MySql" -outputdir Models -context DatabaseContext
        public static DatabaseContext Context { get; set; } = new DatabaseContext();
    }
}
