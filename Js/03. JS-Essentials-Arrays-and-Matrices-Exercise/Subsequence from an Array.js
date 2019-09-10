function extract(input){
    input = input.map(Number);
    let result=[];

    result.push(input[0])
    
    for (let i = 1; i < input.length; i++) {
        
        if(result[result.length-1] < input[i]){

            result.push(input[i]);
        }
    }
  result.forEach(x=>console.log(x));
}

extract([1,2,3])
        

        
