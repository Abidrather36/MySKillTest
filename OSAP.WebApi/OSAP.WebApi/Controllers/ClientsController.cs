using Microsoft.AspNetCore.Mvc;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Domain.Models.Response;
using OSAP.WebApi.Models;

namespace MySkillTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService clientService;

        public ClientsController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        // POST: api/Clients
        [HttpPost("registerClient")]
        public async Task<IActionResult> PostClient(ClientRequestModel model)
        {
            try
            {
                var clientAdded = await clientService.AddClient(model);
                return Ok(clientAdded);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // GET: api/Clients/5
        //[ResponseType(typeof(ClientModel))]
        [HttpGet("getClientById/{id:int}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            try
            {
                var clientById = await clientService.GetClientById(id);
                return Ok(clientById);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet("getAllCients")]
        public async Task<IActionResult> GetClients()
        {
            try
            {
               var clients=await clientService.GetAllClients();  
                return Ok(clients); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        // PUT: api/Clients/5
        [HttpPut("updateClient")]
        public async Task<IActionResult> PutClient(ClientUpdateModel model)
        {
            try
            {
               var clientupdated=await clientService.UpdateClient(model);
                return Ok(clientupdated);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

     

        // DELETE: api/Clients/5
        [HttpDelete("deleteClientById/{id:guid}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            try
            {
                var clientDeleted= await clientService.DeleteClient(id);
                return Ok(clientDeleted);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("api/client/uploadClientLogo")]
        //public async Task<IHttpActionResult> UploadFile()
        //{
        //    try
        //    {
        //        //var file = Request.Form.Files[0];
        //        //HttpRequest formData = HttpContext.Request;
        //        var file = HttpContext.Current.Request.Files["file"];
        //        var clientId = HttpContext.Current.Request.Form["clientId"];
        //        byte[] fileData;
        //        using (var reader = new MemoryStream())
        //        {
        //            file.InputStream.CopyTo(reader);
        //            fileData = reader.ToArray();
        //        }
        //        var response = await iClientRepository.UploadClientLogo(fileData, Convert.ToInt32(clientId));
        //        return Ok(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
