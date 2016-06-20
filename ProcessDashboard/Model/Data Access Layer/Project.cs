using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessDashboard.Model.Data_Access_Layer
{
    class Project
    {
        String projectID { get; }
        String name { get;}
        DateTime creationDate { get; set; }
        Boolean isActive { get; }
    }
}
