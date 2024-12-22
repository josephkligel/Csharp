namespace TodoProject.Models
{
	public class TodoItemRepository
	{
		public static List<TodoItem> TodoItems { get; set; } = new()
		{
			new TodoItem
			{
				TodoId = 0,
				Title = "Something"
			}
		};

		public static void AddTodo(TodoItem todoItem)
		{
			int maxId = 0;
			if (TodoItems.Any()) maxId = TodoItems.Max(t => t.TodoId);
			todoItem.TodoId = maxId + 1;
			TodoItems.Add(todoItem);
		}

		public static void UpdateTodo(int todoId, TodoItem todoItem)
		{
			if (todoItem.TodoId != todoId) return;
			var updateTodoItem = TodoItems.FirstOrDefault(t => t.TodoId == todoId);
			if (updateTodoItem != null)
			{
				updateTodoItem.Title = todoItem.Title;
			}
		}

		public static void DeleteTodo(TodoItem todoItem)
		{
			if(todoItem != null)
			{
				TodoItems.Remove(todoItem);
			}
		}
	}
}
