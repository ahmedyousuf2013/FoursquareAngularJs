'use strict';
app.factory('UserService', function ($http, toaster) {


    var serviceBase = 'https://localhost:44372/api/';
    var UserDataFactory = {};
    var userInContext = null;

    //var _getUserInCtx = function () {

    //    return userInContext;
    //};

    //var _setUserInCtx = function (userInCtx) {

    //    debugger
    //    userInContext = userInCtx;
    //    $http.post(serviceBase + 'users/create', JSON.stringify(userInCtx)).then(function (response) {

    //        console.log(response.data);


    //    })




    //};

    //var _savePlace = function (venue) {
    //    //process venue to take needed properties

    //    var miniVenue = {
    //        userName: userInContext,
    //        venueID: venue.id,
    //        venueName: venue.name,
    //        address: venue.location.address,
    //        category: venue.categories[0].shortName,
    //        rating: venue.rating
    //    };

    //    return $http.post(serviceBase, miniVenue).then(

    //        function (results) {
    //            toaster.pop('success', "Bookmarked Successfully", "Place saved to your bookmark!");
    //        },
    //        function (results) {
    //            if (results.status == 304) {
    //                toaster.pop('note', "Already Bookmarked", "Already bookmarked for user: " + miniVenue.userName);
    //            }
    //            else {
    //                toaster.pop('error', "Faield to Bookmark", "Something went wrong while saving :-(");
    //            }


    //            return results;
    //        });
    //};

    //var _getUserPlaces = function (userName, pageIndex, pageSize) {

    //    return $http.get(serviceBase + 'places/get', { params: { username: userName, page: pageIndex, pageSize: pageSize } }).then(function (results) {

    //        return results;
    //    });
    //};

    var _allUsers = function (pageIndex, pageSize) {

        return $http.get(serviceBase+"users/Get", { params: { page: pageIndex, pageSize: pageSize } } ).then(function (results) {
            return results;
        });
    };


    //// UserDataFactory .getUserInContext = _getUserInCtx;
    //UserDataFactory .setUserInContext = _setUserInCtx;
    UserDataFactory.allUsers = _allUsers;
    //placesDataFactory.userExists = _userExists;

    //UserDataFactory.savePlace = _savePlace;

    return UserDataFactory
});