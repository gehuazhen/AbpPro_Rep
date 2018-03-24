using Abp.Web.Mvc.Views;

namespace AbpPro.Web.Views
{
    public abstract class AbpProWebViewPageBase : AbpProWebViewPageBase<dynamic>
    {

    }

    public abstract class AbpProWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpProWebViewPageBase()
        {
            LocalizationSourceName = AbpProConsts.LocalizationSourceName;
        }
    }
}