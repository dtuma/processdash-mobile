using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessDashboard.Model.Data_Access_Layer
{
    class EditsToEstimatedTime
    {
        String taskID { get; set; }
        long newEstimatedTime { get; set; }
        DateTime editTimeStamp { get; set; }
    }
}
