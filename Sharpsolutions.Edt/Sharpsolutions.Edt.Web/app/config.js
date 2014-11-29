//Configure routing
var config = function ($locationProvider) {
    $locationProvider.hashPrefix('!').html5Mode(true);


    
};


//Better like this otherwise might break during minification
config.$inject = ['$locationProvider']
app.config(config);

app.config(function (localStorageServiceProvider) {
    localStorageServiceProvider
      .setPrefix('EdtApp');
});

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});
