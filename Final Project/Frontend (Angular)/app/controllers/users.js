app.controller("users",function($scope,$http){
    $http.get("https://localhost:44347/api/users")
    .then(function(resp){
        $scope.users = resp.data;
    },function(err){
        console.log(err);
    });
});
