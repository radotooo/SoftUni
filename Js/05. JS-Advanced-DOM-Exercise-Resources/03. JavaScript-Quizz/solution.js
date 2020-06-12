const changeSectionView = {
  0:function (sections){ 
    sections[0].style.display = "none"
      sections[1].style.display = "block"
  } ,
  1:function (sections){ 
    sections[1].style.display = "none"
      sections[2].style.display = "block"},
  2:function (sections){ 
            sections[2].style.display = "none"},
           
}

function increaseNum(num){
 return num += 1
}

const answers = {
  "onclick": function (num) { return increaseNum(num) },
  "JSON.stringify()": function (num) { return increaseNum(num) },
  "A programming API for HTML and XML documents": function (num) { return increaseNum(num) }

};

function solve() {
  let quiz = document.getElementById("quizzie");
  let sections = quiz.getElementsByTagName("section")
  let result = document.getElementById("results")


  let paragraphs = quiz.querySelectorAll("p");
  let rightAnswersCount = 0;
  let sectionNum = 0;

  for (const paragraph of paragraphs) {
    paragraph.addEventListener("click", function () {

      changeSectionView[sectionNum](sections,result);

      if (answers[paragraph.innerHTML] !== undefined) {
        rightAnswersCount = answers[paragraph.innerHTML](rightAnswersCount)
      }
      
      if (sectionNum === 2) {
        result.style.display = "block"

        if (rightAnswersCount >= 3) {
          result.getElementsByTagName("h1")[0].innerHTML = "You are recognized as top JavaScript fan!";

        }
        else {
          result.getElementsByTagName("h1")[0].innerHTML = `You have ${rightAnswersCount} right answers`;

        }
      } 
      sectionNum++;

    })

  }

} 
