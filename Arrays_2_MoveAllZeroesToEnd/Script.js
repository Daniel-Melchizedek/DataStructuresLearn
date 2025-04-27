let arr = [1, 2, 0, 4, 3, 0, 5, 0];
moveZeroesToEnd(arr);
console.log(arr);
moveZeroesToBeginning(arr);
console.log(arr);

function moveZeroesToEnd(arr)
{

    for (let i = 0, count = 0; i < arr.length; i++)
    {
        if (arr[i] !== 0)
        {
            swap(arr, i, count);
            count++;
        }
    }
}

function moveZeroesToBeginning(arr)
{
    for (let i = arr.length - 1, count = arr.length - 1; i >= 0; i--)
    {
        if (arr[i] !== 0)
        {
            swap(arr, i, count);
            count--;
        }
    }
}

function swap(arr, i, count)
{
    const temp = arr[i];
    arr[i] = arr[count];
    arr[count] = temp;
}
