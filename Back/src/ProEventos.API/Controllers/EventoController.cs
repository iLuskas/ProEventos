using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
    }

    [HttpGet]
    public Evento Get()
    {
        return new Evento(){
            DataEvento = "14/10/23",
            EventoId = 1,
            ImagemUrl = "c:\\imagezvento.png",
            Local = "Rio De Janeiro",
            QtdPessoas = 10,
            Tema = "C# for beginners",
            Lote = "1º Lote"
        };
    }
}
