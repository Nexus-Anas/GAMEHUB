using GAMEHUB.WEB.FO;
using GAMEHUB.WEB.FO.Entities;
using GAMEHUB.WEB.FO.Services;
using Microsoft.AspNetCore.Components;

namespace GAMEHUB.WEB.FO.Pages.Contact;

public partial class Index
{
    [Inject]
    ContactService _service {  get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    void Create()
    {
        if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email))
        {
            var contact = new Entities.Contact(Name, Email);
            _service.AddContact(contact);
            Name = string.Empty;
            Email = string.Empty;
        }
    }
}