import { Component } from '@angular/core';
import { Allapi } from '../../API/allapi';

@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
  constructor(private allApi:Allapi){}
UserName:any;
Password:any;

userLogin()
{
var data={UserName:this.UserName,
  Password:this.Password
}
 this.allApi.httpPost("Login/login", data).subscribe((data:any) =>
 {
  if(data.return)
    { window.location.replace('dashboard');
    }
  })
}
}
