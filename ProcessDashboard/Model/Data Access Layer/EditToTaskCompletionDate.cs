using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessDashboard.Model.Data_Access_Layer
{
    class EditToTaskCompletionDate
    {
        String taskID { get; set; }
        DateTime newCompletionDate { get; set; }
        DateTime editTimestamp { get; set; }
    }
}
