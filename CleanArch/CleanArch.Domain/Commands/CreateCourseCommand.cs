using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand (string name, string descr, string imageurl)
        {
            Name = name;
            Description = descr;
            ImageUrl = imageurl;
        }
    }
}
