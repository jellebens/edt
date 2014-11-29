var app = angular.module('EdtApp', ['ui.router'
                                    , 'ui.bootstrap'
                                    , 'LocalStorageModule'
                                    , 'angular-loading-bar']);



app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);