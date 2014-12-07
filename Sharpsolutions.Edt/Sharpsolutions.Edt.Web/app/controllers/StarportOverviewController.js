'use strict';
angular.module('EdtApp').controller('starPortOverviewController', ['$scope', '$state', 'starportService', function ($scope, $state, starportService) {
   

    $scope.savedSuccessfully = false;
    $scope.message = "";

    $scope.starports = {};

    starportService.Overview().then(function (starports) {
        console.log(starports);
        $scope.starports = starports;
    }, function (err) { $scope.message = err });

}]);