
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
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

        Job job5 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
        
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
        string expectedPositionType = "Quality Control";
        string expectedJobCoreCompetency = "Persistence";

        string message1 = "Name property should be set correctly"; 
        string message2 = "EmployerName property should be set correctly";
        string message3 = "EmployerLocation property should be set correctly ";
        string message4 = "PositionType property should be set correctly";
        string message5 = "JobCoreCompetency property should be set correctly";

        Assert.AreEqual(expectedName,job3.Name, message1);
        Assert.AreEqual(expectedEmployerName, job3.EmployerName.Value, message2); 
        Assert.AreEqual(expectedEmployerLocation, job3.EmployerLocation.Value, message3);
        Assert.AreEqual(expectedPositionType, job3.PositionType.Value, message4);
        Assert.AreEqual(expectedJobCoreCompetency, job3.JobCoreCompetency.Value, message5);

       }

       public void TestJobsForEquality()
       {
        
    Assert.AreEqual(job1.Id, job2.Id);

       }
[TestMethod]
public void TestToStringStartsAndEndsWithNewLine()

{ 
    string expected = Environment.NewLine + "ID: " + "23" + Environment.NewLine +
             "Name: " + "Product tester" + Environment.NewLine + 
            "Employer: " + "ACME" + Environment.NewLine +
            "Location: " + "Desert" + Environment.NewLine + 
            "Position Type: " + "Quality Control" + Environment.NewLine +
            "Core Competency: " + "Persistence" + Environment.NewLine;

    string actual = job3.ToString();
    string message = "Returned string must start and end with a blank line";

    Assert.AreEqual(expected, actual, message);
    Assert.IsTrue(expected.StartsWith(Environment.NewLine));
    Assert.IsTrue(expected.EndsWith(Environment.NewLine));
}
[TestMethod]
public void TestToStringContainsCorrectLabelsAndData()
{
    string expected = Environment.NewLine + "ID: " + "13" + Environment.NewLine + //proper id needed
            "Name: " + "Product tester" + Environment.NewLine + 
            "Employer: " + "ACME" + Environment.NewLine +
            "Location: " + "Desert" + Environment.NewLine + 
            "Position Type: " + "Quality Control" + Environment.NewLine +
            "Core Competency: " + "Persistence" + Environment.NewLine;

    string actual = job3.ToString();
    string message = "Correct labels and data needed";

    Assert.AreEqual(expected, actual, message);

}
[TestMethod]
public void TestToStringHandlesEmptyField()
{
    string expected = Environment.NewLine + "ID: " + "20" + Environment.NewLine + 
            "Name: " + "Product tester" + Environment.NewLine +
            "Employer: " + "Data not available" + Environment.NewLine +
            "Location: " + "Desert" + Environment.NewLine + 
            "Position Type: " + "Quality Control" + Environment.NewLine +
            "Core Competency: " + "Persistence" + Environment.NewLine;

    string actual = job5.ToString();
    string message = "Must handle empty field";

    Assert.AreEqual(expected, actual, message);

}
    }
}

