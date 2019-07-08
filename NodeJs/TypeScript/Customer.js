"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Custmoer = /** @class */ (function () {
    function Custmoer(id, firstName, lastName) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
    }
    Object.defineProperty(Custmoer.prototype, "Id", {
        get: function () {
            return this.id;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Custmoer.prototype, "FullName", {
        get: function () {
            return this.firstName + " " + this.lastName;
        },
        enumerable: true,
        configurable: true
    });
    return Custmoer;
}());
exports.Custmoer = Custmoer;
var Addres = /** @class */ (function () {
    function Addres(addres) {
        this.addres = addres;
    }
    Object.defineProperty(Addres.prototype, "Address", {
        get: function () {
            return this.addres;
        },
        enumerable: true,
        configurable: true
    });
    return Addres;
}());
exports.Addres = Addres;
