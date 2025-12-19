namespace EntityFramework_Task.Data.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Surname { get; set; }
    public string? Email { get; set; }
}
