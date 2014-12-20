'use strict';
angular.module('EdtApp').controller('tradeRouteListController', ['$scope', '$state', '$stateParams', '$filter', 'ngTableParams', 'tradeRouteService', function ($scope, $state, $stateParams, $filter, ngTableParams, tradeRouteService) {
    var _Detail = function(name) {
        tradeRouteService.Destinations(name).then(function (details) {
            if (details.length > 0) {
                $scope.origin = details[0].origin;
            }

            var data = details;
            $scope.tableParams = new ngTableParams({
                page: 1, // show first page
                count: data.length, // count per page
                sorting: {
                    profit: 'desc'
                }
            }, {
                counts: [], // hide page counts control
                total: data.length, // value less than count hide pagination
                getData: function($defer, params) {
                    var orderedData = params.sorting() ?
                        $filter('orderBy')(data, $scope.tableParams.orderBy()) :
                        data;

                    $defer.resolve(orderedData.slice((params.page() - 1) * params.count(), params.page() * params.count()));
                }
            });
        });

    }

    _Detail($stateParams.starport);

}]);