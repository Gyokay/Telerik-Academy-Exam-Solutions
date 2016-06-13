function Solve(params) {
    var N = parseInt(params[0]);
    var answer = -1999999;
    
    // Your code here...
    var subArr = params.slice(1);
    var arr = [];

    for (var i = 0; i < subArr.length; i++) {
        arr[i] = parseInt(subArr[i]);
    }

    for (var i = 0; i < arr.length - 1; i++) {
        var current = arr[i];

        for (var j = i + 1; j < arr.length; j++)
        {
            current += arr[j];
            answer = Math.max(answer, current);
        }
    }

    console.log(answer);

    // return answer;
}

// the input
Solve(['9', '-9', '-8', '-8', '-7', '-6', '-5', '-1', '-7', '-6']);

// 9
// -9
// -8
// -8
// -7
// -6
// -5
// -1
// -7
// -6

