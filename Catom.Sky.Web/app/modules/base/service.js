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
    function (angular) {
        return angular.module('service.baseapp', ['uiRouter'])
            .factory('BaseAppService', [
                '$rootScope',
                function ($rootScope) {
                    var baseService = {};

                    return baseService;
                }
            ]);
    });