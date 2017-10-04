/// <reference path="angular.1.4.8.min.js" />

var ngapp = angular.module("MyApp", []);

ngapp.controller("MyController", function ($rootScope,$scope) {
    $scope.Title = "$emit $broadcast $on";

    $rootScope.$broadcast('ParentToChild', "Parent To Child" );

    $scope.$on('ChildToParent', function (event, data) {
        $scope.ParentTitle = data;
    });

});

ngapp.controller("MyController2", function ($scope) {
   

    $scope.$emit('ChildToParent', "Child To Parent");

    $scope.$on('ParentToChild', function (event, data) {
        $scope.ChildTitle = data;
    });

});