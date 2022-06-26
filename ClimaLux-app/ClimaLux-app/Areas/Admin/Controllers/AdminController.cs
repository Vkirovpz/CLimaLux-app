using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static ClimaLux_app.Areas.Admin.AdminConstants;

namespace ClimaLux_app.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdministratorRoleName)]
    public abstract class AdminController : Controller
    {
      
    }
}
