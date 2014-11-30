function config($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("/");

    $stateProvider.state('home', {
        url: "/",
        templateUrl: "app/views/home.html"
    });

}

angular
    .module('EdtApp')
    .config(config)
    .run(function ($rootScope, $state) {
        $rootScope.$state = $state;
    });