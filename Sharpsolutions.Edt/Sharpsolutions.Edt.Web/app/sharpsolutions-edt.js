var app = angular.module('EdtApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar']);

//Configure routing
var config = function ($routeProvider, $locationProvider) {
    $locationProvider.hashPrefix('!').html5Mode(true);

    $routeProvider.when("/", {
        templateUrl: 'app/views/home.html',
        controller: 'homeController'
    });

    $routeProvider.when("/login", {
        controller: "loginController",
        templateUrl: "app/views/account/login.html"
    });

    $routeProvider.when("/signup", {
        controller: "signupController",
        templateUrl: "app/views/account/signup.html"
    });
};


//Better like this otherwise might break during minification
config.$inject = ['$routeProvider', '$locationProvider']
app.config(config);

app.config(function (localStorageServiceProvider) {
    localStorageServiceProvider
      .setPrefix('EdtApp');
});

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

navBarController.$inject = ['$scope', '$location', 'authService'];
app.controller('navBarController', navBarController);

homeController.$inject = ['$scope', '$location', 'authService'];
app.controller('homeController', homeController);

loginController.$inject = ['$scope', '$location', 'authService']
app.controller('loginController', loginController);

signupController.$inject = ['$scope', '$location', '$timeout', 'authService'];
app.controller('signupController', signupController);

authInterceptorService.$inject = ['$q', '$location', 'localStorageService'];
app.factory('authInterceptorService',  authInterceptorService);

authService.$inject= ['$http', '$q', 'localStorageService']
app.factory('authService', authService);


app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);