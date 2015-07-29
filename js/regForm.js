




var test=document.getElementById('fname');



test.addEventListener('blur',checkValid,false);

function checkValid(e){
	
	if(e.target.value == ""){
       e.target.classList.add('err');
	}
	var strUser = e.target.options[e.target.selectedIndex].value;
	if (strUser == '-1') {
		e.target.classList.add('err');
	}
	 
};


var test1 = document.getElementById('MI');
test1.addEventListener('blur',checkValid,false);

var test2 = document.getElementById('lname');
test2.addEventListener('blur',checkValid,false);

var test3 = document.getElementById('month');
test3.addEventListener('blur',checkValid,false);

var test4 = document.getElementById('day');
test4.addEventListener('blur',checkValid,false);

var test5 = document.getElementById('year');
test5.addEventListener('blur',checkValid,false);

var test6 = document.getElementById('school');
test6.addEventListener('blur',checkValid,false);

var test7 = document.getElementById('major');
test7.addEventListener('blur',checkValid,false);

var send = document.getElementById('btn');
send.addEventListener('click',print,false);

