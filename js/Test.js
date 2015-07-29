$(function () {
	// get questions
	
	
	var submitAnswers = [];
	
	
	
	// $.ajax POST area
	// space for submit functions
	// 
	// $('.title').eq(i).text() returns label text of ith element
	// var titles = $('.title').eq(0);
	// console.log(titles.text());
	// returns all checked radios
	// var check = $('input:checked');
	// take checked radios and labels and push to submitAnswers 
	// stringify submitAnswers	
	
	
	// submit {testerName, test, answers[]} 
	$('#btn').on('click', function(e){
		
		var AnswerSht = [];
		for (var k = 0; k < $('input:checked').length; k++) {
			AnswerSht.push($('input:checked').eq(k).val());
			console.log($('input:checked').eq(k).val());
		}
		
		var AnswerSheet = {};
		AnswerSheet.testerName = "Stephen Petkus";
		AnswerSheet.test = "7d1a1314129b0bd6";
		AnswerSheet.answers = AnswerSht;
		
		
		
		
		
		console.log(JSON.stringify(AnswerSheet));
		
		// var sub = "[{testerName: Stephen Petkus},{test:7d1a1314129b0bd6},{answers:"+arrayAns+"}]";
		// sub.push('testerName',"Stephen Petkus");
		// sub.push('test',"7d1a1314129b0bd6");
		
		$.ajax({
			type: 'POST',
			url:"http://192.168.60.183:9001/answersheets" ,
			data: JSON.stringify(AnswerSheet), 
			dataContent:'json',	
			contentType:"application/json",
			 
 			 
		})
		
	})	
	
	


	$('#getbtn').on('click', function (e) {
		e.preventDefault();
		$.ajax({
			type: "GET",
			url:"http://192.168.60.183:9001/tests/7d1a1314129b0bd6",
			dataContent:"json" ,
			success: function (data) {
				
				
				
				//for short answers
		function writeSA(question){
			$('div.col-md-3').append('<div class="form-group">');
			$('div.form-group').append('<label class="title" >'+question.text()+'</label>');
			$('div.form-group').append('<input type="text" class="form-control"/></div>')
		}
				
				//for t/f
		function writeTf(question,num){
			$('div.col-md-3').append('<div class="form-group">');
			$('div.form-group').append('<label class="title">'+question+'</label>');
			$('div.form-group').append('<input type = "radio" id="t"name="'+num+'t" value="'+num+'t"/><span class="chtext">T</span><input type = "radio" id="'+num+'f" name="'+num+'f" value="f"/><span class="chtext">F</span></div>')
		}		
				
				//for mult. choice
		function writeMC(question,answers,num){
			$('div.col-md-3').append('<div class="form-group">');
			$('div.form-group').append('<label class="title" >'+question+'</label>');
			$('div.form-group').append('<input type = "radio" id= a value='+answers[0]+'/>'+answers[0]+'</input>');
			$('div.form-group').append('<input type = "radio" id= b value='+answers[1]+'/>'+answers[1]+'</input>');
			$('div.form-group').append('<input type = "radio" id= c value='+answers[2]+'/>'+answers[2]+'</input>');
			$('div.form-group').append('<input type = "radio" id=d value='+answers[3]+'/>'+answers[3]+'</input>');
			$('div.form-group').append('</div>');
			}
		
		
		//populate
		
		for (var j = 0; j < 15; j++) {
			console.log(j+" times through");
			// console.log(data.questions[j].question);
			var $temp = data.questions[j].questionType;
			// console.log($temp);
			
			if ($temp == 'tf') {
				writeTf(data.questions[j].question,j);
			}
			if ($temp == 'mc'){
				var ans = [];
				for (var key in data.questions[j].answers) {
					
					console.log(data.questions[j].answers[key]);
					ans.push(data.questions[j].answers[key].toString());
					console.log(ans);
							
				}
				writeMC(data.questions[j].question, ans,j);
			}
		}
				

				},

		
		})	

	})	


 });