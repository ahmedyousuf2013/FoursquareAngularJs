'use strict';
app.factory('CountriesDataService', function ($http, toaster) {


    var serviceBase = 'https://localhost:44372/api/Countries/get';
    var countriesDataFactory = {};
    var userInContext = null;

  
    var _getCountries  = function (pageIndex, pageSize) {

        return $http.get(serviceBase, { params: { page: pageIndex, pageSize: pageSize } }).then(function (results) {
          
            return results;
        });
    };
   
    countriesDataFactory.getCountries = _getCountries;
    

    return countriesDataFactory
});