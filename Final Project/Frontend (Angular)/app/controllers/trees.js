app.controller("trees",function($scope,$http){
    $http.get("https://localhost:44347/api/tree/All")
    .then(function(resp){
        $scope.trees = resp.data;
    },function(err){
        console.log(err);
    });
});