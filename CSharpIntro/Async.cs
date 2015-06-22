using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// ReSharper disable All

namespace CSharpIntro
{
    public class Async
    {
        public static void GetHttpResponse()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.UserAgent.ParseAdd("MyAgent / 1.0");

            var response = client.GetAsync("https://api.github.com/repos/aspnet/Mvc/commits").Result;

            var body = response.Content.ReadAsAsync<IEnumerable<CommitSummary>>().Result;

            var lastCommitAuthor = body.First().author.login;
            Console.WriteLine("Last commit by {0}", lastCommitAuthor);
        }

        public async static Task GetHttpResponseAsync(int requestNumber)
        {
            Console.WriteLine("Initiating Request {0}", requestNumber);
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.UserAgent.ParseAdd("MyAgent/1.0");

            var response = await client.GetAsync("https://api.github.com/repos/aspnet/Mvc/commits");

            var body = await response.Content.ReadAsAsync<IEnumerable<CommitSummary>>();

            var author = body.ToList()[requestNumber].author.login;

            Console.WriteLine("\tCommit {0} by {1}", requestNumber, author);

            Console.WriteLine("Request Complete {0}", requestNumber);
        }

        public static async Task Run()
        {
            // sync
            GetHttpResponse();

            // async
            await GetHttpResponseAsync(1);

            // make a list of 10 
            var list = Enumerable.Range(2, 10);

            var tasks = list.Select(i => GetHttpResponseAsync(i));

            await Task.WhenAll(tasks);
        }
    }
}
