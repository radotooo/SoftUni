
function resolve(input) {
    let result = input.split(" / ");
    let data = [];
    let items = [];

    for (let i = 0; i < input.length; i++) {
        let heroData = input[i].split(" / ")
        if (heroData.length > 2) {
            items = heroData[2].split(", ")
        }
        data.push({
            name: heroData[0],
            level: Number(heroData[1]),
            items: items
        });
    }

    return JSON.stringify(data);
}

function name(matrix) {
    return matrix.reduce((a,b,i)=> { 
        a[0]+=b[i]
        a[1]+=b[b.length-i-1] 

        return a},[]) //a+b[b.length-i-1], )
}



var result = resolve(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
])

let g = [
    ['2', '3', '4', '7', '0'],
    ['4', '0', '5', '3', '4'],
    ['2', '3', '5', '4', '2'],
    ['9', '8', '7', '5', '4']
];

function solve(a, b) {
    return (b) => {
        return a + b
    }
}
let add5 = solve(5);


console.log(add5(20))
console.log(add5(30))





// a["goo"]=5;
// a[7]=20
// a.forEach(x=>console.log(typeof(x)))
// console.log(a)

// let g = a.filter((_,i) => i%2===0);
// let b = a.reduce((a,c)=>  { return a+' '+c},"1")
// console.log(g);
