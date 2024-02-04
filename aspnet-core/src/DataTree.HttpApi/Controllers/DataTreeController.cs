using DataTree.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DataTree.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DataTreeController : AbpControllerBase
{
    protected DataTreeController()
    {
        LocalizationResource = typeof(DataTreeResource);
    }
}
