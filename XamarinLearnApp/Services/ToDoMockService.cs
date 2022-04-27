using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinLearnApp.Models;

namespace XamarinLearnApp.Services
{
    public class ToDoMockService : IDataStore<ToDo>
    {
        private List<ToDoCategory> _toDoCategories;
        private List<ToDo> _toDos;

        public List<ToDo> ToDos;

        public ToDoMockService()
        {
            CreateToDoCategiries();
            CreateToDos();

            ToDos = _toDos;
        }

        public Task<bool> AddItemAsync(ToDo item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ToDo> GetItemAsync(int id) => await Task.FromResult(_toDos.FirstOrDefault(s => s.Id == id));

        public async Task<IEnumerable<ToDo>> GetItemsAsync(bool forceRefresh = false) => await Task.FromResult(_toDos);

        public Task<bool> UpdateItemAsync(ToDo item)
        {
            throw new NotImplementedException();
        }

        public void CreateToDoCategiries()
        {
            _toDoCategories = new List<ToDoCategory>
            {
                new ToDoCategory
                {
                    Id=1,
                    Name="Slow"
                },
                new ToDoCategory
                {
                    Id=2,
                    Name="Middle"
                },
                new ToDoCategory
                {
                    Id=3,
                    Name="High"
                },
            };
        }

        public void CreateToDos()
        {
            _toDos = new List<ToDo>()
            {
                new ToDo {
                    Id = 1,
                    Title="Title Number 1",
                    Description="Description Number 1",
                    CreatedAt=DateTime.Now,
                    UpdatedAt=null,
                    IsActive=true,
                },
                new ToDo {
                    Id = 2,
                    Title="Title Number 2",
                    Description="Description Number 2",
                    CreatedAt=DateTime.Now,
                    UpdatedAt=null,
                    IsActive=true,
                },
                new ToDo {
                    Id = 3,
                    Title="Title Number 3",
                    Description="Description Number 3",
                    CreatedAt=DateTime.Now,
                    UpdatedAt=null,
                    IsActive=true,
                },
                new ToDo {
                    Id = 4,
                    Title="Title Number 4",
                    Description="Description Number 4",
                    CreatedAt=DateTime.Now,
                    UpdatedAt=null,
                    IsActive=false,
                },
                new ToDo {
                    Id = 5,
                    Title="Title Number 5",
                    Description="Description Number 5",
                    CreatedAt=DateTime.Now,
                    UpdatedAt=null,
                    IsActive=false,
                },
            };

        }
    }
}
