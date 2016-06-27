function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number);
    var result = 0;

    var newArr = new Array(nk[0]);

    function zeroTransform() {
        for (var i = 0; i < s.length; i += 1) {
            if (s[i] === 0) {
                if (i === 0) {
                    newArr[i] = Math.abs(s[s.length - 1] - s[i + 1]);
                } else if (i === s.length - 1) {
                    newArr[i] = Math.abs(s[i - 1] - s[0]);
                } else {
                    newArr[i] = Math.abs(s[i - 1] - s[i + 1]);
                }
            }
        }

        // console.log(newArr);
    }
    
    function evenTransform() {
        for (var i = 0; i < s.length; i += 1) {
            if (s[i] % 2 === 0 && s[i] != 0) {
                if (i === 0) {
                    newArr[i] = Math.max(s[s.length - 1], s[i + 1]);
                } else if (i === s.length - 1) {
                    newArr[i] = Math.max(s[i - 1], s[0]);
                } else {
                    newArr[i] = Math.max(s[i - 1], s[i + 1]);
                }
            }
        }

        // console.log(newArr);
    }
    
    function oneTransform() {
        for (var i = 0; i < s.length; i += 1) {
            if (s[i] === 1) {
                if (i === 0) {
                    newArr[i] = s[s.length - 1] + s[i + 1];
                } else if (i === s.length - 1) {
                    newArr[i] = s[i - 1] + s[0];
                } else {
                    newArr[i] = s[i - 1] + s[i + 1];
                }
            }
        }

        // console.log(newArr);
    }

    function oddTransform() {
        for (var i = 0; i < s.length; i += 1) {
            if (s[i] % 2 != 0 && s[i] != 1) {
                if (i === 0) {
                    newArr[i] = Math.min(s[s.length - 1], s[i + 1]);
                } else if (i === s.length - 1) {
                    newArr[i] = Math.min(s[i - 1], s[0]);
                } else {
                    newArr[i] = Math.min(s[i - 1], s[i + 1]);
                }
            }
        }

        // console.log(newArr);
    }

    for (var j = 0; j < nk[1]; j += 1) {
        zeroTransform();
        evenTransform();
        oneTransform();
        oddTransform();

        s = newArr;
        newArr = new Array(nk[0]);
    }

    for (var k = 0; k < s.length; k += 1) {
        result += s[k];
    }
    

    console.log(result);
}

// solve(['10 3', '1 9 1 9 1 9 1 9 1 9']);


// each 0 - with the absolute difference of its neighboring numbers
// all other even numbers - with the maximum of its neighboring numbers
// each 1 - with the sum of its neighboring numbers
// all other odd numbers - with the minimum of its neighboring numbers
