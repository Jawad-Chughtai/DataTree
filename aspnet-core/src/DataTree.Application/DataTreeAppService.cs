using System;
using System.Collections.Generic;
using System.Text;
using DataTree.Localization;
using Volo.Abp.Application.Services;

namespace DataTree;

/* Inherit your application services from this class.
 */
public abstract class DataTreeAppService : ApplicationService
{
    protected DataTreeAppService()
    {
        LocalizationResource = typeof(DataTreeResource);
    }
}
