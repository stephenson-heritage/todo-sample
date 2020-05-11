using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models {
	public class TodoContext : DbContext {

		public DbSet<TodoItem> TodoItems { get; set; }
		public DbSet<Person> Persons { get; set; }

		public TodoContext (DbContextOptions<TodoContext> options) : base (options) { }

	}
}