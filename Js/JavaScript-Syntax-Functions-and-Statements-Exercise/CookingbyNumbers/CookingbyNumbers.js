function operation(args) {
    let num = parseInt(args[0]);

    for (let index = 1; index < args.length; index++) {
        
        switch (args[index]) {
            case 'chop': num /= 2; break;
            case 'dice': num = Math.sqrt(num);break;
            case 'spice': num += 1; break;
            case 'bake': num *= 3;break;
            case 'fillet': num-= num * 0.2 ;break;
        }
        console.log(num)
    }
 

}


operation(['9','dice','spice','chop','bake','fillet'])

    



