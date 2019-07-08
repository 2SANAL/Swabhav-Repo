interface IEmployee {
    Id: Number,
    salary: Number,
    designation: string,
    name: string
}
function printDetails(employee: IEmployee[]) {
    for (let e of employee) {
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
},{Id:102,
    salary:50000,
    designation:'Manager',
    name:'Dhruv'

}])