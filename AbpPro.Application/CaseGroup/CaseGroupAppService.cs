
using Abp.Domain.Repositories;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using AbpPro.CaseGroup.Dto;
using AutoMapper;
using Abp.Timing;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.AutoMapper;
using Abp.Linq.Extensions;



namespace AbpPro.CaseGroup
{
    public class CaseGroupAppService:AbpProAppServiceBase, ICaseGroupAppService
    {
        private readonly IRepository<M_AJMB> _ajmbRepository;
        private readonly IRepository<M_ZDYSB> _zdysRepository;

        public  CaseGroupAppService(IRepository<M_AJMB> ajmbRepository, IRepository<M_ZDYSB> zddyRepository)
        {
            _ajmbRepository = ajmbRepository;
            _zdysRepository = zddyRepository;
        }

        public GetAjmbOutput GetAjmb()
        {
            var query = _ajmbRepository.GetAll();
            return new GetAjmbOutput
            {
                Ajmb = Mapper.Map<List<AjmbDto>>(query.ToList())
            };
        }

        public void UpdateAjmb(UpdateAjmbInput input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            // Logger.Info("Updating a task for input: " + input);

            //Retrieving a task entity with given id using standard Get method of repositories.
            var ajmb = _ajmbRepository.Get(input.Id);

            if(input.mb_mbmc.Length>0)
            {
                ajmb.mb_mbmc = input.mb_mbmc;
            }
            if (input.mb_cjr.Length > 0)
            {
                ajmb.mb_cjr = input.mb_cjr;
            }
            //We even do not call Update method of the repository.
            //Because an application service method is a 'unit of work' scope as default.
            //ABP automatically saves all changes when a 'unit of work' scope ends (without any exception).
        }
        public int CreateAjmb(CreateAjmbInput input)
        {
            Logger.Info("Insert into a task for input:" + input);
            var ajmb = new M_AJMB
            {
               mb_cjr= input.mb_cjr,
               mb_mbmc= input.mb_mbmc,
               CreationTime = Clock.Now
            };
            return _ajmbRepository.InsertAndGetId(ajmb);
        }

        public void DeleteAjmb(int ajmbId)
        {
            var ajmb = _ajmbRepository.Get(ajmbId);
            if (ajmb != null)
            {
                _ajmbRepository.Delete(ajmbId);
            }
        }

        public GetZdysOutput GetZdys(GetZdysInput input )
        {
            var query = _zdysRepository.GetAll();
            if (input.mb_mbh.HasValue)
            {
                query = query.Where(t => t.mb_mbh == input.mb_mbh);
            }
            return new GetZdysOutput
            {
                Zdys = Mapper.Map<List<ZdysDto>>(query.ToList())
            };
        }

        public void UpdateZdys(UpdateZdysInput input)
        {
             var updateZdys = Mapper.Map<M_ZDYSB>(input);
            _zdysRepository.Update(updateZdys);

        }
        public int CreateZdys(CreateZdysInput input)
        {
          
            var zdys = new M_ZDYSB
            {
                mb_mbh = input.mb_mbh,
                excel_column = input.excel_column,
                sys_colname = input.sys_colname,
                sys_colcode = input.sys_colcode,
                CreationTime = Clock.Now
            };
            return _zdysRepository.InsertAndGetId(zdys);
        }

        public void DeleteZdys(int zdysId)
        {
            var zdys = _zdysRepository.Get(zdysId);
            if (zdys != null)
            {
                _zdysRepository.Delete(zdysId);
            }
        }



    }
}
