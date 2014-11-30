function config($stateProvider, $urlRouterProvider, $locationProvider) {
    $locationProvider.html5Mode(true).hashPrefix('!');
    $urlRouterProvider.otherwise("/");

    $stateProvider.state('home', {
        url: "/",
        templateUrl: "app/views/home.html"
    }).state('account', {
        abstract: true,
        url: "/account",
        templateUrl: "app/views/common/content.html",
    }).state('account.login', {
        url: "/account/login",
        templateUrl: "app/views/account/login.html",
        controller: "loginController"
    });

}

angular
    .module('EdtApp')
    .config(config)
    .run(function ($rootScope, $state) {
        $rootScope.$state = $state;
    });