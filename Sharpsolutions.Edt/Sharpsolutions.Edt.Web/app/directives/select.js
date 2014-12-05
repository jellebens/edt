'use strict';
angular.module('EdtApp').directive('select', function ($interpolate) {
    return {
        restrict: 'E',
        require: 'ngModel',
        link: function (scope, elem, attrs, ctrl) {
            scope.defaultOptionText = attrs.defaultOption || 'Please select...';
            var defaultOptionTemplate = '<option value="" disabled selected style="display: none;">{{defaultOptionText}}</option>';
            elem.prepend($interpolate(defaultOptionTemplate)(scope));
        }
    };
});