using Microsoft.AspNetCore.Identity;
using CleanBlazor.WebUI.Shared.Authorization;

namespace CleanBlazor.Infrastructure.Identity;

public class ApplicationRole : IdentityRole
{
    public Permissions Permissions { get; set; }
}
