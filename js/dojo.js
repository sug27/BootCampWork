$(function(){
	
	
	$('#btn').on('click'),function(e){
		e.preventDefault();
		var testForm = [];
		testForm.push('{first-name','Stephen');
		testForm.push('last-name','Petkus');
		testForm.push('city','chicago');
		testForm.push('state','here');
		testForm.push('zip','no');
		testForm.push('street','Shaddup}');
		
		
	
	
	$.ajax({
		type:'POST',
		url:"http://192.168.60.112:8080/RestSampleService/services/customers",
		data:JSON.stringify(testForm),
		dataContent:'json',
		contentType:"application/json",
		
	})
   
 }
});