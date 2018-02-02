import { Http } from '@angular/http';
import { Component, Inject } from '@angular/core';
@Component({
    selector: 'employees',
    templateUrl: 'employees.component.html'
})
export class EmployeesComponent {
    public employees: any;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(`${baseUrl}api/employee`)
            .subscribe(result => {
                this.employees = result.json();
            });
    }
}