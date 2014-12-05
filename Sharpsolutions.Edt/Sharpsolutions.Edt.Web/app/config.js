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
    }).state('account.loggedin', {
        url: "/account/loggedin",
        templateUrl: "app/views/account/loggedin.html",
        controller: "loginController"
    }).state('account.signup', {
        url: "/account/signup",
        templateUrl: "app/views/account/signup.html",
        controller: "signupController"
    }).state('trade', {
        abstract: true,
        url: "/trade",
        templateUrl: "app/views/trade/content.html"
    }).state('trade.solarsystem', {
        url: "/trade/solarsystem",
        templateUrl: "app/views/trade/solarsystem.html",
        controller: "solarSystemCreateController"
    });

}

angular
    .module('EdtApp')
    .config(config)
    .run(function ($rootScope, $state) {
        $rootScope.$state = $state;
    });