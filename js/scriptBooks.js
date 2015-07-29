$(function () {
	var urlbk;
	var urlvc = 'http://tts-api.com/tts.mp3?q=';
	//localStorage.clear();
	var titles = [];
	var bookAuthors = [];
	var listString = [];



	//function to check input fields
	function checkInputs() {
		if ($('author').classList.contains('err')) {
			return true;
		}
	}



	//function to append to wishlist
	function appendList(list) {
		for (var i = 0; i < list.length; i++) {
			$('.modal-content').append(list[i] + '</br>');

		}
	}
	

	// check for titles on cpu
	if (localStorage.getItem('bookTitles')) {
		var tempTitle = JSON.parse(localStorage.getItem('bookTitles'));
		titles = tempTitle;
	}
	
	//check for authors on cpu
	if (localStorage.getItem('authors')) {
		var tempAuthor = JSON.parse(localStorage.getItem('authors'));
		bookAuthors = tempAuthor;
	}
	//check for wishlist on cpu
	if (localStorage.getItem('wishlist')) {
		var tempList = JSON.parse(localStorage.getItem('wishlist'));
		listString = tempList;
		if (listString) {
			appendList(listString);
		}
	}


	//set autocomplete settings
	$('#bktitle').autocomplete({
		source: titles

	});


	$('#author').autocomplete({
		source: bookAuthors
	});


	//wishlist removal
	$('#clear').on('click', function () {
		for (var i = 0; i < listString.length; i++) {
			localStorage.removeItem('wishlist');
		}
		$('.modal-content').html('');
	})



	$('form').on('submit', function (e) {
		e.preventDefault();
		//check for valid entries
		if (checkInputs != true) {
			// check if array exists
			//if author field exists
			if ($('#author').val().length > 2) {
				var auth = $('#author').val();
				localStorage.setItem('authors', JSON.stringify(bookAuthors));
				urlbk = 'https://www.googleapis.com/books/v1/volumes?q=' + 'inauthor:' + $('#author').val();
				$('#author').removeClass('err');
				$('#bktitle').removeClass('err');
			}
			//if title field has inputs
			else if ($('#bktitle').val().length > 2) {
				urlbk = 'https://www.googleapis.com/books/v1/volumes?q=' + 'intitle:' + $('#bktitle').val();
				var titl = $('#bktitle').val();
				localStorage.setItem('bookTitles', JSON.stringify(titles));
				$('#author').removeClass('err');
				$('#bktitle').removeClass('err');
			}
			//sets error class
			else {
				$('#author').addClass('err');
				$('#bktitle').addClass('err');
			}


			$.ajax({
				type: "GET",
				url: urlbk,
				dataContent: "json",
				success: function (data) {
					$('#table tbody').html("");
					var title;
					var titleLink = [];
					var author = '';
					var thumb;
					var desc;
					var buy = '';
					var books = [];
					for (var key in data.items) {
						// start main loop
						if (data.items[key].volumeInfo.title) {
							title = data.items[key].volumeInfo.title;
							titleLink = title.split(' ');

						}
					
						// check authors
						if (data.items[key].volumeInfo.authors) {
							author = '';
							for (var auth in data.items[key].volumeInfo.authors) {
								author += data.items[key].volumeInfo.authors[auth] + '\n';
							}
						}
					
						// check and get desc
						if (data.items[key].volumeInfo.description) {
							desc = data.items[key].volumeInfo.description;
						}
						else {
							desc = "none available";
						}
					
						// check buylink
						if (data.items[key].volumeInfo.infoLink) {
							buy = '';
							buy += data.items[key].volumeInfo.infoLink;
						}
						else {
							buy = 'not available';
						}

						urlvc = 'http://tts-api.com/tts.mp3?q=';
					
						// process title
						for (var words in titleLink) {
							urlvc += titleLink[words] + '+';

						}
					
						// get thumbs
						if (data.items[key].volumeInfo.imageLinks == null) {
							thumb = "not available";
						}
						else {
							thumb = data.items[key].volumeInfo.imageLinks.smallThumbnail;
						}
					
						// append to table
						$('#table tbody').append('<tr><td><button class="btn btn-default" type="submit">Add to list</button></td><td><img src =' + thumb + 'class = "img-responsive" height = "150" width = "150" alt = "no pic available" </img></td><td><a href =' + urlvc + ' target = "_blank">' + title + '</td><td>' + author + '</td><td>' + desc + '</td><td><a class="btn btn-default" href=' + buy + 'role="button">Buy</a></td></tr>');
					}
					$('#bktitle').val("");
					$('#author').val("");
				},
			})
			$('#table tbody').on('click', 'button', function (e) {



				var btn = e.target.closest('tr');

				var par = btn.children;
				var authorsList = par[3].textContent;


				var wishTitle = par[2].textContent;
				var lt = wishTitle;



				var la = authorsList;
				listString.push(lt);
				listString.push(la);

				var toList = [lt, la];
				appendList(toList);

				localStorage.setItem('wishlist', JSON.stringify(listString));

			});


		}
	})
});