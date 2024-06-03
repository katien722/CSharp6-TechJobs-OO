
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NuGet.Frameworks;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        Job job1 = new Job(); 
        Job job2 = new Job();
        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
        [TestMethod]
        public void TestSettingJobId() 
       {

        int jobId1 = job1.Id;
        int jobId2 = job2.Id; 
        

        string message = "Job Id's should differ by one";
        
        Assert.AreEqual(jobId1, jobId2 - 1, message); 
        
       }

       [TestMethod]


       public void TestJobConstructorSetsAllFields()
       {
        string expectedName = "Product tester";
        string expectedEmployerName = "ACME";
        string expectedEmployerLocation = "Desert";
        string expectedJobType = "Quality Control";
        string expectedJobCoreCompetency = "Persistence";

        string message1 = "Name property should be set correctly"; 
        string message2 = "EmployerName property should be set correctly";
        string message3 = "EmployerLocation property should be set correctly ";
        string message4 = "JobType property should be set correctly";
        string message5 = "JobCoreCompetency property should be set correctly";

        Assert.AreEqual(expectedName,job3.Name, message1);
        Assert.AreEqual(expectedEmployerName, job3.EmployerName.Value, message2); 
        Assert.AreEqual(expectedEmployerLocation, job3.EmployerLocation.Value, message3);
        Assert.AreEqual(expectedJobType, job3.JobType.Value, message4);
        Assert.AreEqual(expectedJobCoreCompetency, job3.JobCoreCompetency.Value, message5);

       }

       public void TestJobsForEquality()
       {
        
    Assert.AreEqual(job1.Id, job2.Id);

       }

    }
}

