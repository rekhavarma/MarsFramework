using Excel.Log;
using MarsFramework.Config;
using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.Base;




namespace MarsFramework
{
   
    public class Program 
    {
       

       
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            [Test, Order(1)]
            [Obsolete]
            public void CreateShareSkill()
            {
                //Start the Reports
                ExtentReports();
                test = extent.StartTest("Create ShareSkill");
                test.Log(LogStatus.Info, "ShareSkills");
                //taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");
                //Create Share Skills      
                ShareSkill skillObj = new ShareSkill();
                skillObj.AddShareSkill();
                skillObj.ValidateCreateListing();


            }
            [Test, Order(2)]
            [Obsolete]
            public void EditShareSkill()
            {
                //Start the Reports
                ExtentReports();
                test = extent.StartTest("Edit ShareSkill");
                test.Log(LogStatus.Info, "ShareSkills");
                //taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");
                ManageListings MLObj = new ManageListings();
                //Edit Share Skills 
                MLObj.EditShareSkill();
                MLObj.ValidateEditListing();
            }

            [Test, Order(3)]
            [Obsolete]
            public void ViewShareSkill()
            {
                //Start the Reports
                ExtentReports();
                test = extent.StartTest("View Manage Listing");
                test.Log(LogStatus.Info, "ManageListings");
                //taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ManageListngs");
                //View Share Skills
                ManageListings MLObj = new ManageListings();
                MLObj.ViewShareSkill();
                MLObj.ValidateViewListing();




            }
            [Test, Order(4)]
            [Obsolete]
            public void DeleteShareSkill()
            {
                //Start the Reports
                ExtentReports();
                test = extent.StartTest("Delete Manage Listing");
                test.Log(LogStatus.Info, "ManageListings");
                //taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ManageListngs");
                //Delete Share Skills
                ManageListings MLObj = new ManageListings();
                MLObj.DeleteShareSkill();
                MLObj.ValidateDeleteListing();
            }
        }
    }
}