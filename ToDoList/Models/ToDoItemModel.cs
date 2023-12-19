namespace ToDoList.Models
{
    public class ToDoItemModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public DateTime Date { get; set; }

        public int Status { get; set; }
    }
}
