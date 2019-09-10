function AddRemove(input){
    input.unshift("test");
    let result = [];
    for (let i = 1; i < input.length; i++) {
      if(input[i] === "add"){
          result.push(i);
      }

      else{
          result.pop();

      }
    }

      
    if(result.length == 0){
        console.log("Empty")
    } 

    else{
        console.log(result)

    }
}

AddRemove(['add',  

'add', 
'add',  

'add',  

'add'] )