///<reference path="../../../node_modules/angular2/typings/browser.d.ts" /> 
import {Component} from 'angular2/core';

@Component({
    selector: 'angular2',
    template: `<p>{{title}}</p>`
})

export class AppComponent {
    title: string;

    constructor() {
        this.title = 'Angular 2';
    }
} 