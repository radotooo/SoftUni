function print(input){
    let step = parseInt(input.pop());

    for (let i = 0; i < input.length; i += step) {
        console.log(input[i]);
        
    }

}

print(['5',  

'20',  

'31',  

'4',  

'20',  

'2'] )