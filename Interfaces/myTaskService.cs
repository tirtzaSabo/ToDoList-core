using ToDoList.Models;

namespace ToDoList.Interfaces;

  interface ImyTaskService
{
      List<myTask> GetAll();

      myTask Get(int id);
      int Post(myTask newTask);      
      void Put(int id, myTask newTask);
       
       void Delete(int id);
}