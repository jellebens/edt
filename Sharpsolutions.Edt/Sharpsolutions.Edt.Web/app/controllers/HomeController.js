'use strict';
var homeController = function ($scope, $location, authService) {
    $scope.logOut = function () {
        authService.logOut();
        $location.path('/');
    }
    $scope.authentication = authService.authentication;
}