
/*######################*********************#############################
  
 Created by: Taiseer Joudeh
  http://twitter.com/tjoudeh
  http://bitoftech.net

 ######################*********************##############################*/

var app = angular.module('FoursquareApp', ['ngRoute', 'ngResource', 'ui.bootstrap', 'toaster', 'chieffancypants.loadingBar']);

app.config(function ($routeProvider) {

    $routeProvider.when("/explore", {
        controller: "placesExplorerController",
        templateUrl: "/app/views/placesresults.html"
    });

    $routeProvider.when("/places", {
        controller: "myPlacesController",
        templateUrl: "/app/views/myplaces.html"
    });


    $routeProvider.when("/places", {
        controller: "myPlacesController",
        templateUrl: "/app/views/myplaces.html"
    });

    
    $routeProvider.when("/countries", {
        controller: "countriesController",
        templateUrl: "/app/views/Countries.html"
    });

    $routeProvider.otherwise({ redirectTo: "/explore" });

});