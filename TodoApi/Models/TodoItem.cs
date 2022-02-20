namespace TodoApi.Models
{
    public class TodoItem
    // Class here means table name in the database
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        // the above are columns inside the table -- class --  thus created
    }
}