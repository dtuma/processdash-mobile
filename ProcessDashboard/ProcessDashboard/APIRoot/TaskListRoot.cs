﻿#region
using System.Collections.Generic;
using ProcessDashboard.DTO;
#endregion
/*
 * Classes for Parsing JSON to OO Model Objects.
 * Variable names are case-sensitive. Donot change or else parsing will fail
 * 
 */
namespace ProcessDashboard.APIRoot
{
    public class TaskListRoot
    {
        public List<Task> ProjectTasks { get; set; }
        public Project ForProject { get; set; }
        public string Stat { get; set; }
        public Err Err { get; set; }
    }
}