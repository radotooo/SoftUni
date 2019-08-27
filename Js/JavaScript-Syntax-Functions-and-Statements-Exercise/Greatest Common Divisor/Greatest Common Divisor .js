function calculate(a,b){

    let result = 0;
    for (let index = 0; index <= b; index++) {
      if(a % index === 0 && b % index === 0 )
      {
          if(index>result)
          {
              result=index;
          }
      }
        
    }
    return result
}
console.log(calculate(15,5))