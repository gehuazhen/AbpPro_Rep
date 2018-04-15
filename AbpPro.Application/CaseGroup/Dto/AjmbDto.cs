using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.CaseGroup.Dto
{
    public class AjmbDto : EntityDto
    {
       // public Guid mb_mbh { get; set; }

        public string mb_mbmc { get; set; }

        public string mb_cjr { get; set; }

        //创建日期
        public DateTime CreationTime { get; set; }


        //This method is just used by the Console Application to list tasks
        public override string ToString()
        {
            return string.Format(
                "[Ajmb Id={0}, mb_mbmc={1}, mb_cjr={2}, CreationTime={3}",
                Id,
                mb_mbmc,
                mb_cjr,
                CreationTime
                );
        }
        /// <summary>
        /// 根据任务状态，获取定义的css样式
        /// </summary>
        /// <returns></returns>
        public string GetAjmbLable()
        {
            /*
            string style = "";
            TaskState state = (TaskState)Enum.Parse(typeof(TaskState), this.State.ToString());

            switch (state)
            {
                case TaskState.Open:
                    style = "fa-spinner fa-spin ";
                    break;
                case TaskState.Completed:
                    style = "fa-check-circle ";
                    break;
            }
            return style;*/
            return "";

        }


    }
}
