/// <reference path="angular.1.4.8.min.js" />

var ngapp = angular.module("MyApp", []);

ngapp.controller("MyController", function ($scope) {
    $scope.Title = "Counting Watchers";


    var TempObject = new Object({ Name: "John", LastName: "Doe", Address: "California" });

    $scope.DetailModel = TempObject;

    var TempArray = [{ Name: "John", LastName: "Doe", Address: "California" },
                    { Name: "Jennifer", LastName: "Dolle", Address: "London" },
                    { Name: "Theon", LastName: "GreyJoy", Address: "IronBorn" },
                    { Name: "Cersei", LastName: "Lannistor", Address: "7 Kingdom" }];

    $scope.DetailArray = TempArray;

    $scope.AddDetail = function () {
        var Detail = $scope.DetailModel;
        $scope.DetailModel = new Object();
        $scope.DetailArray.push(Detail);
        $scope.CalculateWatchers();
    }

    $scope.CalculateWatchers = function () {
        var q = [$scope], watchers = 0, scope;
        while (q.length > 0) {
            scope = q.pop();
            if (scope.$$watchers) {
                watchers += scope.$$watchers.length;
            }
            if (scope.$$childHead) {
                q.push(scope.$$childHead);
            }
            if (scope.$$nextSibling) {
                q.push(scope.$$nextSibling);
            }
        }
        $scope.watchCount = watchers;
    }
    $scope.CalculateWatchers();



});

ngapp.directive('floatBox', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attr) {
            //this is not for validation, this is just a sample for what I want to do.
            //Please don't suggest Angular validations

            scope.$watch(attr.ngModel, function () {
                //changeCSSClass(element);
            });
        },
        template:"hello"
    }
});