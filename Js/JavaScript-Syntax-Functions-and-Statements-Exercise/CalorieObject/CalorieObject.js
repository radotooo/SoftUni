function calorieObject(Array){
    var obj = {};

    for (let i = 0; i < Array.length; i+=2) {
        let param = Array[i+1];
    obj[Array[i]] = +param;
    }
    console.log(obj)
}


