const numbers = [2, 5, 8, 11, 14];


let newArray = numbers.map(x=>x*2)
console.log(newArray);


let filteredArray = numbers.filter(x=>x%2==0)
console.log(filteredArray);


let sum = numbers.reduce((accumulator,currentValue)=>accumulator+currentValue)
console.log(sum);





