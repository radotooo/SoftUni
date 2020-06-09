function result(data, criteria) {
let filterBy = criteria.split("-")

let result = data.filter(x => x[filterBy[0]] == filterBy[1])
                  .map((b,i) => `${i}. ${b.first_name} ${b.last_name} - ${b.email}`);

 console.log(result);
 }
 (function() {
 console.log("Tessta maikaaa'")
})()
for (let i = 0; i < 100; i++) {
  
  
}


let data= [{
    "id": "1",
    "first_name": "Ardine",
    "last_name": "Bassam",
    "email": "abassam0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Jost",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  },  
{
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }]
let criteria = 'gender-Female'

let data2 = [{
  "id": "1",
  "first_name": "Kaylee",
  "last_name": "Johnson",
  "email": "k0@cnn.com",
  "gender": "Female"
}, {
  "id": "2",
  "first_name": "Kizzee",
  "last_name": "Johnson",
  "email": "kjost1@forbes.com",
  "gender": "Female"
}, {
  "id": "3",
  "first_name": "Evanne",
  "last_name": "Maldin",
  "email": "emaldin2@hostgator.com",
  "gender": "Male"
}, {
  "id": "4",
  "first_name": "Evanne",
  "last_name": "Johnson",
  "email": "ev2@hostgator.com",
  "gender": "Male"
}];
let criteria2= 'last_name-Johnson';
result(data,criteria);
result(data2,criteria2);



