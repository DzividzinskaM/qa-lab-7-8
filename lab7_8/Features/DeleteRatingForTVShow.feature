Feature: DelereRatingForTVShow
	Simple calculator for adding two numbers

@mytag
Scenario: DeleteRating
	Given the delete rate url is "https://api.themoviedb.org/3/tv/{tv_id}/rating?api_key=923b6bad1181866112a736086aec0711&guest_session_id=3e506d399bb76ffa3de9df11230b95c5"
	And the tv ID is 331
	When  the delete rate request is executed
	Then the status code is OK
	And the response property status_code is equal 13