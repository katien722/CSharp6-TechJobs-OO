using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType PositionType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            public int Id { get; }
            private static int nextId = 1;

            public Job()
        {
            Id = nextId;
            nextId++;
        }
    public Job(string name, Employer employerName, Location employerLocation, PositionType positionType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            PositionType = positionType;
            JobCoreCompetency = jobCoreCompetency;
        
        }


        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            if(Name.ToString()== "" || Name == null)
            {
                Name = "Data not available";
            }
             if(EmployerName.ToString()== "" || EmployerName == null)
            {
                EmployerName.Value = "Data not available";
            }
            if(EmployerLocation.ToString()== "" || EmployerLocation == null)
            {
                EmployerLocation.Value = "Data not available";
            }
            if(PositionType.ToString()== "" || PositionType == null)
            {
                PositionType.Value = "Data not available";
            }
            if(JobCoreCompetency.ToString()== "" || JobCoreCompetency == null)
            {
                JobCoreCompetency.Value = "Data not available";
            }

            return Environment.NewLine + "ID: " + Id + Environment.NewLine +
            "Name: " + Name + Environment.NewLine +
            "Employer: " + EmployerName + Environment.NewLine +
            "Location: " + EmployerLocation + Environment.NewLine + 
            "Position Type: " + PositionType + Environment.NewLine +
            "Core Competency: " + JobCoreCompetency + Environment.NewLine;  
        }

    }
    }

