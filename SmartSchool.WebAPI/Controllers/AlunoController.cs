using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>() {
            new Aluno() {
                Id = 1,
                Nome = "Matheus",
                Sobrenome = "Duarte",
                Telefone = "18991801971"
            },
            new Aluno() {
                Id = 2,
                Nome = "Ednaldo",
                Sobrenome = "Pereira",
                Telefone = "18991801945"
            },
            new Aluno() {
                Id = 3,
                Nome = "José",
                Sobrenome = "Silva",
                Telefone = "18991801946"
            },
        };

        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");

            return Ok(aluno);
        }
    }
}