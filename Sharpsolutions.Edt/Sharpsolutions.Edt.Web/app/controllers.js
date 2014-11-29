navBarController.$inject = 


homeController.$inject = ['$scope', '$location', 'authService'];
angular.module('EdtApp').controller('homeController', homeController);

loginController.$inject = ['$scope', '$location', 'authService']
angular.module('EdtApp').controller('loginController', loginController);

signupController.$inject = ['$scope', '$location', '$timeout', 'authService'];
angular.module('EdtApp').controller('signupController', signupController);