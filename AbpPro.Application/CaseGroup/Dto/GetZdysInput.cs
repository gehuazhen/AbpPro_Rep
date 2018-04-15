using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbpPro.Dto;

namespace AbpPro.CaseGroup.Dto
{
    public class GetZdysInput: PagedSortedAndFilteredInputDto
    {
       public int ? mb_mbh { get; set; }
    }
}
