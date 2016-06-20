using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessDashboard.Model.Data_Access_Layer
{
    class TimeLog
    {
        int rowID;
        String timeLogID;
        String taskID;
        DateTime startDate;
        long elapsedTime;
        long interruptTime;
        String comment;
        Boolean isOpen;

        DateTime editTimestamp;
        enum changeFlag
        {
            A,M,D
        };
    }
}
