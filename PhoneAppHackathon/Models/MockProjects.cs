using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAppHackathon.Models
{
    public class MockProjects
    {
        public static ObservableCollection<Project> GetProjects()
        {
            var result = new ObservableCollection<Project>();
            result.Add(new Project { Title = "Project 1", Description = "This is a cool project 1", Priority = Priority.Medium, Deadline = DateTime.Now.AddDays(10), Id = 1, Status = Status.InProgress });
            result.Add(new Project { Title = "Project 2", Description = "This is a cool project 2", Priority = Priority.High, Deadline = DateTime.Now.AddDays(18), Id = 2, Status = Status.InProgress });
            return result;
        }
    }
}
