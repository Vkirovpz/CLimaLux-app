using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using static ClimaLux_app.Areas.Admin.AdminConstants;

namespace ClimaLux_app.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdministratorRoleName)]
    public abstract class AdminController : System.Web.Mvc.Controller
    {
      
    }
}
