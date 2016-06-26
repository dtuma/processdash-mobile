using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessDashboard.Model.Data_Access_Layer
{
    class TimeLog
    {
        int rowID { get; set; }

        String timeLogID { get; set; }
        String taskID { get; set; }
        DateTime startDate { get; set; }
        long elapsedTime { get; set; }
        long interruptTime { get; set; }
        String comment { get; set; }
        Boolean isOpen { get; set; }

        DateTime editTimestamp { get; set; }
        enum changeFlag
        {
            A, M, D
        };
    }
}
