// kodun içinde kullandığım diğer dosyalar eklendi
using Microsoft.AspNetCore.Mvc;
using Ornekapi.Models;
using Ornekapi.Validators;
using FluentValidation.Results;
// dosyanın nerde bulunduğu yazılarak namespace tanımla
namespace Ornekapi.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonsController : ControllerBase // kendi classıma Mvc'den gelen ControllerBase inheritlenir
{
    [HttpPost] // metot çağırıldı
    public Person Post(Person p){ // public (metottan dönen tip yani return edilen şey) (metot adı) (parametre tipi)
        return p;
    }

}

