namespace FlexibleProject.Api.Entities;

public class User
{
    public string Gender { get; }
    public Name Name { get; }
    public Location Location { get; }
    public string Email { get; }
    public Login Login { get; }
    public Dob Dob { get; }
    public Registered Registered { get; }
    public string Phone { get; }
    public string Cell { get; }
    public Id Id { get; }
    public Picture Picture { get; }
    public string Nat { get; }
    
    public User(string gender,
        Name name,
        Location location,
        string email,
        Login login,
        Dob dob,
        Registered registered,
        string phone,
        string cell,
        Id id,
        Picture picture,
        string nat)
    {
        Gender = gender;
        Name = name;
        Location = location;
        Email = email;
        Login = login;
        Dob = dob;
        Registered = registered;
        Phone = phone;
        Cell = cell;
        Id = id;
        Picture = picture;
        Nat = nat;
    }
}