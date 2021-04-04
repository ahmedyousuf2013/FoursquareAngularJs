
'use strict';
app.controller('userContextController', function ($scope, $modalInstance, placesDataService, venue) {

    $scope.venue = venue;
    $scope.user = {  };

    $scope.close = function () {
        $modalInstance.dismiss('cancel');
    };

    $scope.saveUser = function () {
        debugger

        placesDataService.setUserInContext($scope.user);

        $modalInstance.dismiss('cancel');




        placesDataService.savePlace(venue).then(
            function () {
                $scope.close();
            },
            function () {
                alert("Error occured");
            });



    };

});