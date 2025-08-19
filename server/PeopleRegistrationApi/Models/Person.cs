public class Person : Base
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public PersonGender Gender { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    
    public string Nationality { get; set; }
    
    [Required]
    [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Invalid CPF format.")]
    public string Identification { get; set; }
}