'use strict';
var navBarController = function ($scope, $location, authService) {
    $scope.logOut = function () {
        authService.logOut();
        $location.path('/');
    }
    
    $scope.authentication = authService.authentication;
}