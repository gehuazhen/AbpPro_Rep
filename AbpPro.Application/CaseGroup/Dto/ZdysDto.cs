using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.CaseGroup.Dto
{
    public class ZdysDto : EntityDto
    {


        //模板号
        public int? mb_mbh { get; set; }

        //excel 列名
        public string excel_column { get; set; }

        //案件表字段名
        public string sys_colcode { get; set; }

        //案件表字段说明
        public string sys_colname { get; set; }
        //创建日期
        public DateTime CreationTime { get; set; }


        //This method is just used by the Console Application to list tasks
        public override string ToString()
        {
            return string.Format(
                "[Zdys Id={0}, excel_column={1}, sys_colcode={2}, sys_colname={3}",
                Id,
                excel_column,
                sys_colcode,
                sys_colname
                );
        }
        /// <summary>
        /// 根据任务状态，获取定义的css样式
        /// </summary>
        /// <returns></returns>
        public string GetZdysLable()
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
