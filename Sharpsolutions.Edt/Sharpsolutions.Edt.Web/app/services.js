authInterceptorService.$inject = ['$q', '$location', 'localStorageService'];
angular.module('EdtApp').factory('authInterceptorService', authInterceptorService);

authService.$inject = ['$http', '$q', 'localStorageService']
angular.module('EdtApp').factory('authService', authService);