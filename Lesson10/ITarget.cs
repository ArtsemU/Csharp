using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    // Таргет - что бы не путать потом Таск
    interface ITarget
    {
        string Title { get; set; }

        string Description { get; set; }

        string DisplayInfo();
    }
}
