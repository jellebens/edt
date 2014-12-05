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

    starportServiceFactory.Create = _Create;

    return starportServiceFactory;
});


