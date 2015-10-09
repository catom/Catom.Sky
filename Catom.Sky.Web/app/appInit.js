//////////////////////////////////////////////////////
//
// desc : IoC 配置脚本。配置所有调用模块路径，以及初始化base模板。
// auth : catom
// date : 2015/10/07
//
//////////////////////////////////////////////////////

// DI 注入路径
requirejs.config({

    // 若用相对路径，这句必须去掉
    baseUrl: "/app/modules/",

    // 按相对路径引入所需模块文件
    paths: {
        'appEntry': 'base/app',// 从根目录下查找的文件
        'jquery': '/Content/js/jquery/jquery.min',
        'angular': '/Content/js/angular/angular.min',
        'angularMock': '/Content/js/angular/angular-mocks',
        'angularResource': '/Content/js/angular/angular-resource.min',
        'uiRouter': '/Content/js/angular/angular-ui-router.min',
        'underscore': '/Content/js/underscore/underscore-min',
        'cropper': '/Content/js/cropper/dist/cropper.min',

    },

    // 适配：非AMD规范的库，需要定义其特征
    shim: {
        'angular': {
            deps: ['jquery'],
            exports: 'angular'
        },
        'angularMock': ['angular'],
        'angularResource': ['angular'],
        'uiRouter': ['angular'],
        'underscore': {
            exports: '_'
        },
        'cropper': ['jquery']

    }

});

// 设置入口模板
define(['appEntry', 'angular'], function (angular) {
    angular.element(document).ready(function () {
        // 调用入口模板模板
        var baseModule = angular.module('BaseApp')
            .run([
                "$rootScope", "$state", "$stateParams",
                function ($rootScope, $state, $stateParams) {
                    $rootScope.$state = $state;
                    $rootScope.$stateParams = $stateParams;
                }
            ]);
        // 注入页面
        angular.bootstrap(document, ['BaseApp']);
    });
})

