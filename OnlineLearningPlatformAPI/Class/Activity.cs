using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLearningPlatformAPI.Class
{
    public class Activity
    {
        public int activityId { get; set; }
        public int lessonId { get; set; }
        public int courseId { get; set; }
        public string activityTitle { get; set; }
        public string fileUrl { get; set; }
    }
}
