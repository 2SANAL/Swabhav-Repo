import { Component } from '@angular/core';
import { stringify } from 'querystring';

@Component({
    selector: 'app-root',
    templateUrl: './student.component.html',
})

export class StudentComponent {

    private studentlist: Array<IStudent>;
    student1: IStudent[];

    constructor() {
        this.studentlist = [{
            rollno: 12,
            name: "akash",
            cgpi: 5.5
        }, {
            rollno: 13,
            name: "Dhruv",
            cgpi: 5.9
        }
        ]
    }

    student: IStudent = {
        rollno: 12,
        name: 'Akash',
        cgpi: 8.5

    }

    loadStudentDetails(event: Event) {
        console.log(event);
        this.student1 = this.studentlist
    }

}

interface IStudent {
    rollno: number,
    name: string,
    cgpi: number
}
