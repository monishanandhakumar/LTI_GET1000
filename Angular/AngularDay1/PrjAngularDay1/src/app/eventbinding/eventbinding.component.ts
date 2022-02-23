import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventbinding',
  templateUrl: './eventbinding.component.html',
  styleUrls: ['./eventbinding.component.css']
})
export class EventbindingComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
//Ex1
  welcomeMsg()
  {
    alert("Welcome All!!");
  }
  fname:string;
  //Ex2
  displayname(username:HTMLInputElement)
  {
     this.fname=username.value;
  }

}
