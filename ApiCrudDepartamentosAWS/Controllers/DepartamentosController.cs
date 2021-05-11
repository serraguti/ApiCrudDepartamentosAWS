using ApiCrudDepartamentosAWS.Models;
using ApiCrudDepartamentosAWS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudDepartamentosAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Departamento>> GetDepartamentos()
        {
            return this.repo.GetDepartamentos();
        }

        [HttpGet("{id}")]
        public ActionResult<Departamento> BuscarDepartamento(int id)
        {
            return this.repo.BuscarDepartamento(id);
        }

        [HttpPost]
        public void InsertarDepartamento(Departamento departamento)
        {
            this.repo.InsertarDepartamento(departamento.IdDepartamento
                , departamento.Nombre, departamento.Localidad);
        }

        //PUT api/[controller]
        [HttpPut]
        public void ModificarDepartamento(Departamento departamento)
        {
            this.repo.ModificarDepartamento(departamento.IdDepartamento
                , departamento.Nombre, departamento.Localidad);
        }

        //DELETE api/[controller]/{id}
        [HttpDelete("{id}")]
        public void EliminarDepartamento(int id)
        {
            this.repo.EliminarDepartamento(id);
        }
    }
}
