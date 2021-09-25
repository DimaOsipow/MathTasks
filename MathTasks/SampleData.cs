using MathTasks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathTasks
{
    public static class SampleData
    {
        public static void initData (ApplicationDbContext context)
        {
            if (!context.Tasks.Any())
            {
                context.Tasks.Add(new Data.Entityes.Tasks() { title = "aua", Html = "asa " }); ;
                context.SaveChanges();
            }
            
        }
    }
}
