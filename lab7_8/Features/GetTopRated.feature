Feature: GetTopRated
	Get a list of the top rated TV shows

@mytag
Scenario: Get top of rate TV shows
	Given the get searching url is "https://api.themoviedb.org/3/tv/top_rated"
	And the page is 2
	When the request is executed
	Then the search status code is OK
	And the page is 1
