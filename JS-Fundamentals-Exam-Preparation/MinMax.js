/**
 * Created by gyoka on 18.6.2016 г..
 */
function solve(params) {
    'use strict';

    var n = +params[0];
    var k = +params[1];
    var numbers = params[2].split(' ').map(Number);

    var result = [];

    for (var i = 0; i <= numbers.length - k; i += 1) {
        var arr = [];
        for (var j = i; j < i + k; j += 1) {
                arr.push(numbers[j]);
        }

        var current = Math.max.apply(null, arr) + Math.min.apply(null, arr);
        result.push(current);
    }

    var output = result.join(',');

    console.log(output);
}

// solve(['4', '2', '1 3 1 8']);