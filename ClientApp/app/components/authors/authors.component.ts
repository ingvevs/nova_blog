import { Http } from '@angular/http';
import { Component, Inject } from '@angular/core';
@Component({
    selector: 'authors',
    templateUrl: 'authors.component.html'
})
export class AuthorsComponent {
    public authors: any;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(`${baseUrl}api/author`)
            .subscribe(result => {
                this.authors = result.json();
            });
    }
}