﻿'use strict';
angular.module('EdtApp').controller('starPortCreateController', ['$scope', '$state','$timeout', 'starportService', function ($scope, $state,$timeout, starportService) {
    $scope.economies = [
        { Name: 'Extraction' },
        { Name: 'Refinery' },
        { Name: 'Agriculture' },
        { Name: 'Industrial' },
        { Name: 'High Tech' }
    ];

    $scope.savedSuccessfully = false;
    $scope.saving = false;
    $scope.message = "";

    $scope.starport = {
        name: "",
        system: "",
        economy: ""
    };

    var _Create = function () {
        $scope.saving = true;
        starportService.Create($scope.starport).then(function(response) {
            $scope.savedSuccessfully = true;
            
            $state.go("processing", { commandId: response, destination: "trade.starport.update", params: { starport: $scope.starport.name } });
        }, function (err) {
            $scope.savedSuccessfully = false;
            $scope.message = "Failed to register starport due to:";
            $scope.message += "<ul>";

            for (var key in err.modelState) {
                for (var i = 0; i < err.modelState[key].length; i++) {
                    var msg = err.modelState[key][i];
                    
                    if (msg != "") {
                        $scope.message += "<li>" + msg + "</li>";
                    }
                }
            }
            $scope.message += "</ul>";
        });
    };

    $scope.Create = _Create;
    

}]);