using GAMEHUB.WEB.FO.Entities;

namespace GAMEHUB.WEB.FO.Services;

public class ContactService
{
    public List<Contact> Contacts = new List<Contact>();

    public void AddContact(Contact contact)
        => Contacts.Add(contact);

    public void RemoveContact(Contact contact)
        => Contacts.Remove(contact);
}