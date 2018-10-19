using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Proyecto_personal.Models;



namespace Proyecto_Personal.Controllers{

    public class SubteController : Controller{

        public IActionResult Index(){
            
            return View();
        }

        public async Task<IActionResult> ObtenerEstado(){
            string data;
            JObject estadoSubtes;
            string apiUrl = "https://haysubte.now.sh/api";

            using(HttpClient client = new HttpClient()){
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    data = await response.Content.ReadAsStringAsync();
                    estadoSubtes = JObject.Parse(data);

                    return Json(estadoSubtes);
                }

            }
            return StatusCode(400);
        }
    }
}