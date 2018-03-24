using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbpPro.Dto;

namespace AbpPro.Tasks.Dto
{
    public class GetTasksInput: PagedSortedAndFilteredInputDto
    {
       public TaskState? State { get; set; }

       public int ? AssignedPersonId { get; set; }
    }
}
