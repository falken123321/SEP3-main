using System.Collections.Generic;
using System.Threading.Tasks;
using TodosWebGraphQL.Models;

namespace TodosWebGraphQL.Data
{
    public interface ITodoData
    {


        IList<Todo> GetTodos();
        Task<Todo> AddTodo(Todo todo);
         int RemoveTodo(int todoId);

         Task<Todo> Update(Todo todo);

        Todo Get(int id);






    }
}