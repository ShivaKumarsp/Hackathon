import { Component } from '@angular/core';
import { Allapi } from '../../API/allapi';

@Component({
  selector: 'app-staff-attendance-entry',
  standalone: false,
  templateUrl: './staff-attendance-entry.html',
  styleUrl: './staff-attendance-entry.css'
})
export class StaffAttendanceEntry {
constructor(private allApi: Allapi) { }

attandanceList:any;
  page: number = 1;
  count: number = 0;
  tableSize: number = 7;
  tableSizes: any = [3, 6, 9, 12];
  StaffId:any;
  staffList:any;
  ShiftDate:any;
  CheckInTime:any;
  CheckOutTime:any;
  Status:any;
  Description:any;

  save()
  {
    var data={
      StaffId:this.StaffId,
      ShiftDate:this.ShiftDate,
      CheckInTime:this.CheckInTime,
      CheckOutTime:this.CheckOutTime,
      Status:this.Status,
      Description:this.Description
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
}
