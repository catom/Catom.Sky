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
    'modules/base/service'
],
    function () {
        return angular.module("controller.baseapp", ['ui.router','service.baseapp'])
            .controller("ControllerBaseApp", [
                "$scope", "$rootScope","ServiceBaseApp",
                function ($scope, $rootScope) {
                    $scope.arr = ['梅西','C罗','内马尔','大圣'];
                    $scope.desc = 'Hello! This is the base template!';

                }
            ]);
    }
);








