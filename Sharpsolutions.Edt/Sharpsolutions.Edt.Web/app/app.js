var app = angular.module('EdtApp', [  'ui.router'
                                    , 'ui.bootstrap'
                                    , 'LocalStorageModule'
                                    , 'angular-loading-bar'
                                    , 'ngSanitize'
                                   ]);

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);

app.config(function (localStorageServiceProvider) {
    localStorageServiceProvider
      .setPrefix('EdtApp');
});

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

var Settings = {
    ServiceBase: 'https://edt-api.azurewebsites.net/'
};