import { Component } from '@angular/core';
import { Allapi } from '../../API/allapi';

@Component({
  selector: 'app-createstaff',
  standalone: false,
  templateUrl: './createstaff.html',
  styleUrl: './createstaff.css'
})
export class Createstaff {
  constructor(private allApi:Allapi){}
FirstName:any;
LastName:any;
Email:any;
Mobile:any;
RoleId:any;
staffList:any;
roleList:any;

 ngOnInit():void
  {
    this.getdata();
  }
  getdata()
  {
  this.allApi.httpGet("Staff/getData").subscribe((data:any) =>
        {
         this.staffList = data.staffList;
         this.roleList = data.roleList;
        }
  )}

Save()
{
  var data={
    FirstName:this.FirstName,
    LastName:this.LastName,
    Email:this.Email,
    Mobile:this.Mobile,
    RoleId:this.RoleId
  }
   this.allApi.httpPost("Staff/saveData", data).subscribe((data:any) =>
 {
  if(data.response=="Success"){
alert("Data saved Successfully");
  }
  else{
    alert("Failed To Insert")
  }    
  })
}
}
