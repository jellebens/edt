'use strict';
angular.module('EdtApp').controller('starPortController', ['$scope', '$state', 'starportService', function ($scope, $state, starportService) {
    $scope.economies = [
        { Name: 'Extraction' },
        { Name: 'Refinery' },
        { Name: 'Agriculture' },
        { Name: 'Industrial' },
        { Name: 'High Tech' }
    ];

    $scope.savedSuccessfully = false;
    $scope.message = "";

    $scope.starport = {
        name: "",
        system: "",
        economy: ""
    };

    var _Create = function () {
        starportService.Create($scope.starport).then(function (response) {
            $scope.savedSuccessfully = true;
            $state.go("trade.starport.update");
        }, function (err) {
            $scope.savedSuccessfully = false;
            $scope.message = "Failed to register user due to:";
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