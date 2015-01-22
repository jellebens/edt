angular
    .module('EdtApp')
    .config(['$stateProvider', '$urlRouterProvider', '$locationProvider', function($stateProvider, $urlRouterProvider, $locationProvider) {
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
            url: "/login",
            templateUrl: "app/views/account/login.html",
            controller: "loginController"
        }).state('account.loggedin', {
            url: "/loggedin",
            templateUrl: "app/views/account/loggedin.html",
            controller: "loginController"
        }).state('account.signup', {
            url: "/signup",
            templateUrl: "app/views/account/signup.html",
            controller: "signupController"
        }).state('trade', {
            abstract: true,
            url: "/trade",
            templateUrl: "app/views/trade/content.html"
        }).state('trade.starport', {
            abstract: true,
            url: "/starport",
            templateUrl: "app/views/trade/content.html"
        }).state('trade.starport.list', {
            url: "/overview",
            templateUrl: "app/views/trade/starport/overview.html",
            controller: 'starPortOverviewController'
        }).state('trade.starport.new', {
            url: "/new",
            templateUrl: "app/views/trade/starport/create.html",
            controller: "starPortCreateController"
        }).state('trade.starport.update', {
            url: "/update/{starport}",
            templateUrl: "app/views/trade/starport/update.html",
            controller: "starPortUpdateController"
        }).state('trade.routes', {
            abstract: true,
            url: "/routes",
            templateUrl: "app/views/trade/content.html"
        }).state('trade.routes.destinations', {
            url: "/destinations/{starport}",
            templateUrl: "app/views/trade/routes/destinations.html",
            controller: "tradeRouteListController"
        });

    }]).run(['$rootScope', '$state',function ($rootScope, $state) {
        $rootScope.$state = $state;
    }]);