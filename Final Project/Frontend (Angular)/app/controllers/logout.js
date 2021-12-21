app.controller("logout",function($http){
    $http.get("https://localhost:44327/api/logout")
    .then(function(rsp){
        localStorage.removeItem("token");
    },function(err){
        console.log(err);
    });

});
