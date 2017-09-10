/// <reference path="angular.1.4.8.min.js" />

var ngapp = angular.module("MyApp", []);

ngapp.controller("MyController", function ($scope) {
    $scope.Title = "ng-repeat";

    var TempArray = [{ Name: "John", LastName: "Doe", Address: "California" },
                    { Name: "Jennifer", LastName: "Dolle", Address: "London" },
                    { Name: "Theon", LastName: "GreyJoy", Address: "IronBorn" },
                    { Name: "Cersei", LastName: "Lannistor", Address: "7 Kingdom" }];

    $scope.DetailArray = TempArray;
});