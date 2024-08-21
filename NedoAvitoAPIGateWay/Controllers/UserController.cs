using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NedoAvito.APIGateWay.Services;

namespace NedoAvito.APIGateWay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService usersService = new UserService();

        //// GET: api/<UserController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    var result = usersService?.GetUserList();
        //    return result?.Select(s => JsonSerializer.Serialize(s)) ?? new List<string>() { };
        //}

        //// GET api/<UserController>/5
        //[HttpGet("{id}")]
        //public string Get(Guid id)
        //{
        //    return usersController?.GetUserDetails(id)?.ToString() ?? "";
        //}

        //// POST api/<usersService>
        //[EnableCors("CorsPolicy")]
        //[HttpPost]
        //public async Task<IActionResult> Post([FromForm] UserDto UserDto, [FromForm] IFormFile UserImage)
        //{
        //    try
        //    {
        //        var user = new User(UserDto);

        //        await usersService.CreateAsync(user);

        //        // Create the user image
        //        if (UserImage != null)
        //        {
        //            using (var memoryStream = new MemoryStream())
        //            {
        //                await UserImage.CopyToAsync(memoryStream);
        //                var userImage = new UserImage(memoryStream.ToArray(), user);
        //                await usersImageController.CreateAsync(userImage, user);
        //            }
        //        }

        //        //var userImage = new UserImage(Convert.FromBase64String(userDto.UserImage), user);
        //        //await usersImageController.CreateAsync(userImage, user);

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Обработка различных ошибок и возврат подходящего статус-кода
        //        if (ex is ArgumentException)
        //        {
        //            return BadRequest(ex.Message);
        //        }
        //        else if (ex is UnauthorizedAccessException)
        //        {
        //            return Unauthorized();
        //        }
        //        else
        //        {
        //            // Логирование ошибки
        //            //_logger.LogError(ex, "Ошибка при создании пользователя");
        //            return StatusCode(StatusCodes.Status500InternalServerError, "Произошла внутренняя ошибка сервера");
        //        }
        //    }
        //}



        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(Guid id, string _name, string _surname, DateTime _birthDay, string _email, string country)
        //{
        //    try
        //    {
        //        var user = new User(id, _name, _surname, _birthDay, _email, country);
        //        await usersService.UpdateAsync(id, user);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Обработка различных ошибок и возврат подходящего статус-кода
        //        if (ex is ArgumentException)
        //        {
        //            return BadRequest(ex.Message);
        //        }
        //        else if (ex is UnauthorizedAccessException)
        //        {
        //            return Unauthorized();
        //        }
        //        else
        //        {
        //            // Логирование ошибки
        //            //_logger.LogError(ex, "Ошибка при создании пользователя");
        //            return StatusCode(StatusCodes.Status500InternalServerError, "Произошла внутренняя ошибка сервера");
        //        }
        //    }
        //}

        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(Guid id)
        //{
        //    try
        //    {
        //        await usersService.DeleteConfirmed(id);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Обработка различных ошибок и возврат подходящего статус-кода
        //        if (ex is ArgumentException)
        //        {
        //            return BadRequest(ex.Message);
        //        }
        //        else if (ex is UnauthorizedAccessException)
        //        {
        //            return Unauthorized();
        //        }
        //        else
        //        {
        //            // Логирование ошибки
        //            //_logger.LogError(ex, "Ошибка при создании пользователя");
        //            return StatusCode(StatusCodes.Status500InternalServerError, "Произошла внутренняя ошибка сервера");
        //        }
        //    }
        //}
    }
}
