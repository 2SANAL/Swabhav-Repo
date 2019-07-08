function printDetails(employee) {
    for (var _i = 0, employee_1 = employee; _i < employee_1.length; _i++) {
        var e = employee_1[_i];
        console.log(e.Id);
        console.log(e.name);
        console.log(e.designation);
        console.log(e.salary);
    }
}
printDetails([{
        Id: 101,
        salary: 25000,
        designation: 'Manager',
        name: 'sanal'
    }, { Id: 102,
        salary: 50000,
        designation: 'Manager',
        name: 'Dhruv'
    }]);
