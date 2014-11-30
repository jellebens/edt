'use strict';
angular.module('EdtApp').controller('navBarController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {
    $scope.logOut = function () {
        authService.logOut();
        $location.path('/');
    }
    console.log(authService.authentication);
    $scope.authentication = authService.authentication;
}]);