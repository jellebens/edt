'use strict';
angular.module('EdtApp').controller('starPortUpdateController', ['$scope', '$stateParams', 'ngTableParams', 'starportService', function ($scope, $stateParams, ngTableParams, starportService) {
    $scope.savedSuccessfully = false;
    $scope.message = "";

    $scope.starport = {};

    

    var _Detail = function (name) {
        starportService.Detail(name).then(function (detail) {
            $scope.starport = detail;
           
        });
    }

    _Detail($stateParams.starport);

}]);