import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PrjAngularDay1';
  //variables
  username:string="Kala";
  age:number=34;
  hobbies:string[]; //array -string
  Istrue:boolean;
  tupleval:[string,number,boolean]
  dynamicvalue:any;

  constructor()
  {
    this.hobbies=["Playing","singing"];
    this.Istrue=false;
    this.tupleval=["sai",23,true];
    this.dynamicvalue="hi";
  }
}

