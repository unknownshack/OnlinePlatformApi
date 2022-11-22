using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLearningPlatformAPI.Class
{
    public class Payment
    {
        public int paymentId { get; set; }
        public int userId { get; set; }
        public int courseId { get; set; }
        public int amount { get; set; }
    }
}
