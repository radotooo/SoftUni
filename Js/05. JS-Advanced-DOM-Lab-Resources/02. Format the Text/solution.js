function solve() {
let input =  document.getElementById("input")
if(input === null){
  throw new Error("No such element!")
}
let result = input.innerHTML.split(".").filter(x=>x!== "")
let output = document.getElementById("output")
for (let i = 0; i < result.length; i+=3) {

  let text ="";
  for (let j = 0; j < 3; j++) {
    if( i+j< result.length){

      text = result[i+j]+".";
    }
  }
  let paragraph = document.createElement("p")
  paragraph.innerHTML = text
  output.appendChild(paragraph)
  
}

}