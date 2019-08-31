function sameNumbers(number){
    number = number.toString();
   let result = 0;
    let areEqual = true;
    let firstNum = number[0];

    for (let i = 0; i < number.length; i++) {
        if(firstNum != number[i]){
           areEqual=false;

        }
        result += +number[i];
        
    }
console.log(areEqual)
console.log(result)

}


