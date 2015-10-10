//////////////////////////////////////////////////////
//
// desc : IoC 配置脚本。配置所有调用模块路径，以及初始化base模板。
// auth : catom
// date : 2015/10/07
// 注：依赖项的引用是问题出现主要地方。模型的名称需要查阅源码。
//       重要的两个库：angular、angular-ui-router。
//
//////////////////////////////////////////////////////

// DI 注入路径
requirejs.config({

    // 若用相对路径，这句必须去掉
    baseUrl: "/app",

    // 按相对路径引入所需模块文件
    paths: {
        'jquery': 'libs/jquery/jquery.min',
        'angular': 'libs/angular/angular.min',
        'angularMock': 'libs/angular/angular-mocks',
        'angularResource': 'libs/angular/angular-resource.min',
        'uiRouter': 'libs/angular/angular-ui-router.min',
        'underscore': 'libs/underscore/underscore-min',
        'cropper': 'libs/cropper/dist/cropper.min',
        'appEntry': 'modules/base/app',// 从根目录下查找的文件

    },

    // 适配：非AMD规范的库，需要定义其特征
    shim: {
        'angular': {
            // 这个文件依赖 jquery 文件, 导出 angular 文件
            deps: ['jquery'],
            exports: 'angular'
        },
        'uiRouter': {
            deps: ['angular'],
            exports: 'uiRouter'
        },
        'angularMock': ['angular'],
        'angularResource': ['angular'],
        'underscore': {
            exports: '_'
        },
        'cropper': ['jquery']
    }

});

// 设置入口模板
define(['appEntry'], function () {
    angular.element(document).ready(function () {
        // 调用入口模板模板
        var baseModule = angular.module('BaseApp');
        baseModule.run([
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

