function solve(input) {
    'use strict';

    input = input[0].split(' ').map(Number);
    var entityNames = new Array(input.length);

    function findPeeks() {
        entityNames[0] = 'p';
        entityNames[entityNames.length - 1] = 'p';

        for (var i = 2; i < input.length - 1; i += 1) {
            if (input[i] > input[i - 1] && input[i] > input[i + 1]) {
                entityNames[i] = 'p';
            }
        }
    }

    function findRocks() {
        for (var i = 0; i < input.length - 1; i += 1) {
            if (input[i] < input[i - 1] && input[i] > input[i + 1] || input[i] > input[i - 1] && input[i] < input[i + 1]) {
                entityNames[i] = 'r';
            }
        }
    }

    function findValleys() {
        for (var i = 0; i < input.length; i += 1) {
            if (entityNames[i] !== 'r' && entityNames[i] !== 'p') {
                entityNames[i] = 'v';
            }
        }
    }

    function findLargestNumberOfRocks() {
        findPeeks();
        findRocks();
        findValleys();

        var maxCounter = 0;
        var countOfBlues = 0;

        for (var i = 1; i < entityNames.length; i += 1) {
            if (entityNames[i] === 'r') {
                countOfBlues += 1;
            }

            if (entityNames[i] === 'p') {
                countOfBlues += 2;
                maxCounter = Math.max(maxCounter, countOfBlues);
                countOfBlues = 0;
            }
        }

        console.log(maxCounter);
    }

    findLargestNumberOfRocks();
}