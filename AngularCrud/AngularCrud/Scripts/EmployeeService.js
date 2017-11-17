app.service("EmployeeService", function ($http) {
    //get All Eployee  
    this.getAllEmployees = function () {
        $http.get("Employee/GetAll");
    };
    // Adding Record  
    this.AddNewEmployee = function (tbl_Employee) {
        return $http({
            method: "post",
            url: "Employee/Create",
            data: JSON.stringify(tbl_Employee),
            dataType: "json"
        });
    }
    // Updating record  
    this.UpdateEmployee = function (tbl_Employee) {
        return $http({
            method: "post",
            url: "Employee/Update",
            data: JSON.stringify(tbl_Employee),
            dataType: "json"
        });
    }
    // Deleting records  
    this.deleteEmployee = function (Id) {
        return $http.post('Employee/Delete/' + Id)
    }
});