import { Component, OnInit } from '@angular/core';
import { Department } from '../Model/department.model';

@Component({
  selector: 'app-crud',
  templateUrl: './crud.component.html',
  styleUrls: ['./crud.component.css']
})
export class CrudComponent implements OnInit {

  constructor() { }

  dept:Department[]=[
    {did:101,dname:"UX",location:"Chennai"},
    {did:102,dname:"Finance",location:"Chennai"},
    {did:103,dname:"HR",location:"Mumbai"},
    {did:104,dname:"AI",location:"Mumbai"},
  ];

  getdeptinfo:Department={}; //creating object of type Department

  //Adding to an array
    adddept()
  {
           this.dept.push(this.getdeptinfo);
           this.getdeptinfo={};
  }
  //Deleting from Array by passing did


  deletedept(deptid?:number)
  {
    for(let index=0;index<this.dept.length;index++)
    {
      debugger;
       if(this.dept[index].did!=deptid)
       {
        this.dept.splice(index,1);
         
       } 

    }
    
  }

  //Edit
  indexvalue:number;  
  editdept(i:number)
  {
     this.getdeptinfo.did=this.dept[i].did;
     this.getdeptinfo.dname=this.dept[i].dname;
     this.getdeptinfo.location=this.dept[i].location
     this.indexvalue=i;
  }
  updatedept()
  {
    for(let i=0;i<this.dept.length;i++)
    {
      if(this.dept[i].did=this.getdeptinfo.did)
      {
        this.dept[i]=this.getdeptinfo;
        this.getdeptinfo={};
      }
    }
  }
  ngOnInit() {
  }

}
