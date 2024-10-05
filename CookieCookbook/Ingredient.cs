namespace CookieCookbook
{
	public class Ingredient: IPrintable
	{
		public int ID { get; set; }
		public string? Name { get; set; }
		public string? Instructions { get; set; }

        public Ingredient(int id, string name, string instructions)
        {
			ID = id;
			Name = name;
			Instructions = instructions;
        }

        public void Print()
		{
            Console.WriteLine($"{ID}.{Name}");
		}
	}
}
