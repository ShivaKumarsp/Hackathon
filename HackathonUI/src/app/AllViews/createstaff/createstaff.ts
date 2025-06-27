import { Component, OnInit } from '@angular/core';
import { Allapi } from '../../API/allapi';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-createstaff',
  standalone: false,
  templateUrl: './createstaff.html',
  styleUrl: './createstaff.css'
})
export class Createstaff implements OnInit{
  constructor(private allApi: Allapi,private fb: FormBuilder) { }
  page: number = 1;
  count: number = 0;
  tableSize: number = 7;
  tableSizes: any = [3, 6, 9, 12];
  search="";
  FirstName: any;
  LastName: any;
  Email: any;
  Mobile: any;
  RoleId: any;
  staffList: any;
  roleList: any;

  staffForm!: FormGroup;
  submitted = false;

   

  ngOnInit(): void {
    this.getdata();
  }
  getdata() {
    this.allApi.httpGet("Staff/getData").subscribe((data: any) => {
      this.staffList = data.staffList;
      this.roleList = data.roleList;  
    }
    ) 
  }

  Save(from:any) {
       if (from.valid) {

    
    var data = {
      FirstName: this.FirstName,
      LastName: this.LastName,
      Email: this.Email,
      Mobile: this.Mobile,
      RoleId: this.RoleId
    }
    this.allApi.httpPost("Staff/saveData1", data).subscribe((data: any) => {
      if (data.response == "Success") {
        alert("Data saved Successfully");
       window.location.reload();
      }
      else {
        alert("Failed To Insert")
      }
    })

  }
}
  edit(i:any)
  {

  }
  delete(i:any)
  {

  }
  cancel() {
    window.location.reload();
  }

    
}
