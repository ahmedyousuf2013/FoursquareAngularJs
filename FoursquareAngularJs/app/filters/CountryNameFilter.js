'use strict';
app.filter("CountryNameFilter", function () {
    return function (Countries, filterValue) {
        if (!filterValue) return Countries;

        var matches = [];
        filterValue = filterValue.toLowerCase();
        for (var i = 0; i < Countries.length; i++) {
            var country = Countries[i];

            if (country.Name.toLowerCase().indexOf(filterValue) > -1 ||
                country.Description.toLowerCase().indexOf(filterValue) > -1) {
                matches.push(country);
            }
        }
        return matches;
    };
});