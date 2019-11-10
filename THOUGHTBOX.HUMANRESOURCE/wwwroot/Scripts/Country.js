//$(document).ready(function ()
//{


//});




var myContrlApp = angular.module('app', []);

myContrlApp.filter('offset', function () {
    return function (input, start) {
        start = parseInt(start, 10);
        return input.slice(start);
    };
});


myContrlApp.controller('customersController', function ($scope, $http) {

    $http.get("/Country/GetTableValues")
        .success(function (response) {
           // alert(response);
            //alert(JSON.stringify(response));

            $scope.names = JSON.parse(response);
        })
        .error(function (data, Bank) {

            alert("Error");
        });


    $scope.itemsPerPage = 50;
    $scope.currentPage = 0;
    $scope.names = [];



    $scope.range = function () {
        var rangeSize = 2;
        var ret = [];
        var start;

        start = $scope.currentPage;
        if (start > $scope.pageCount() - rangeSize) {
            start = $scope.pageCount() - rangeSize + 1;
        }

        for (var i = start; i < start + rangeSize; i++) {
            ret.push(i);
        }
        return ret;
    };




    $scope.prevPage = function () {
        if ($scope.currentPage > 0) {
            $scope.currentPage--;
        }
    };

    $scope.prevPageDisabled = function () {
        return $scope.currentPage === 0 ? "disabled" : "";
    };

    $scope.pageCount = function () {
        return Math.ceil($scope.names.length / $scope.itemsPerPage) - 1;
    };

    $scope.nextPage = function () {
        if ($scope.currentPage < $scope.pageCount()) {

            $scope.currentPage++;

        }
    };

    $scope.nextPageDisabled = function () {
        return $scope.currentPage === $scope.pageCount() ? "disabled" : "";
    };

    $scope.setPage = function (n) {
        $scope.currentPage = n;
    };



});




function datainsert() {

    var button_text = $('#btnsubupdate').text();

    if (button_text == "Submit") {

        var _data = {
            Currencyid: $('#frm-currency').val(),
            Name_Eng: $('#frm-Countryname').val(),
            Code: $('#frm-CountryCode').val()
        };

        $.ajax({
            type: "POST",
            url: "Country/Insertform",
            data: _data,
            cache: false,
            datatype: "json",
            success: function (r) {

                window.location.reload(true);
            },

            error: function (response) {


            }


        });

    }

    else {

        var _data = {
            Id: $('#hidenid').val(),
            Currencyid: $('#frm-currency').val(),
            Name_Eng: $('#frm-Countryname').val(),
            Name_Arb: '',
            Code: $('#frm-CountryCode').val()
        };

        $.ajax({
            type: "POST",
            url: "Country/Insertform",
            data: _data,
            cache: false,
            datatype: "json",
            success: function (r) {

                window.location.reload(true);
            },
            error: function (response) {


            }

        });

    }

    }




