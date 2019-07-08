export class Custmoer {
    constructor(private id: Number,
        private firstName: String,
        private lastName: String) {

    }
    get Id() {
        return this.id;
    }
    get FullName() {
        return this.firstName + " " + this.lastName;
    }
}
export class Addres {
    constructor(private addres: String) {

    }
    get Address() {
        return this.addres;
    }
}