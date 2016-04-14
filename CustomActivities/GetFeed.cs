using System.Activities;
using System.ServiceModel.Syndication;
using System.Xml;

namespace CustomActivities
{
    public class GetFeed : CodeActivity<SyndicationFeed>
    {
        public InArgument<string> FeedUrl { get; set; }

        public OutArgument<SyndicationFeed> FeedResult { get; set; }

        protected override SyndicationFeed Execute(CodeActivityContext context)
        {
            var feed = SyndicationFeed.Load(XmlReader.Create(FeedUrl.Get(context)));
            return feed;
        }
    }
}