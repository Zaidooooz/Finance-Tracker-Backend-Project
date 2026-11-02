public class Category
{
	public Guid? Id { get; set; }
	public Guid UserId { get; set; }
	public string Name { get; set; }
	public string Type { get; set; }

	public User User { get; set; }
	public List<Operation> Operations { get; set; }
}
