import { Component } from '@angular/core';

@Component({
    selector: 'app-root',
    templateUrl: './welcome.component.html',
//    styleUrls: ['./welcome.component.css']

})
export class WelcomeComponent {
    data: string = "Hello";
    message: string;

    constructor() {

        this.message = "Welcome in Angular8";
    }
}
