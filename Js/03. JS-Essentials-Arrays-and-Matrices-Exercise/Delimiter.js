function delimeter(input) {
    let delimeter = input[input.length - 1];
    input.pop();
    console.log(input.join(delimeter));
}

delimeter(['One',

    'Two',

    'Three',

    'Four',

    'Five',

    '-'] )