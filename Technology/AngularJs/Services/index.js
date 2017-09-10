/// <reference path="angular.1.4.8.min.js" />

var ngapp = angular.module("MyApp", []);

ngapp.controller("MyController", function ($scope, DummyData) {
    $scope.Title = "Services in Angular";

    var TempArray = DummyData.PersonDetails();

    $scope.DetailArray = TempArray;
});

ngapp.service("DummyData", function () {
    this.PersonDetails = function () {
        var TempArray = [{ Name: "John", LastName: "Doe", Address: "California" },
                    { Name: "Jennifer", LastName: "Dolle", Address: "London" },
                    { Name: "Theon", LastName: "GreyJoy", Address: "IronBorn" },
                    { Name: "Cersei", LastName: "Lannistor", Address: "7 Kingdom" }];
        return TempArray;
    }
});