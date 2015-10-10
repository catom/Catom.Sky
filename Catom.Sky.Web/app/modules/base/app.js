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
    'modules/base/controller'
    // 挂载子模板于此

    ],

     function (angular) {
         // 此处用 uiRouter 会报错，原因是：uiRouter 是引入文件的路径，而 ui.router 才是源码里的模块名称。
         return angular.module('BaseApp', ['ui.router', 'controller.baseapp'])
             .config([
                 "$stateProvider",
                 function ($stateProvider) {
                     $stateProvider.state('base', {
                         url: '',
                         templateUrl: 'app/modules/base/template.html',
                         controller: 'ControllerBaseApp'
                     })
                 }
             ])
     });





