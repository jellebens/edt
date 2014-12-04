'use strict';
angular.module('EdtApp').controller('homeController', ['$scope', '$state', 'authService',function ($scope, $state, authService) {
    $scope.authentication = authService.authentication;
}]);