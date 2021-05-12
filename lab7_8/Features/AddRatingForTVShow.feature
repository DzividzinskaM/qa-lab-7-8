Feature: AddRatingForTVShow
	Add rating for tv show by id successful

@mytag
Scenario: Rate TV show
	Given the post rate url is "https://api.themoviedb.org/3/tv/{tv_id}/rating?api_key=923b6bad1181866112a736086aec0711&guest_session_id=3e506d399bb76ffa3de9df11230b95c5"
	And the tv ID is 331
	And the value of rate is 9.5
	When the post rate request is executed
	Then the status code is Create
	And the response property status_code is equal 1
