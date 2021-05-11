using FluentAssertions;
using lab7_8.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;

namespace lab7_8.Steps
{
    [Binding]
    public class SearchTVSteps : BaseSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public IRestResponse response = new RestResponse<List<TVShow>>();
        public SearchResult<TVShow> searchResult;

        public SearchTVSteps(ScenarioContext context)
        {
            _scenarioContext = context;
        }

        [Given(@"the get searching url is ""(.*)""")]
        public void GivenTheGetSearchingUrlIs(string url)
        {
            request = new RestRequest(url, Method.GET);
        }

        [Given(@"the search query is ""(.*)""")]
        public void GivenTheSearchQueryIs(string query)
        {
            AddApiKey();
            AddLanguage();
            AddPage();
            AddIncludeAdult();
            request.AddParameter("query", query);
        }


        [When(@"the request is executed")]
        public void WhenTheRequestIsExecuted()
        {
            response = client.Execute<SearchResult<TVShow>>(request);
            searchResult = client.Execute<SearchResult<TVShow>>(request).Data;
        }

        [Then(@"the search status code is OK")]
        public void ThenTheSearchStatusCodeIsOK()
        {
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Then(@"the searched tv show list contains more than (.*) element")]
        public void ThenTheSearchedTvShowListContainsMoreThanElement(int p0)
        {
            searchResult.total_results.Should().BeGreaterThan(p0);
        }
    }
}
