'use strict';
angular.module('EdtApp').controller('signupController', ['$scope', '$state', '$timeout', 'authService', function ($scope, $state, $timeout, authService) {

    $scope.savedSuccessfully = false;
    $scope.message = "";

    $scope.registration = {
        userName: "",
        password: "",
        confirmPassword: ""
    };


    $scope.authentication = authService.authentication;

    if (authService.authentication.isAuth) {
        $state.go("account.loggedin");
    }

    $scope.signup = function () {

        authService.saveRegistration($scope.registration).then(function (response) {

            $scope.savedSuccessfully = true;
            $scope.message = "User has been registered successfully, you will be redicted to login page in 2 seconds.";
            startTimer();

        },
         function (response) {
             $scope.message = "Failed to register user due to:";
             $scope.message += "<ul>";

             for (var key in response.data.modelState) {
                 for (var i = 0; i < response.data.modelState[key].length; i++) {
                     var msg = response.data.modelState[key][i];
                     console.log(msg);

                     if (msg != "") {
                         $scope.message += "<li>" + msg + "</li>";
                     }
                     
                     
                 }
             }
         });
    };

    var startTimer = function () {
        var timer = $timeout(function () {
            $timeout.cancel(timer);
            $state.go('account.login');
        }, 2000);
    }

}]);