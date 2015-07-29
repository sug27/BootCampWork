$(function(){

var $Forms = $('.form-control');

$Forms.each(function(){
	$(this).on('blur',function(e){
		
	if(e.target.value ==""){
		$(this).addClass('err');
	}
	});	
});

 

$('input[type=btn]').on('click',function(){
	$(this).preventDefault();
	
	var txtArea = $('#txtArea').val();
	$Forms.each(function(){
		txtArea = $Forms[0].val() + " "+ $Forms[2].val() +" "+ $Forms[3].val()+" " + $Forms[4] + " " +$Forms[4].val()+" "+$Forms[5].val();
	});
});

});
