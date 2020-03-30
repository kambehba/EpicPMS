import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import {EpicPmsService} from './Services/EpicPms.service'
import { Apartment } from './models';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
  ],
  providers: [EpicPmsService,Apartment],
  bootstrap: [AppComponent]
})
export class AppModule { }
