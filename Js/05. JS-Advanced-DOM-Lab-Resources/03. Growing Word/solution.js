

function growingWord() {

  let element = document.getElementById("exercise");
  let paragraph = element.querySelector("p");

  if (paragraph.style.fontSize === "") {
    paragraph.style.fontSize = 2 + "px"
    paragraph.style.color = "blue"
  }
  else {
    var color = paragraph.style.color;
    let user = {
      blue: function () {
        paragraph.style.color = "green";
      },
      green: function () {
        paragraph.style.color = "red";
      },
      red: function () {
        paragraph.style.color = "blue";
      }
    }
    user[color]();

    let currentFontSize = paragraph.style.fontSize.match(/\d+/)[0];

    changeColor(paragraph, currentFontSize);
    function changeColor(paragraph, currentFontSize) {
      paragraph.style.fontSize = currentFontSize * 2 + "px";
    }
  }
}
