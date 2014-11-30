'use strict';
var homeController = function ($scope, $location, authService) {
    $scope.logOut = function () {
        authService.logOut();
        $location.path('/');
    }
    console.log(authService.authentication);

    $scope.authentication = authService.authentication;
}