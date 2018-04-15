using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbpPro.CaseGroup.Dto;
using Abp.Application.Services.Dto;

namespace AbpPro.CaseGroup
{
    public interface ICaseGroupAppService:IApplicationService
    {

        GetAjmbOutput GetAjmb();
        GetZdysOutput GetZdys(GetZdysInput input);

        void DeleteAjmb(int ajmb_id);
        void DeleteZdys(int zdys_id);

        void UpdateAjmb(UpdateAjmbInput input);
        void UpdateZdys(UpdateZdysInput input);

        int CreateAjmb(CreateAjmbInput input);
        int CreateZdys(CreateZdysInput input);

    }
}
