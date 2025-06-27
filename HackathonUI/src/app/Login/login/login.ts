import { Component, inject } from '@angular/core';
import { Allapi } from '../../API/allapi';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
  constructor(private allApi:Allapi){}
  router = inject(Router);
UserName:any;
Password:any;

Login()
{
var data={UserName:this.UserName,
  Password:this.Password
}
 this.allApi.httpPost("Login/login", data).subscribe((data:any) =>
 {
  if(data.return)
    { 
      this.router.navigateByUrl('dashboard')
    }
  })
}
}
