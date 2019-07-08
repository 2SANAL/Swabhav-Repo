"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Customer_1 = require("./Customer");
var customer = new Customer_1.Custmoer(1, "sanal", "Dhamanse");
var address = new Customer_1.Addres("Raigad");
console.log(customer.Id);
console.log(customer.FullName);
console.log(address.Address);
