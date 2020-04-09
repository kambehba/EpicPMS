import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import {EpicPmsService} from './Services/EpicPms.service'
import { Apartment } from './models';
import { TenentComponent } from './tenent/tenent.component';
import { TenentListComponent } from './tenent-list/tenent-list.component';



@NgModule({
  declarations: [
    AppComponent,
    TenentComponent,
    TenentListComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,FormsModule
  ],
  providers: [EpicPmsService,Apartment],
  bootstrap: [AppComponent]
})
export class AppModule { }
