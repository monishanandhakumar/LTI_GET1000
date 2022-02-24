import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventbinding',
  templateUrl: './eventbinding.component.html',
  styleUrls: ['./eventbinding.component.css']
})
export class EventbindingComponent implements OnInit {

//Eg3
  like:number;
//Eg4
togglestar:boolean;
clsName:string;

  constructor() { 
    this.like=0;
    this.togglestar=false;
    this.clsName='glyphicon glyphicon-star-empty';
  }

 
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
 //Ex3
 thumbsUp(){
   this.like=this.like+1;
 }
//Ex4
changestar()
{
  debugger;
  this.togglestar=!this.togglestar;
  if(this.togglestar)
  {
    this.clsName="glyphicon glyphicon-star";
  }
  else
  {
    this.clsName="glyphicon glyphicon-star-empty";
  }
}


}
