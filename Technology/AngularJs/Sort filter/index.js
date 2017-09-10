/// <reference path="angular.1.4.8.min.js" />

var ngapp = angular.module("MyApp", []);

ngapp.controller("MyController", function ($scope) {
    $scope.Title = "SORT FILTER";

    var TempArray = [{ Name: "John", LastName: "Doe", Gender: "Male", Age: 45, Salary : "45210.265", RegDate: new Date("October 10 1987") },
                    { Name: "Jennifer", LastName: "Dolle", Gender: "Female", Age: 12, Salary: "12000", RegDate: new Date("January 13 2010") },
                    { Name: "Theon", LastName: "GreyJoy", Gender: "Male", Age: 32, Salary: "45628.321", RegDate: new Date("March 20 2011") },
                    { Name: "Cersei", LastName: "Lannistor", Gender: "Female", Age: 15, Salary: "500", RegDate: new Date("April 23 2006") },
                    { Name: "Rohini", LastName: "Devikar", Gender: "Female", Age: 20, Salary: "78000", RegDate: new Date("July 29 2005") },
                    { Name: "Amit", LastName: "Shah", Gender: "Male", Age: 57, Salary: "106000", RegDate: new Date("December 5 1978") },
                    { Name: "Narendra", LastName: "Modi", Gender: "Male", Age: 64, Salary: "1", RegDate: new Date("September 9 2015") }];

    $scope.DetailArray = TempArray;
    $scope.SortColumnName = "Name";
    $scope.SortOrder = "true";
});