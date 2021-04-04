'use strict';
app.controller('usersController', function ($scope, $filter, $modal, UserService) {


  //  $scope.exploreNearby = "USA";
    $scope.exploreQuery = "";
    $scope.filterValue = "";

    $scope.Users = [];
    $scope.filteredCountries = [];
    $scope.filteredCountriesCount = 0;

    ////paging
    $scope.totalRecordsCount = 0;
    $scope.pageSize = 10;
    $scope.currentPage = 1;

    Init();

    function Init() {
        getUsers();
       // createWatche();

    }




    function getUsers() {

        UserService.allUsers($scope.currentPage - 1, $scope.pageSize).then(function (results) {
            debugger

            $scope.Users = results.data;

            var paginationHeader = angular.fromJson(results.headers("x-pagination"));

            $scope.totalRecordsCount = paginationHeader.TotalCount;
            //filterCountries('');

        }, function (error) {
            alert(error.message);
        })
    }


    //function filterCountries(filterInput) {
    //    $scope.filteredCountries = $filter("CountryNameFilter")($scope.Countries, filterInput);
    //    $scope.filteredCountriesCount = $scope.filteredCountries.length;
    //}

    //function createWatche() {

    //    $scope.$watch("filterValue", function (filterInput) {
    //        filterCountries(filterInput);
    //    });
    //}

    $scope.doSearch = function () {

        $scope.currentPage = 1;


    };

    $scope.pageChanged = function (page) {

        $scope.currentPage = page;


    };

});