namespace FlexibleProject.Api.Entities;

public record Login(
    string Uuid,
    string Username,
    string Password,
    string Salt,
    string Md5,
    string Sha1,
    string Sha256);