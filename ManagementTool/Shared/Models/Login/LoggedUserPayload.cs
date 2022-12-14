using ManagementTool.Shared.Models.Database;

namespace ManagementTool.Shared.Models.Login; 

public class LoggedUserPayload {


    public string? UserName { get; set; }
    public string? FullName { get; set; }
    public Role[]? Roles { get; set; }


    public LoggedUserPayload(string? userName, string? fullName, Role[]? roles) {
        UserName = userName;
        FullName = fullName;
        Roles = roles;
    }
}