const arr = [1, 2, 3, 4, 5];
const res = getSecondLargest(arr);
console.log(res);
function getSecondLargest(arr) {
    let largest, secondLargest;
    largest = secondLargest = -1;
    if (arr.length < 2) {
        return -1;
    }

    for (const num of arr) {
        if (num > largest) {
            secondLargest = largest
            largest = num;
        }
        else if (num > secondLargest && num !== largest)
        {
            secondLargest = num;
        }

    }
    return secondLargest;
}