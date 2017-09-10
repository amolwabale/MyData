/// <reference path="angular.1.4.8.min.js" />


var ngApp = angular.module("MyRouteApp", ["ngRoute"]);

ngApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "Templates/Home.html",
            controller: "HomeCntrl"
        })
        .when("/Home", {
            templateUrl: "Templates/Home.html",
            controller: "HomeCntrl"
        })
        .when("/Contact", {
            templateUrl: "Templates/Contact.html",
            controller: "ContactCntrl"
        })
        .when("/About", {
            templateUrl: "Templates/About.html",
            controller: "AboutCntrl"
        })
    .otherwise({
        templateUrl: "Templates/About.html",
        controller: "AboutCntrl"
    })
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });

});


ngApp.controller("HomeCntrl", function ($scope) {
    $scope.Message = "This Home Page";
});

ngApp.controller("ContactCntrl", function ($scope) {
    $scope.Message = "This Contact Page";
});

ngApp.controller("AboutCntrl", function ($scope) {
    $scope.Message = "This About Page";
});