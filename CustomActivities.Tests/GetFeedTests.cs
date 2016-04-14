using System;
using System.Activities;
using System.Linq;
using System.ServiceModel.Syndication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomActivities.Tests
{
    [TestClass]
    public class GetFeedTests
    {
        [TestMethod]
        public void Test_Feed_Returns_Correct_Amount_Of_Results()
        {
            var act = new GetFeed
            {
                FeedUrl= "http://www.ntv.com.tr/gundem.rss"
            };
            var feed = WorkflowInvoker.Invoke<SyndicationFeed>(act);
            Assert.IsNotNull(feed,"No feed returned");
            Assert.AreEqual(49,feed.Items.Count(),"Incorrect number of items");
        }
    }
}
