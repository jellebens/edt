'use strict';
angular.module('EdtApp').factory('commandService', ['$http', '$q', function ($http, $q) {
    var serviceBase = Settings.ServiceBase;

    var commandServiceFactory = {};

    var _Query = function (commandId) {
        var deferred = $q.defer();

        $http.post(serviceBase + 'command/checkresult', commandId).success(function (response) {
            deferred.resolve(response);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    commandService.Query = _Query;
}]);