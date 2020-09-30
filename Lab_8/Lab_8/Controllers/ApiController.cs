using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab_8.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : Controller
    {
        Models.IPhoneDictionary repo;
        public ApiController(Models.IPhoneDictionary _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        public ActionResult<List<Models.Telephone>> Select()
        {
            var telephones = repo.Select();
            if (telephones == null)
            {
                return NoContent();
            }
            return Ok(telephones);
        }

        [HttpPost]
        public ActionResult<Models.Telephone> Add(Models.Telephone telephone)
        {
            repo.Insert(telephone.Surname, telephone.Number);
            return Ok(telephone);
        }

        [HttpPut]
        public ActionResult<Models.Telephone> Update(Models.Telephone telephone)
        {
            repo.Update(telephone.Id, telephone.Surname, telephone.Number);
            return Ok(telephone);
        }

        [HttpDelete]
        public ActionResult<Models.Telephone> Delete(Models.Telephone telephone)
        {
            repo.Delete(telephone.Id);
            return Ok(telephone);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Models.Telephone> SelectOne(int id)
        {
            var telephone = repo.SelectOne(id);
            return Ok(telephone);
        }
    }
}