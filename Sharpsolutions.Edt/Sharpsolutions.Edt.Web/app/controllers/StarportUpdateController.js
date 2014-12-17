'use strict';
angular.module('EdtApp').controller('starPortUpdateController', ['$scope', '$stateParams', '$filter', 'ngTableParams', 'starportService', function ($scope, $stateParams, $filter, ngTableParams, starportService) {
    $scope.savedSuccessfully = false;
    $scope.message = "";

    $scope.starport = {};



    var _Detail = function (name) {
        starportService.Detail(name).then(function (details) {
            $scope.starport = details;

            var data = details.goods;
            $scope.tableParams = new ngTableParams({
                page: 1,   // show first page
                count: data.length,  // count per page
                sorting: {
                    category: 'asc',
                    name: 'asc' // initial sorting
            }
            }, {
                counts: [], // hide page counts control
                total: data.length,  // value less than count hide pagination
                groupBy: 'category',
                getData: function ($defer, params) {
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