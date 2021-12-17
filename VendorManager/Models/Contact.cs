namespace VendorManager.Models
{
  public class Contact
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Pronouns { get; set; }

    public Contact(string name, string email, string phone = "Not given", string pronouns = "They/them")
    {
      //TODO
    }
  }
}