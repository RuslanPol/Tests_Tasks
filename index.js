// Первое задание
console.log("Первое задание-----------------------");

function countPC(number) {
    let result = "";
    if (number === 1 || (number % 10 === 1 && number > 20)) {
        result = `${number} компьютер`;
    } else if ((1 < number && number < 5) || ((number % 10 > 1 && number % 10 < 5) && number > 20)) {
        result = `${number} компьютера`;
    } else {
        result = `${number} компьютеров`;
    }
    return result;
}

let count = countPC(10);
console.log(count);

// Второе задание
console.log("Второе задание-----------------------");

function createArray(array) {
    let result = [];
    let num = minNumber(array);
    while (num >= 1) {
        for (let i = 0; i < array.length; i++) {
            if (array[i] % num === 0 && i === array.length - 1) {
                result.push(num);
            }
        }
        num--;
    }
    return result;
}

function minNumber(nums) {
    let min = nums[0];
    for (let i = 1; i < nums.length; i++) {
        if (nums[i] < min) {
            min = nums[i];
        }
    }
    return min;
}

function showArray(array) {
    array.forEach(i => console.log(i));
}

let numbers = [8, 12, 4, 16];
let arr = createArray(numbers);
showArray(arr);

// Третье задание
console.log("Третье задание-----------------------");

function createList(a, b) {
    let result = [];
    let tempList = [];
    if (a < b) {
        for (let i = a; i <= b; i++) {
            tempList.push(i);
        }
    } else {
        for (let i = b; i <= a; i++) {
            tempList.push(i);
        }
    }

    tempList.forEach(t => {
        for (let i = 2; i < t; i++) {
            if (t % i === 0) {
                break;
            }
            if (i === t - 1) {
                result.push(t);
                break;
            }
        }
    });

    return result;
}

function showList(list) {
    list.forEach(v => console.log(v));
}

let list = createList(10, 30);
showList(list);

// Четвертое задание
console.log("Четвертое задание-----------------------");




function multiplicationTable(a) {
    let row = "   ";
    for (let i = 1; i <= a; i++) {
        row += `${i}  `;
    }
    console.log(row);

    for (let i = 1; i <= a; i++) {
        let line = `${i}`;
        for (let j = 1; j <= a; j++) {
            const mult = i * j;
            if (mult < 10) {
                line += `  ${mult}`;
            } else {
                line += ` ${mult}`;
            }
        }
        console.log(line);
    }
}
multiplicationTable(8);