using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSventa2.Models;
using WSventa2.Models.Response;
using WSventa2.Models.Request;


namespace WSventa2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        //metodo listar
        public IActionResult Get()
        {
            Respuesta oRespuesta = new Respuesta();
            oRespuesta.Exito = 0;
            try
            {

                using (sebastian_testContext db = new sebastian_testContext())
                {
                    oRespuesta.Exito = 1;
                    var lst = db.Cliente.ToList();
                    oRespuesta.Data = lst;
                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }


        //metodo registrar
        [HttpPost]
        public ActionResult Add(ClienteRequest oModel)
        {
            Respuesta oRespuesta = new Respuesta();

            try
            {
                using (sebastian_testContext db = new sebastian_testContext())
                {

                    Cliente oCliente = new Cliente();
                    oCliente.Nombre = oModel.Nombre;
                    db.Cliente.Add(oCliente);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }





            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }


        [HttpPut]
        public ActionResult Edit(ClienteRequest oModel)
        {
            Respuesta oRespuesta = new Respuesta();

            try
            {
                using (sebastian_testContext db = new sebastian_testContext())
                {

                    Cliente oCliente = db.Cliente.Find(oModel.Id);
                    oCliente.Nombre = oModel.Nombre;
                    db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }





            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }




        [HttpDelete("{Id}")]
        public ActionResult Delete(int Id)
        {
            Respuesta oRespuesta = new Respuesta();

            try
            {
                using (sebastian_testContext db = new sebastian_testContext())
                {

                    Cliente oCliente = db.Cliente.Find(Id);
                    db.Remove(oCliente);
                    db.SaveChanges();
         

                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }





            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }




    }
}
