using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinLearnApp.Models
{
    public class ToDoCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ToDo ToDo;
    }
}
