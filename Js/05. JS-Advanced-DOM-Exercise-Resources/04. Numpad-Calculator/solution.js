function solve() {

    //let buttons = document.querySelectorAll("button");
    let buttons = document.querySelectorAll(".keys")[0];
console.log(buttons);
    let output = document.querySelector("#expressionOutput");
    let firstNum=0;
    let secondNum=0;

  
    //buttons = Object.values(buttons).filter(x=>x.value !== "=" && x.value !=="Clear")

    let plus = document.querySelector("button[value='+']");
    plus.addEventListener("click",function (e){

        firstNum= output.innerHTML
        console.log(e.target.value);
    })
    //console.log(plus);
   // console.log(output);
    console.log(buttons);
    buttons.addEventListener("click",function(e){
        //output.innerHTML += element.value
        if ( a.indexOf( 1 ) !== -1 ) { } //* check if array has value
        console.log(e.target.value);
        //let a = Number(output.innerHTML)
        
        
    })
    // buttons.forEach(element => {
    //     element.addEventListener("click",function(){
    //         output.innerHTML += element.value
    //         let a = Number(output.innerHTML)
            
            
    //     })})
   
    // for (const iterator of buttons) {
    //     console.log(iterator.value);
    // }
    
}