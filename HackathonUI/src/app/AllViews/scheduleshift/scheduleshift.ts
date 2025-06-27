import { Component } from '@angular/core';
import { Allapi } from '../../API/allapi';

@Component({
  selector: 'app-scheduleshift',
  standalone: false,
  templateUrl: './scheduleshift.html',
  styleUrl: './scheduleshift.css'
})
export class Scheduleshift {
  constructor(private allApi: Allapi) { }
  roleList: any;
  staffList: any;
  RoleId: any;
  StaffId: any;
  ShiftId:any;
  ShiftDate:any;
  scheduleList:any;
  page: number = 1;
  count: number = 0;
  tableSize: number = 7;
  tableSizes: any = [3, 6, 9, 12];
  ngOnInit(): void {
    this.getdata();
  }

  getdata() {
    this.allApi.httpGet("ShiftSchedule/getroleList").subscribe((data: any) => {
      this.roleList = data.roleList;
      this.scheduleList=data.scheduleList;
    })
  }

  gettaff(roleId: any) {
    this.allApi.httpGet("ShiftSchedule/getStaffList/" + roleId).subscribe((data: any) => {
      this.staffList = data.staffList;
    })
  }
save()
{
  var data={
    StaffId:this.StaffId,
    ShiftId:this.ShiftId,
    ShiftDate:this.ShiftDate
  }
    this.allApi.httpPost("ShiftSchedule/saveData",data).subscribe((data: any) => {
      if(data.response=="Success")
      {
        alert("Successfully Assigned")
        window.location.reload();
      }
      else{
        alert("Failed to Assigned");
      }
    })
}
cancel()
{
  
}

}
