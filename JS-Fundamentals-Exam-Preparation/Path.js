function solve(args) {
    "use strict";

    var rc = args[0].split(' ').map(Number),
        directionsMatrix = [],
        matrixRow = rc[0],
        matrixCol = rc[1],
        used = [];

    for (var i = 1; i <= matrixRow; i += 1) {
        directionsMatrix.push(args[i].split(' '));
    }

    //return console.log(directionsMatrix);

    var currentRow = 0,
    currentCol = 0,
    sum = calcCellValue(0, 0),
    output = '',

    isRunning = true;
    while (isRunning) {
        directionHandler(directionsMatrix[currentRow][currentCol]);
    }

    function calcCellValue(row, col) {

        if (matrixRow - 1 < row || row < 0 || matrixCol - 1 < col || col < 0) {
            isRunning = false;
            return 'out';
        }

        return Math.pow(2, row) + col;
    }

    //console.log(calcCellValue(4, 4));

    function directionHandler(direction) {
        switch (direction) {
            case 'rep': sumDigits(direction); isRunning = false; break;
            case 'dr': markAsVisited(); sumDigits(calcCellValue(currentRow += 1, currentCol += 1)); break;
            case 'ur': markAsVisited(); sumDigits(calcCellValue(currentRow -= 1, currentCol += 1)); break;
            case 'ul': markAsVisited(); sumDigits(calcCellValue(currentRow -= 1, currentCol -= 1)); break;
            case 'dl': markAsVisited(); sumDigits(calcCellValue(currentRow += 1, currentCol -= 1)); break;
        }
    }

    function sumDigits(value) {
        if (value === 'out') {
            return console.log(output += 'successed with ' + sum);
        } else if (value === 'rep') {
            return console.log(output += 'failed at ' + '(' + currentRow +
            ', ' + currentCol + ')');
        }

        sum += value;
    }

    function markAsVisited() {
        directionsMatrix[currentRow][currentCol] = 'rep';
    }


}