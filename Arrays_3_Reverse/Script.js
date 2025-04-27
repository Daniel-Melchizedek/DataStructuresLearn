let arr = [1, 4, 3, 2, 6, 5];
reverse_Left_Right(arr);
console.log(arr);

function reverse_Left_Right(arr)
{
    let left = 0;
    let right = arr.length - 1;
    while (left < right)
    {
        swap(arr, left, right);
        right--;
        left++;
    }
}

function reverse_BuiltIn(arr)
{
    arr.reverse();
}
function swap(arr,left,right)
{
    const temp = arr[left];
    arr[left] = arr[right];
    arr[right] = temp;
}