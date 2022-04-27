using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinLearnApp.Models;
using XamarinLearnApp.Services;
using XamarinLearnApp.Views;

namespace XamarinLearnApp.ViewModels
{
    public class ToDosViewModel
    {
        public List<ToDo> ToDos { get; private set; }

        private readonly ToDoMockService _toDoMockService = new ToDoMockService();

        public ToDosViewModel()
        {
            ToDos = _toDoMockService.ToDos;
        }

    }
}
