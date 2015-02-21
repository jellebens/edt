'use strict';
angular.module("EdtApp").controller("processingController", ['$scope', '$state', '$stateParams', '$interval', function ($scope, $state, $stateParams, $interval) {
    $scope.commandId = $stateParams.commandId;
    $scope.destination = $stateParams.CommandId;
    $scope.destinationArgs = $stateParams.params;

    var stop = $interval(_Poll, 300, 5);

    var _Poll = function () {
        commandService.Query($scope.CommandId).then(function (response) {
            $interval.cancel(stop);

            stop = undefined;

            $state.go($scope.destination, $stateParams);

        }, function (err) {
            console.error(err);
            $interval.cancel(stop);
        });
    }

    

}]);