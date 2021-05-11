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
    public class RateTVShowSteps : BaseSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public IRestResponse response = new RestResponse<Response>();
        public Response responseData;

        public RateTVShowSteps(ScenarioContext context)
        {
            _scenarioContext = context;
        }
        
        [Given(@"the post rate url is ""(.*)""")]
        public void GivenThePostRateUrlIs(string url)
        {
            request = new RestRequest(url, Method.POST);
        }

        [Given(@"the tv ID id (.*)")]
        public void GivenTheTvIDId(int id)
        {
            //AddApiKey();
            //AddGuestSessionID();
            //request.AddParameter("guest_session_id", "3e506d399bb76ffa3de9df11230b95c5");
            request.AddParameter("tv_id", id);
        }

        [Given(@"the value of rate is (.*)")]
        public void GivenTheValueOfRateIs(Decimal rate)
        {
            request.AddJsonBody(new Rating { value = rate });
        }

        [When(@"the post rate request is executed")]
        public void WhenThePostRateRequestIsExecuted()
        {
            response = client.Execute<Response>(request);
            responseData = client.Execute<Response>(request).Data;
        }

        [Then(@"the status code is Create")]
        public void ThenTheStatusCodeIsCreate()
        {
            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }

        [Then(@"the response property status_code is equal (.*)")]
        public void ThenTheResponsePropertyStatus_CodeIsEqual(int code)
        {
            responseData.status_code.Should().Be(code);
        }



    }
}
