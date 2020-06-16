function result() {
    class Person {

        constructor(name, email) {
            this.name = name,
                this.email = email;
        };
        toString() {
            return `${this.constructor.name} (name: ${this.name}, email: ${this.email})`
        }
    }
    Person.prototype.Hello = "hello";
    class Teacher extends Person {
        constructor(name, email, subject) {
            super(name, email);
            this.subject = subject;
        };
        toString() {
            return super.toString().slice(0, -1) + `, subject: ${this.subject})`
        }
    }
    class Student extends Person {
        constructor(name, email, course) {
            super(name, email);
            this.course = course;
        };
        toString() {
            return super.toString().slice(0, -1) + `, course: ${this.course})`
        }
    }
    return {
        Person,
        Teacher,
        Student
    }
}
let classes = result();
let c = new classes.Student("dsadsa", "dasda@dsads.com", "dabeda")

let a = new classes.Person("dsadsa", "dasda@dsads.com")
console.log(a.toString());
console.log(c.toString());
console.log(a.Hello);
