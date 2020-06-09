const assignResult = {
    binary: function (result, number) { result.value = convertDecimalToBinary(number) },
    hexadecimal: function (result, number) { result.value = convertDecimalToHexaDecimal(number) }
}
function createOption(name, value) {
    let option = document.createElement("option");
    option.innerHTML = name;
    option.value = value;
    return option;
}

function calculateResult(selectMenu) {
    let number = document.getElementById("input").value
    let result = document.getElementById("result");

    let selectedOption = selectMenu.options[selectMenu.selectedIndex].value;

    if (selectedOption !== "") {

        assignResult[selectedOption](result, number)
    }

}

function convertDecimalToBinary(number) {
    var binary = "";
    var temp = number;

    while (temp > 0) {
        if (temp % 2 == 0) {
            binary = "0" + binary;
        }
        else {
            binary = "1" + binary;
        }

        temp = Math.floor(temp / 2);
    }

    return binary;
}
function convertDecimalToHexaDecimal(number) {
    let intNum = parseInt(number);
    return intNum.toString(16).toLocaleUpperCase();
}

function solve() {

    let selectMenu = document.getElementById("selectMenuTo")

    selectMenu.appendChild(createOption("Binary", "binary"))
    selectMenu.appendChild(createOption("Hexadecimal", "hexadecimal"))
    let button = document.getElementsByTagName("button")[0];

    button.addEventListener("click", () => calculateResult(selectMenu));
}