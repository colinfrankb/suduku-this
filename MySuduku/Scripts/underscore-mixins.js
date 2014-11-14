(function (_) {
    _.mixin({
        sum: function (source) {
            var sum = 0;
            source.forEach(function (x) { sum += x; });
            return sum;
        }
    });
})(_);

