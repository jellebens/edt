'use strict';
angular.module('EdtApp').controller('navBarController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {
    $scope.logout = function () {
        authService.logOut();
        $location.path('/');
    }
    
    $scope.authentication = authService.authentication;
}]);