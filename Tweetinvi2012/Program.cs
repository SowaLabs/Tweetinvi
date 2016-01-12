using System;
using System.Linq;
using Tweetinvi;
using Tweetinvi.Core.Credentials;

namespace Tweetinvi2012
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = new TwitterCredentials(
                "ConsumerKey",
                "ConsumerSecret",
                "WorkerToken",
                "WorkerSecret"
            );
            Auth.ExecuteOperationWithCredentials(credentials, () => {
                var tweets = Search.SearchTweets("barack obama");
                foreach (var tweet in tweets)
                {
                    Console.WriteLine(tweet.Text);
                }
            });
        }
    }
}
