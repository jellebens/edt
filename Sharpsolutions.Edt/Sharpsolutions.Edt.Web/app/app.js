var app = angular.module('EdtApp', [  'ui.router'
                                    , 'ui.bootstrap'
                                    , 'LocalStorageModule'
                                    , 'angular-loading-bar'
                                    , 'ngSanitize'
                                    , 'angular-appinsights'
                                   ]);

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);

app.config(['localStorageServiceProvider',function (localStorageServiceProvider) {
    localStorageServiceProvider
      .setPrefix('EdtApp');
}]);


app.config(['insightsProvider', function (insightsProvider) {
    insightsProvider.start('06700dac-7cc0-43ff-839d-f24112e37242');
}]);


app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

var Settings = {
    ServiceBase: 'https://edt-api.azurewebsites.net/'
};

