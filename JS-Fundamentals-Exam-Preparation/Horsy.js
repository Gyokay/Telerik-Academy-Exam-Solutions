function solve(params) {
    'use strict';

    var rc = params[0].split(' ').map(Number);
    var moves = [];

    for (var i = 1; i <= rc[0]; i += 1) {
        moves.push([]);
        var currentRow = params[i].split().map(Number);
        moves[i - 1] = currentRow;
    }

    console.log(moves);

}
