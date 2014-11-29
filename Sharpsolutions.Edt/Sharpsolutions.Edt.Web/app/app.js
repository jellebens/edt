var app = angular.module('EdtApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar']);


app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);