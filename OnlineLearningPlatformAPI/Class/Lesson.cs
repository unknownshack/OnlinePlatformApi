using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLearningPlatformAPI.Class
{
    public class Lesson
    {
        public int lessonId { get; set; }
        public int orderNum { get; set; }
        public string contentName { get; set; }
        public string contentType { get; set; }
        public int courseId { get; set; }
        public string videoUrl { get; set; }
        public bool completed { get; set; }
    }
}
