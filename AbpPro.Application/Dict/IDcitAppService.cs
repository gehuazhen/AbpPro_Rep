using Abp.Application.Services;
using AbpPro.Dict.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.Dict
{
    /**
	 * description: 
	 * author: 
	 * date: 
	 * modify:
	 */
  public  interface IDcitAppService : IApplicationService
    {
        GetMDictOutput GetMDict();
        GetMDictValueOutput GetMDictValue();

        void DeleteMDict(int mdict_id);

        void UpdateMDict(UpdateMDictInput input);

        int CreateMDict(CreateMDictInput input);

        void DeleteMDictValue(int mdict_alue_id);

        void UpdateMDictValue(UpdateMDictValueInput input);

        int CreateMDictValue(CreateMDictValueInput input);

    }
}
