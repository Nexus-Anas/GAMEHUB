namespace GAMEHUB.WEB.FO.Entities;

public class Contact
{
    public string Name { get; }
    public string Email { get; }

    public Contact(string name, string email)
    {
        Name = name;
        Email = email;
    }
}