using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostagenController : ControllerBase
    {
        public PostagenController()
        {
        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Postagen>> GetAll() =>
            BlogService.GetAll();

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Postagen> Get(int id)
        {
            var postagen = BlogService.Get(id);

            if (postagen == null)
                return NotFound();

            return postagen;
        }

        // POST action
        [HttpPost]
        public IActionResult Create(Postagen postagen)
        {
            BlogService.Add(postagen);
            return CreatedAtAction(nameof(Get), new { id = postagen.Id }, postagen);
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id, Postagen postagen)
        {
            if (id != postagen.Id)
                return BadRequest();

            var existingPostagen = BlogService.Get(id);
            if (existingPostagen == null)
                return NotFound();

            BlogService.Update(postagen);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var postagen = BlogService.Get(id);

            if (postagen == null)
                return NotFound();

            BlogService.Delete(id);

            return NoContent();
        }
    }
}