'use strict';
angular.module('EdtApp').controller('loginController', ['$scope', '$state', 'authService', function ($scope, $state, authService) {

    $scope.loginData = {
        userName: "",
        password: ""
    };

    $scope.authentication = authService.authentication;

    if (authService.authentication.isAuth) {
        $state.go("account.loggedin");
    }

    $scope.message = "";

    $scope.login = function () {

        authService.login($scope.loginData).then(function (response) {
            $state.go("home");
        },
         function (err) {
             $scope.message = err.error_description;
         });
    };


    $scope.logout = function () {
        authService.logOut();
        $state.go("home");
    }


}]);