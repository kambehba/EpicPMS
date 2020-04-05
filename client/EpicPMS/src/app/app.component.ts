import { Component, Injectable } from '@angular/core';
import {EpicPmsService} from './Services/EpicPms.service';
import { from, Observable } from 'rxjs';
import { Apartment } from './models';

@Injectable()

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})


export class AppComponent {

  apartments: Observable<Apartment[]>;
  showTable : boolean;
  showAssignTenent : boolean;
  ap : number;

  constructor(private epicPmsService:EpicPmsService,private a:Apartment){
    this.showTable = true;
    this.showAssignTenent = false;

  }
  title = 'EpicPMS';

  getOneBeds()
  {
    this.apartments =  this.epicPmsService.getOneBeds();
   
  }

  getTwoBeds()
  {
    this.apartments =  this.epicPmsService.getTwoBeds();
   
  }

  getThreeBeds()
  {
    this.apartments =  this.epicPmsService.getThreeBeds();
   
  }

  Assign(apartmentNumber : number)
  {
    alert(apartmentNumber);
    this.ap = apartmentNumber;
    this.showTable = false;
    this.showAssignTenent = true;
  }

  getthis() : number{
    return this.ap;

  }



}

