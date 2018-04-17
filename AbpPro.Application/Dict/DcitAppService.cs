using Abp.Domain.Repositories;
using Abp.Timing;
using AbpPro.CaseGroup;
using AbpPro.CaseGroup.Dto;
using AbpPro.Dict.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.Dict
{
    /**
	 * description: 字典服务
	 * author: 黄永生
	 * date: 2018-04-15
	 * modify:add
	 */
    public class DcitAppService : AbpProAppServiceBase, IDcitAppService
    {
        private readonly IRepository<M_DICT> _mdictRepository;
        private readonly IRepository<M_DICTVALUE> _mdictValueRepository;

        public DcitAppService(IRepository<M_DICT> mdictRepository, IRepository<M_DICTVALUE> mdictValueRepository)
        {
            _mdictRepository = mdictRepository;
            _mdictValueRepository = mdictValueRepository;
        }

        public int CreateMDict(CreateMDictInput input)
        {
            Logger.Info("Insert into a M_DICT for input:" + input);

            var mdict = new M_DICT
            {
                dict_code = input.dict_code,
                dict_name = input.dict_name,
                CreationTime = Clock.Now
            };
            return _mdictRepository.InsertAndGetId(mdict);
        }

        public int CreateMDictValue(CreateMDictValueInput input)
        {
            Logger.Info("Insert into a M_DICTVALUE for input:" + input);

            var mdictValue = new M_DICTVALUE
            {
                dict_valcode = input.dict_valcode,
                dict_valname = input.dict_valname,
                CreationTime = Clock.Now
            };
            return _mdictValueRepository.InsertAndGetId(mdictValue);
        }

        public void DeleteMDict(int mdictId)
        {
            Logger.Info("Delete a M_DICT for id:" + mdictId);

            var mdict = _mdictRepository.Get(mdictId);
            if (mdict != null)
            {
                _mdictRepository.Delete(mdictId);
            }
        }


        public void DeleteMDictValue(int mdictValueId)
        {
            Logger.Info("Delete a M_DICTVALUE for id:" + mdictValueId);

            var mdictValue = _mdictValueRepository.Get(mdictValueId);
            if (mdictValue != null)
            {
                _mdictValueRepository.Delete(mdictValueId);
            }
        }

        public GetMDictOutput GetMDict()
        {
            var query = _mdictRepository.GetAll();
            return new GetMDictOutput
            {
                MDict = Mapper.Map<List<MDictDto>>(query.ToList())
            };
        }

        public GetMDictValueOutput GetMDictValue()
        {
            var query = _mdictValueRepository.GetAll();
            return new GetMDictValueOutput
            {
                MDictValue = Mapper.Map<List<MDictVlueDto>>(query.ToList())
            };
        }

        public void UpdateMDict(UpdateMDictInput input)
        {
            Logger.Info("Update a M_DICT for input:" + input);

            var updateMdict = Mapper.Map<M_DICT>(input);
            _mdictRepository.Update(updateMdict);
        }

        public void UpdateMDictValue(UpdateMDictValueInput input)
        {
            Logger.Info("Update a M_DICTVALUE for input:" + input);

            var updateMdictValue = Mapper.Map<M_DICTVALUE>(input);
            _mdictValueRepository.Update(updateMdictValue);
        }
    }
}
