﻿'use strict';
app.controller('myPlacesController', function ($scope, placesDataService) {

    $scope.myPlaces = [];

    //paging
    $scope.totalRecordsCount = 0;
    $scope.pageSize = 10;
    $scope.currentPage = 1;

    init();

    function init() {
        //getUserPlaces();
       getplaces();
    }

    function getUserPlaces() {

        debugger;

        var userInCtx = placesDataService.getUserInContext();

        if (userInCtx) {

            placesDataService.getUserPlaces(userInCtx, $scope.currentPage - 1, $scope.pageSize).then(function (results) {

                $scope.myPlaces = results.data;
                

                var paginationHeader = angular.fromJson(results.headers("x-pagination"));

                $scope.totalRecordsCount = paginationHeader.TotalCount;

            }, function (error) {
                alert(error.message);
            });
        }
    }


    function getplaces() {
        


        placesDataService.getUserPlaces("test", $scope.currentPage - 1, $scope.pageSize).then(function (results) {
            debugger;
            $scope.myPlaces = results.data;

            var paginationHeader = angular.fromJson(results.headers("x-pagination"));

            $scope.totalRecordsCount = paginationHeader.TotalCount;

        }, function (error) {
            alert(error.message);
        })
    }

    $scope.pageChanged = function (page) {

        $scope.currentPage = page;
        getUserPlaces();

    };

});