'use strict';
angular.module('EdtApp').factory('starportService', function ($http, $q) {
    var serviceBase = Settings.ServiceBase;

    var starportServiceFactory = {};

    var _Create = function (starport) {
        var deferred = $q.defer();

        $http.post(serviceBase + 'starport/create', starport).success(function (response) {
            deferred.resolve(response);
        }).error(function (err, status) {

            deferred.reject(err);
        });
        return deferred.promise;
    };

    var _Overview = function () {
        var deferred = $q.defer();
        $http.get(serviceBase + 'starport').success(deferred.resolve).error(deferred.reject);
        
        return deferred.promise;
    };

    var _Detail = function (name) {
        var deferred = $q.defer();
        $http.get(serviceBase + 'starport/detail', {params: {name: name}}).success(deferred.resolve).error(deferred.reject);
        return deferred.promise;
    }

    starportServiceFactory.Create = _Create;
    starportServiceFactory.Overview = _Overview;
    starportServiceFactory.Detail = _Detail;

    return starportServiceFactory;
});


