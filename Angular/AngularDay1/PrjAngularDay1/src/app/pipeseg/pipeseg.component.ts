import { Component, OnInit } from '@angular/core';
import { Department } from '../Model/department.model';

@Component({
  selector: 'app-pipeseg',
  templateUrl: './pipeseg.component.html',
  styleUrls: ['./pipeseg.component.css']
})
export class PipesegComponent implements OnInit {

  title:string="welcome to learn Pipes";
  public amount:number;
  public todaydate:Date;
  public stext:any;
  constructor() { }


  ngOnInit() {
    this.todaydate=new Date();
    this.amount=100;
  }

  dept:Department[]=[
    {did:101,dname:"UX",location:"Chennai"},
    {did:102,dname:"Finance",location:"Chennai"},
    {did:103,dname:"HR",location:"Mumbai"},
    {did:104,dname:"AI",location:"Mumbai"},
  ];


}
