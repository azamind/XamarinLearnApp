using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinLearnApp.Models
{
   public class ToDo
   {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }  
        public int CategoryId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ToDoCategory Category { get; set; }
   }
}
