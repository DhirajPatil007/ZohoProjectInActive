using System;

using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;



namespace FretAPI.Controllers
{

    [Route("api/[controller]")]

    public class BordokutuContoller : Controller
    {

        private static readonly string[] Details = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private static readonly string[] Empolyee = new[]
      {
        "Aamod",  "Dhiraj", "Snehal", "Parija", "Harshala"
    };
    

    private static readonly string[] Empolyee1 = new[]


      private static readonly string[] Devbranch = new[]

    {
        "Aamod1",  "Dhiraj1", "Snehal1", "Parija1", "Harshala1"
    };


    }
}

