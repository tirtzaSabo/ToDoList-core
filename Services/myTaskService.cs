using ToDoList.Models;
using ToDoList.Interfaces;

namespace ToDoList.Services;

public  class myTaskService : ImyTaskService
{
    private  List<myTask> arr;
     myTaskService()  
    {
        arr = new List<myTask>
        {
            new myTask { Id = 1, Name = "Regualr", IsVegan = false},
            new myTask { Id = 2, Name = "Special", IsVegan = false},
            new myTask { Id = 3, Name = "Vegan", IsVegan = true},
        };
    }  

    public  List<myTask> GetAll() => arr;

    public  myTask Get(int id)
    {
        return arr.FirstOrDefault(p => p.Id == id);
    }
    public  int Post(myTask newTask)
    {
        int max = arr.Max(p => p.Id);
        newTask.Id = max + 1;
        arr.Add(newTask);  
        return newTask.Id;      
    }        
    public  void Put(int id, myTask newTask)
    {
        if (id == newTask.Id)
        {
            var task = arr.Find(p => p.Id == id);
            if (task != null)
            {
                int index = arr.IndexOf(task);
                arr[index] =newTask;
            }
        }
    }
        
    public  void Delete(int id)
    {

            var task = arr.Find(p => p.Id == id);
            if (task != null)
            {
                arr.Remove(task);
            }

    }
}