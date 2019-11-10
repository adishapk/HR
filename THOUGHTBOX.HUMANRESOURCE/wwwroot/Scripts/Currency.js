$(document).ready(function () {

    

});



var myContrlApp = angular.module('app', []);

myContrlApp.filter('offset', function () {
    return function (input, start) {
        start = parseInt(start, 10);
        return input.slice(start);
    };
});


myContrlApp.controller('customersController', function($scope, $http) {

    $http.get("/Currency/GetTableValues")
        .success(function(response) {
            
            $scope.names = JSON.parse(response);
        })
        .error(function(data, Bank) {

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
            Name: $("#frm-CurrencyName").val(),
            Code: $("#frm-CurrencyCode").val(),
            Decimals: $("#frm-Decimals").val()
        };

        $.ajax({
            type: "POST",
            url: "/Currency/GetCurrency",
            data: _data,
            cache: false,
            //contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {

                window.location.reload(true);
            },
            error: function (reponse) {

              

            }

        });
    }
    else {
        hidenid
        var _data = {
            Name: $("#frm-CurrencyName").val(),
            Code: $("#frm-CurrencyCode").val(),
            Decimals: $("#frm-Decimals").val(),
            Id: $("#hidenid").val()
        };

        $.ajax({
            type: "POST",
            url: "/Currency/UpdateCurrency",
            data: _data,
            cache: false,
            //contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {

                window.location.reload(true);
            },
            error: function (reponse) {

              
            }

        });

    }

}