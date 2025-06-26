import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Login } from './Login/login/login';
import { Home } from './AllViews/home/home';
import { Dashboard } from './AllViews/dashboard/dashboard';
import { Createstaff } from './AllViews/createstaff/createstaff';

const routes: Routes = [
  {path:"", redirectTo:"login", pathMatch:"full"},
  {path:"login", component:Login},
  {path:"dashboard", component:Dashboard},
  {path:"createstaff", component:Createstaff}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
