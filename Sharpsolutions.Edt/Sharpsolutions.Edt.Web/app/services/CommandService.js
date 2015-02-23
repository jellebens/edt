'use strict';
angular.module('EdtApp').factory('commandService', ['$http', '$q', function ($http, $q) {
    var serviceBase = Settings.ServiceBase;

    var commandServiceFactory = {};

    var _Query = function (commandId) {
        console.log(commandId);
        var deferred = $q.defer();
        
        $http.get(serviceBase + 'command/checkresult', { params: { commandId: commandId } }).success(function (response) {
            deferred.resolve(response);
        }).error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    };

    commandServiceFactory.Query = _Query;

    return commandServiceFactory;
}]);