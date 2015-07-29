// var xhr = new XMLHttpRequest();
// 
// xhr.open('GET','http://192.168.60.187:1337/api/names',true);
// 
// xhr.onload = function(){
// 	if(xhr.status==200||xhr.status==304){
// 		var response = JSON.parse(xhr.responseText);
// 	 	var newContent = '';
// 		 
// 		for (var i = 0; i < response.people.length;i++) {
// 			 newContent += '<div class = "event">';
// 			 newContent += '<name>'+response.people[i].Name+'</name>';
// 			 newContent += '</div>'
// 			 
// 		 }
// 		 document.getElementById('result').innerHTML = newContent;
// 					
// 
// 	
// 	}	
// }
// 
// xhr.send(null);




$.ajax({
type:"GET",
url:"http://192.168.60.187:1337/api/names",
dataContent: "json",
success: function(data){
	
},

// fail:
})