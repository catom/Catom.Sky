//////////////////////////////////////////////////////
//
// desc : base 服务模块。
// auth : catom
// date : 2015/10/09
//
//////////////////////////////////////////////////////

'use strict'

define([
    'angular',
    'uiRouter',
],
    function () {
        return angular.module('service.baseapp', ['ui.router'])
            .factory('ServiceBaseApp', [
                '$rootScope',
                function ($rootScope) {
                    var baseService = {};

                    return baseService;
                }
            ]);
    });