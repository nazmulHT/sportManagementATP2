app.controller("loginPlayer",function($scope,ajax,$location){
//$scope.id = $scope.p.Id;
$scope.p = {};

    $scope.submit = function(p){
       //$scope.Name
       //$scope.id = $scope.p.Id;
       var loginError = false;
       if(p.Id == undefined || p.Password == undefined)
       {
         loginError = true;
         $scope.loginError = "Pleae Add id or password";
       }
       if(!loginError){
         ajax.post("https://localhost:44368/api/Login/Player",p,
         function(resp){
           if(resp.data == true)
           {
             $location.path("/playerDashboard");
           }
           else
           {
             $scope.loginError = "User Name or Password is invalid";
           }

         },
         function(err){});
       }


     };
});
