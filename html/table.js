
$(function(){
var $inputs = $("input.form-control");

$inputs.each(function(){
	$(this).on('blur',function(e){
		
	if(e.target.value ==""){
		$(this).addClass('err');
	}
	});	
	
});

var timesClicked = 0;
var total = 0;


$('button').on('click',function(e){
	 e.preventDefault();
	 var a,b,c;
	 
	 a = $inputs.eq(0).val();
	 b = $inputs.eq(1).val();
	 c = $inputs.eq(2).val();
	 
	 timesClicked += 1;
	$('#table tbody').append('<tr class = success><td><button class = "btn btn-default + delete">Delete</button></td><td>'+timesClicked.toString()+'<td>'+a+'</td><td>'+b+'</td><td>'+c+'</td></tr>');
		
	total= total + parseInt(c);
	
	$('#total').val(total);
	
	$inputs.each(function(){
		$(this).val('');
	});
	
	});	
 
 
 $('#table tbody').on('click','.btn',function(e){
	 var temp = e.target.parentNode.parentNode.children.last().val();
	 total = total - parseInt(temp);
	 e.target.parentNode.parentNode.remove();
 });
 
 
 
});