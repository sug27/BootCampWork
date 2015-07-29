var el = document.getElementById('box');
el.addEventListener('load',addButton(),false);
	
function addButton(){
	el.innerHTML='<button type="button" id = "btn">add</button>';
}



var nodes;  

function getNumber(){
	nodes = document.getElementsByClassName('test');
	for(var i=0;i < nodes.length;i++){
		
		if(nodes){
		    if(nodes[i] > ){
			    break;
		    }
			else{
				return
			}
		return i+1;
	}
	
}

var e2 = document.getElementById('btn');





e2.addEventListener('click',addItem,false);



function addItem(){
	var newLi = document.createElement('li');
	newLi.classList.add('test');
	var text = document.createTextNode(getNumber());
	newLi.appendChild(text);
	document.getElementById('todo').appendChild(newLi);
}

var e3= document.getElementById('todo');
e3.addEventListener('click',remItem,false);

function remItem(e){
	var target,parent;
	target=e.target;
	parent = target.parentNode;
	parent.removeChild(target);

	
}