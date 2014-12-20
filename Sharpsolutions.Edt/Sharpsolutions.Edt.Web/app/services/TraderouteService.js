'use strict';
angular.module('EdtApp').factory('tradeRouteService', function ($http, $q) {
    var serviceBase = Settings.ServiceBase;

    var starportServiceFactory = {};

    var _Destinations = function (name) {
        var deferred = $q.defer();
        $http.get(serviceBase + 'trade/destinations', { params: { name: name} }).success(deferred.resolve).error(deferred.reject);
        return deferred.promise;
    }


    starportServiceFactory.Destinations = _Destinations;

    return starportServiceFactory;
});