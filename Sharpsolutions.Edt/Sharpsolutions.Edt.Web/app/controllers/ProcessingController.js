'use strict';
angular.module("EdtApp").controller("processingController", ['$scope', '$state', '$stateParams', '$timeout', 'commandService', function ($scope, $state, $stateParams, $timeout, commandService) {
    $scope.commandId = $stateParams.commandId;
    $scope.destination = $stateParams.destination;
    $scope.destinationArgs = $stateParams.params;

    var count = 1;

    function doPoll() {
        var backoffdelay = 80 * (count + 1) * (count + 1)

        $timeout(function () { $scope.poll(); }, backoffdelay);
    }

    $scope.poll = function () {
        console.log("Polling #" + count);
        commandService.Query($scope.commandId).then(function (response) {
            if (response.isComplete) {
                $scope.showError = response.hasError;

                if (!response.hasError) {
                    $state.go($scope.destination, $scope.destinationArgs);
                }
            } else {
                count++;
                doPoll();
            }
        }, function (err) {
            console.error(err);
            $interval.cancel(stop);
        });
    }

    doPoll();

}]);