import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Header } from './Layout/header/header';
import { Footer } from './Layout/footer/footer';
import { Login } from './Login/login/login';
import { FormsModule } from '@angular/forms';
import { Dashboard } from './AllViews/dashboard/dashboard';
import { Home } from './AllViews/home/home';
import { HttpClientModule } from '@angular/common/http';
import { Createstaff } from './AllViews/createstaff/createstaff';



@NgModule({
  declarations: [
    App,
    Header,
    Footer,
    Login,
    Dashboard,
    Home,
    Createstaff
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners()
  ],
  bootstrap: [App]
})
export class AppModule { }
