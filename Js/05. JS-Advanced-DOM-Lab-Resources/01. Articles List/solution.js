function createArticle() {
	var articles = document.getElementById("articles")
		let input = document.getElementById("createTitle")
	let textArea = document.getElementById("createContent")

	if (articles === null || input === null || textArea === null) {
		throw new Error("Sorry")

	}

	if (input.value !== "" && textArea.value !== "") {
		var article = document.createElement("article")
		let h3 = document.createElement("h3");
		let p = document.createElement("p");

		h3.innerHTML = input.value;
		p.innerText = textArea.value;

		article.appendChild(h3)
		article.appendChild(p)

		articles.appendChild(article)
	}

}


document.addEventListener("DOMContentLoaded", x=>
		document
		.getElementById("myButton")
		.addEventListener("click",createArticle)
);
