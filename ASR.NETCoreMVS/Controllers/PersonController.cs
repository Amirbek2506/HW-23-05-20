using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ASR.NETCoreMVS.Models.Persons;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASR.NETCoreMVS.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Read(int? Id)
        {
            using (IDbConnection db = new SqlConnection("Data Source=Amirbek;Initial Catalog=AlifAcademy;Integrated Security=True"))
            {
                if (Id == null)
                    return View(db.Query<PersonViewModel>("SELECT * FROM PERSON").ToList<PersonViewModel>());
                else
                {
                    return View(db.Query<PersonViewModel>($"SELECT * FROM PERSON Where(Id={Id})").ToList<PersonViewModel>());
                }
            }
        }
    }
}