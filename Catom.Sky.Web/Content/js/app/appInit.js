//////////////////////////////////////////////////////
//
// desc : IoC 配置脚本。配置所有调用模块路径，以及初始化base模板。
// auth : catom
// date : 2015/10/07
//
//////////////////////////////////////////////////////

// 配置模块
requirejs.config({
    // 按相对路径引入所需模块文件
    paths: {
        'app': 'modules/base/app',
        'jquery': '../jquery/jquery.min',
        'angular': '../angular/angular.min',
        'angularMock': '../angular/angular-mocks',
        'angularResource': '../angular/angular-resource.min',
        'uiRouter': '../angular/angular-ui-router.min',
        'underscore': '../underscore/underscore-min',
        'cropper': '../cropper/dist/cropper.min',

    },

    // 非AMD规范的库，需要定义其特征
    shim: {
        'angular': ['jquery'],
        'angularMock': ['angular'],
        'angularResource': ['angular'],
        'uiRouter': ['angular'],
        'underscore': {
            'exports': '_'
        },
        'cropper':['jquery']

    }

});

// 初始化 base module
define([], function () { })

