using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MyLeasings.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPropertyTypes();

        IEnumerable<SelectListItem> GetComboLessees();

        IEnumerable<SelectListItem> GetComboRoles();
    }
}
