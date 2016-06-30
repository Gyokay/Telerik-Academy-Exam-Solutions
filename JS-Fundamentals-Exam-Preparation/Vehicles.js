function solve(args) {
    var n = +args[0];
    var counter = 0;

    for (var i = 0; i <= n / 10; i += 1) {
        for (var j = 0; j <= n / 4; j += 1) {
            for (var k = 0; k <= n / 3; k += 1) {
                if ((i * 10 + j * 4 + k * 3) === n) {
                    counter += 1;
                }
            }
        }
    }

    console.log(counter);
}