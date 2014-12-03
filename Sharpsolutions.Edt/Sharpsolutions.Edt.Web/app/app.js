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

app.config(function (localStorageServiceProvider) {
    localStorageServiceProvider
      .setPrefix('EdtApp');
});

app.config(function (insightsProvider) {
    insightsProvider.start('787e82db-6768-4cb3-9b74-1fc2c37d450d', 'sharpsolutions.edt.web');
});




app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

var Settings = {
    ServiceBase: 'https://edt-api.azurewebsites.net/'
};

