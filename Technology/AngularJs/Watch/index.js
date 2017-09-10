/// <reference path="angular.1.4.8.min.js" />

var ngapp = angular.module("MyApp", []);

ngapp.controller("MyController", function ($scope) {

    $scope.Title = "$Watch";
    $scope.Name = "Hello World ! . . .";

    $scope.$watch("Name", function (newvalue, oldvalue) {
        alert(oldvalue);
    })

});

