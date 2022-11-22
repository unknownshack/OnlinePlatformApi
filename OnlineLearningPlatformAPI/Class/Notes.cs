using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLearningPlatformAPI.Class
{
    public class Notes
    {
        [Key]
        public int noteId { get; set; }
        public int lessonId { get; set; }
        public string noteTitle { get; set; }
        public string noteDesc { get; set; }
    }
}
