app.controller("assignment",function($scope,$http){
    $http.get("https://localhost:44347/api/assignment/All")
    .then(function(resp){
        $scope.assignment = resp.data;
    },function(err){
        console.log(err);
    });
});