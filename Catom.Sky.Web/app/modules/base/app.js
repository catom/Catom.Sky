//////////////////////////////////////////////////////
//
// desc : 整合、配置、挂载入口模板。
// auth : catom
// date : 2015/10/08
//
//////////////////////////////////////////////////////

define(
    [
    'angular',
    'uiRouter',
    'base/controller'
    // 挂载子模板于此
    ],

     function (angular) {
         return angular.module('BaseApp', ['angular','uiRouter','$stateProvider'],function ($stateProvider) {

         });
     }
)






