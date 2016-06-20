using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessDashboard.Model.Data_Access_Layer
{
    class Task
    {
        String taskID { get; }
        String taskName { get; }
        String projectID { get; }
        DateTime completionDate { get; set; }
        long estimatedTime { get; set; }
        long actualTime { get; set; }
        String taskNote { get; set; }
        int projectOrdinal { get; set; }
        int recentOrdinal { get; set; }
        
    }
}
