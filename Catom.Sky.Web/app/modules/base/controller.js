//////////////////////////////////////////////////////
//
// desc : base 控制器模块。
// auth : catom
// date : 2015/10/09
//
//////////////////////////////////////////////////////

'use strict'

define([
    'angular',
    'uiRouter',
    'base/service'
],
    function (angular) {
        return angular.module("controller.baseapp", ['service.baseapp'])
            .controller("ControllerBaseApp", [
                "$scope", "$rootScope", "ServiceBaseApp",
                function ($scope, $rootScope, ServiceBaseApp) {
                    $scope.$user = 'Hello World!';

                }
            ]);
    }
);








