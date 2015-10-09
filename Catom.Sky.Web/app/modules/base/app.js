//////////////////////////////////////////////////////
//
// desc : 整合、配置、挂载入口模板。
// auth : catom
// date : 2015/10/08
//
//////////////////////////////////////////////////////

'use strict'

define(
    [
    'angular',
    'uiRouter',
    'base/controller'
    // 挂载子模板于此

    ],

     function (angular) {
         return angular.module('BaseApp', ['uiRouter', 'controller.baseapp'])
             .config([
                 "$stateProvider",
                 function ($stateProvider) {
                     $stateProvider.state('base', {
                         url: '',
                         templateUrl: 'base/template.html',
                         controller: 'ControllerBaseApp'
                     })
                 }
             ])
     });





