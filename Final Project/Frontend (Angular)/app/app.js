var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/assignment", {
        templateUrl : "views/pages/assignment.html",
        controller: 'assignment'
    })
    .when("/trees", {
        templateUrl : "views/pages/trees.html",
          controller: 'trees'
    })
    .when("/UserDashboard", {
        templateUrl : "views/pages/UserDashboard.html",
        controller: 'UserDashboard'
    })
    .when("/login", {
        templateUrl : "views/pages/login.html",
        controller: 'login'
    })
    .when("/users", {
        templateUrl : "views/pages/users.html",
        controller: 'users',
    })
    .when("/logout", {
        templateUrl : "views/pages/login.html",
        controller: 'logout',
    })
    .when("/addTree", {
        templateUrl : "views/pages/addTree.html",
        controller: 'addTree',
    })
    .when("/submiTask", {
        templateUrl : "views/pages/submiTask.html",
        controller: 'submiTask',
    })
    .when("/records", {
        templateUrl : "views/pages/records.html",
        controller: 'records',
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);

app.config(function($httpProvider){
    $httpProvider.interceptors.push('interCeptor');
})
