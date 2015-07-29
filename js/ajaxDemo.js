
var xhr = new XMLHttpRequest();


xhr.open('GET','http://192.168.60.187:1337/api/hello',true);

xhr.onload = function(){
	if(xhr.status==200 || xhr.states == 304){
		var response = JSON.parse(xhr.responseText);
		var responseJSON = JSON.stringify(response);
		document.getElementById('result').innerHTML = 'I hate ' + response.msg;
	}

}

xhr.send(null);