using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RecruitmentTest.Helpers;
using RecruitmentTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecruitmentTest.Controllers
{
    [Route("api/[controller]")]
    public class ShoppingController : Controller
    {
        private IShoppingService _shoppingService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public ShoppingController(
            IShoppingService shoppingService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _shoppingService = shoppingService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] ShoppingModel shopping)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var todos = _mapper.Map<SaveTodoResource, Todo>(resource);
            var result = await _todoService.SaveAsync(todos);

            if (!result.Success)
                return BadRequest(result.Message);

            var TodoResult = _mapper.Map<Todo, TodoResource>(result.Todo);
            return StatusCode(201, new { TodoResult });
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
