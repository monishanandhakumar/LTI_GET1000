import { Pipe } from "@angular/core";
import { PipeTransform } from "@angular/core";

@Pipe({
    name:'locationfilterpipe'
})

export class DepartmentFilterPipe implements PipeTransform
{
    transform(dept:any,searchtext:any)
     {
        if(searchtext)
            return dept.filter((x:any)=>x.location.toLowerCase().startsWith(searchtext.toLowerCase()));
         return dept;
    }
}