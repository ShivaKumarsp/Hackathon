import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Login } from './Login/login/login';
import { Home } from './AllViews/home/home';
import { Dashboard } from './AllViews/dashboard/dashboard';
import { Createstaff } from './AllViews/createstaff/createstaff';
import { Scheduleshift } from './AllViews/scheduleshift/scheduleshift';


const routes: Routes = [
  {path:"", redirectTo:"login", pathMatch:"full"},
  {path:"login", component:Login},

  {path:'', component:Home,
  children:[
  {path:"dashboard", component:Dashboard},
  {path:"createstaff", component:Createstaff},
   {path:"scheduleshift", component:Scheduleshift}    
  ]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
