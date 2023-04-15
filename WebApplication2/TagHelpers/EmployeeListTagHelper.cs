using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication2.Entities;

namespace WebApplication2.TagHelpers
{

    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper:TagHelper
    {
        public List<Employee> _employees;
        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>
            {
                 new Employee
                {
                    Id=1,
                    Firstname="Tural",
                    Lastname="Eliyev",
                    CityId=1
                },
                new Employee
                {
                    Id=2,
                    Firstname="Elvin",
                    Lastname="Camalzade",
                    CityId=2
                },
                new Employee
                {
                    Id=3,
                    Firstname="Omer",
                    Lastname="Cavanshirli",
                    CityId=3
                }
            };
        }

        private const string ListCountAttribute = "count";
        [HtmlAttributeName(ListCountAttribute)]
        public int ListCount { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _employees.Take(ListCount);

            StringBuilder sb=new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendFormat("<h2><a href='/employee/detail/{0}'>{1}</a></h2>", item.Id, item.Firstname);
            }

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
