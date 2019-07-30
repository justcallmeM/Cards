using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Cards.UI.Web;
using Cards.UI.Web.DataAccessLayer;
using Cards.UI.Web.Models;

namespace Jobs
{
    class Program
    {
        static void Main()
        {
            ExecuteJob();
            Console.ReadKey(true);
        }
        async static void ExecuteJob()
        {
            // construct a scheduler factory
            NameValueCollection props = new NameValueCollection
                {
                    { "quartz.serializer.type", "binary" }
                };
            StdSchedulerFactory factory = new StdSchedulerFactory(props);

            // get a scheduler
            IScheduler sched = await factory.GetScheduler();
            await sched.Start();

            IJobDetail job2 = JobBuilder.Create<CheckExpiration>()
                .WithIdentity("myJob", "group1") // name "myJob", group "group1"
                //.UsingJobData("jobSays", "Hello World!")
                //.UsingJobData("myDouble", 3.1)
                .Build();

            ITrigger trigger = TriggerBuilder.Create()
              .WithIdentity("myTrigger", "group1")
              .StartNow()
              .WithSimpleSchedule(x => x
                  .WithIntervalInSeconds(15)
                  .RepeatForever())
              .Build();

            //trigger that will fire daily at 1:00 am:
            ITrigger trigger1 = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(1, 00))
                .ForJob(job2)
                .Build();

            //trigger that will fire daily at 23:59 pm:
            ITrigger trigger2 = TriggerBuilder.Create()
                .WithIdentity("trigger3", "group1")
                .WithCronSchedule("0 59 23 1/1 * ? *")
                .ForJob("job2", "group1")
                .Build();

            //reiktu naudoti trigger1 arba trigger2
            await sched.ScheduleJob(job2, trigger);
        }
    }
}
