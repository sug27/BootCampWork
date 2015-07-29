$(function () {

	$('form').on('submit', function (e) {
		e.preventDefault();
		var url = 'http://api.openweathermap.org/data/2.5/weather?q=';
		var city = $('#city').val();
		var zp = $('#Zip').val();
		var printOut = '';
		
		
		function convertTemp(kelv) {
			return (parseFloat(kelv) - 273.15) * 1.80 + 32;
		}
		function checkInputs() {
			if (city) {
				url = 'http://api.openweathermap.org/data/2.5/weather?q=' + city;
			}
			else if (zp && (zp!='Please enter a value in either zip or city')) {
				url = 'http://api.openweathermap.org/data/2.5/weather?zip=' + zp + ',us';
			}
			else {
				url = 'file:///C:/Users/Stephen/Desktop/pages/js/weather.html?';
				$('#city').addClass('err');
				$('#Zip').addClass('err');
				$('#Zip').val('Please enter a value in either zip or city');
				return true;
			}
		}
		
		if(checkInputs()==true){
			
		}
		else{
		$('#city').removeClass('err');
		$('#Zip').removeClass('err');
		$.ajax({
			type: "GET",
			url: url,
			dataContent: "json",
			success: function (data) {
				
				printOut += 'forecast is ' + data.weather[0].main + 
				'                  you are right about here ----->' + '\n'
				+ ' temp is ' + convertTemp(data.main.temp).toFixed(2) +
				'\n city is ' + data.name +
				' \n high temp is ' + convertTemp(data.main.temp_max).toFixed(2) +
				'degrees F \n low temp is ' + convertTemp(data.main.temp_min).toFixed(2) + ' degrees F \n' +
				'wind speed is ' + data.wind.speed + ' mph';
				var mapOptions = {
					center: new google.maps.LatLng(data.coord.lat, data.coord.lon),
					zoom: 12
				};
				var map = new google.maps.Map(document.getElementById('map-canvas'),
					mapOptions);
				$('textarea').val(printOut);
			},


		})
	  }
	});
	
	// $.ajax({
	// type:"GET",
	// url:"http://192.168.60.187:1337/api/names",
	// dataContent: "json",
	// success: function(data){
	// 	var $children = $(data).children();
	// 	var forecast = $children.eq(1);
	// 	
	// },
	// 
	// // fail:
	// })	



});