function solve() {

let  parentDiv = document.getElementsByClassName("link-1")

for (let elementIndex = 0; elementIndex < parentDiv.length; elementIndex++) {
parentDiv[elementIndex].addEventListener("click",function () { return increaseNumOnClick (parentDiv,elementIndex)})
}
function increaseNumOnClick(parentDiv,elementIndex){
  let paragraph =  parentDiv[elementIndex].querySelector("p");
  let pValue = paragraph.innerHTML.match(/\d+/)[0];
    pValue++;
  paragraph.innerHTML = `visited ${pValue} times`;
  };
};