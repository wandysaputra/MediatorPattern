using System.ComponentModel.DataAnnotations;

namespace MediatRDemo;

public class Contact
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }


}