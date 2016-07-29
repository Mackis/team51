﻿(function (app) {
    'use strict';

    app.controller('myApplicationsCtrl', myApplicationsCtrl);

    myApplicationsCtrl.$inject = ['$scope', 'apiService', 'notificationService'];

    function myApplicationsCtrl($scope, apiService, notificationService) {
        $scope.pageClass = 'page-student-myApplications';

        $scope.applications = [{
            "name": "Entelect",
            "sponsor": "Entelect",
            "closing": "10/09/2345",
            "Date": "10/09/2345",
            "Status": "Pending"
        },
       {
           "name": "Entelect",
           "sponsor": "Entelect",
           "closing": "10/09/2345",
           "Date": "10/09/2345",
           "Status": "Pending"
       },
       {
           "name": "Entelect",
           "sponsor": "Entelect",
           "closing": "10/09/2345",
           "Date": "10/09/2345",
           "Status": "Pending"

       }];

        $scope.selected = [];

        $scope.query = {
            order: 'name',
            limit: 5,
            page: 1
        };

        function success() {

            //<td md-cell>{{application.name}}</td>
            //      <td md-cell>{{application.sponsor}}</td>
            //      <td md-cell>{{application.closing}}</td>
            //      <td md-cell>{{aplication.date}}</td>
            //      <td md-cell>{{application.status}}</td>
       
        }

        $scope.getApplications = function () {
            notificationService.displayError('Here');
        };


    }

})(angular.module('BursifyApp'));

