import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Header } from './Layout/header/header';
import { Footer } from './Layout/footer/footer';
import { Login } from './Login/login/login';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Dashboard } from './AllViews/dashboard/dashboard';
import { Home } from './AllViews/home/home';
import { HttpClientModule } from '@angular/common/http';
import { Createstaff } from './AllViews/createstaff/createstaff';
import { RouterModule } from '@angular/router';
import { SearchPipe } from './search-pipe';
import { NgxPaginationModule } from 'ngx-pagination';
import { Scheduleshift } from './AllViews/scheduleshift/scheduleshift';
import { StaffAttendanceEntry } from './AllViews/staff-attendance-entry/staff-attendance-entry';




@NgModule({
  declarations: [
    App,
    Header,
    Footer,
    Login,
    Dashboard,
    Home,
    Createstaff,
    SearchPipe,
    Scheduleshift,
    StaffAttendanceEntry,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    RouterModule,
    NgxPaginationModule,
    ReactiveFormsModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners()
  ],
  bootstrap: [App]
})
export class AppModule { }
