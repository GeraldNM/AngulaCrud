app.controller("EmployeeCntr", function ($scope, EmployeeService) {
    debugger;
    $scope.Action = "Add";
    $scope.dvEmployee = false;
    GetEmployeeList();
    $scope.Employee = [];
    //To Get All Records  
    function GetEmployeeList() {
        EmployeeService.getAllEmployees().success(function (emp,ss) {
            alert("shittttt");
            debugger;
            $scope.Employee = emp;
          
        }).error(function () {
            debugger;
            alert("shittttt2222");
            alert('Error in getting records');
        });
    }
    // To display Add div  
    $scope.AddNewEmployee = function () {
        $scope.Action = "Add";
        $scope.dvEmployee = true;
    }
    // Adding New Employee record  
    $scope.AddEmployee = function (Employee) {

        debugger;
        EmployeeService.AddNewEmployee(Employee).success(function (msg) {
            $scope.Employee.push(msg)
            $scope.dvAddEmployee = false;
        }, function () {
            alert('Error in adding record');
        });
    }
    // Deleting record.  
    $scope.deleteEmployee = function (stu, index) {
        var retval = EmployeeService.deleteEmployee(stu.Id).success(function (msg) {
            $scope.Employee.splice(index, 1);
            // alert('Employee has been deleted successfully.');  
        }).error(function () {
            alert('Oops! something went wrong.');
        });
    }
    // Updateing Records  
    $scope.UpdateEmployee = function (tbl_Employee) {
        var RetValData = EmployeeService.UpdateEmployee(tbl_Employee);
        getData.then(function (tbl_Employee) {
            //Id: $scope.Id;
            FirstName: $scope.FirstName;
            Surname: $scope.Surname;
            IdentityType: $scope.IdentityType;
            IdentityNumber: $scope.IdentityNumber;
            DateOfBirth: $scope.DateOfBirth;
        }, function () {
            alert('Error in getting records');
        });
    }
});
