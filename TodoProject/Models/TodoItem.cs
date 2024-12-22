namespace TodoProject.Models
{
    public class TodoItem
    {
        public int TodoId { get; set; }
        public string Title { get; set; } = "";

        public bool _isDone;

        public bool IsDone
        {
            get => _isDone;
            set
            {
                _isDone = value;

                if (value)
                {
                    CompletedDate = DateTime.Now;
                }
            }
        }
        public DateTime CompletedDate { get; set; }
    }
}
