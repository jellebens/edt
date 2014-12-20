'use strict';
angular.module('EdtApp').controller('tradeRouteListController', ['$scope', '$state', '$stateParams', '$filter', 'ngTableParams', 'tradeRouteService', function ($scope, $state, $stateParams, $filter, ngTableParams, tradeRouteService) {
    var _Detail = function(name) {
        tradeRouteService.Destinations(name).then(function(details) {
            $scope.origin = details[0].origin;
        });

    }

    _Detail($stateParams.starport);

}]);