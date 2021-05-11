Feature: SearchTVShow
	Searching TV show by name successful

@mytag
Scenario: SearchTVShow
	Given the get searching url is "https://api.themoviedb.org/3/search/tv"
	And the search query is "model"
	When the request is executed
	Then the search status code is OK
	And the searched tv show list contains more than 0 element