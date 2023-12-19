using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDoItemModel
    {
        public int Id { get; set; }


        [MaxLength(200)]
        public string? Name { get; set; }

        public DateTime Date { get; set; }

        public int Status { get; set; }
    }
}
