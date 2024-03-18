using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Interfaces;

namespace ToDoList.Controllers;

[ApiController]
[Route("[controller]")]
public class myTaskController : ControllerBase
{
    private ImyTaskService myTaskService;

    public myTaskController(ImyTaskService myTaskService)
    {
        this.myTaskService = myTaskService;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<myTask>> Get()
    {
        return myTaskService.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<myTask> Get(int id)
    {
        var task = myTaskService.Get(id);
        if (task == null)
            return NotFound();
        return Ok(task);       
    }
        
    [HttpPost]
    public IActionResult Post(myTask newTask)
    {
        var newId = myTaskService.Post(newTask);      
        return CreatedAtAction(nameof(Post), new {id=newId}, newTask);
    }
        
    [HttpPut("{id}")]
    public ActionResult Put(int id, myTask newTask)
    {
        myTaskService.Put(id, newTask);
        return Ok();
    }
        
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        myTaskService.Delete(id);
        return Ok();
    }
}
