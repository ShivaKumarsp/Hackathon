import { Component } from '@angular/core';
import { Allapi } from '../../API/allapi';

@Component({
  selector: 'app-dashboard',
  standalone: false,
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css'
})
export class Dashboard {
constructor(private allApi: Allapi){}
dashboardList:any;

  ngOnInit():void{
this.getdata();
  }
    getdata() {
    this.allApi.httpGet("Staff/getDashboardData").subscribe((data: any) => {
      this.dashboardList = data.dashboardList;
    }
    )
  }
}
