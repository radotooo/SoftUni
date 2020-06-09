function solve() {
  let sendButton = document.getElementById("send")

   
   sendButton.addEventListener("click",function () {
      let inputField = document.getElementById("chat_input");
      let chat = document.getElementById("chat_messages");
      let div = document.createElement("div");
      div.classList.add("message","my-message")
      div.innerHTML=inputField.value;
      chat.appendChild(div);
      inputField.value = "";
      console.log(inputField);
   })
}



