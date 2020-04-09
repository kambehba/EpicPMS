import { Component, OnInit,Input } from '@angular/core';
import {EpicPmsService} from '../Services/EpicPms.service';
import { Tenent } from '../models';
import { Apartment } from '../models';
import { from, Observable } from 'rxjs';

@Component({
  selector: 'app-tenent',
  templateUrl: './tenent.component.html',
  styleUrls: ['./tenent.component.css']
})
export class TenentComponent implements OnInit {

  @Input()
  apartmentNumber : number;

  firstName : string;
  lastName : string;
  startDate : Date;
  endDate : Date;
  rent : Number;

  tenent :Tenent;
  apa:  Observable<Apartment[]>;

  constructor(private epicPmsService:EpicPmsService) {
   
   }

  ngOnInit(): void {
    this.tenent = new Tenent();
    
  }

  Submit(){
    
    this.tenent.firstName = this.firstName;
    this.tenent.lastName = this.lastName;
    this.tenent.apartmentNumber = this.apartmentNumber;
    this.tenent.startDate = this.startDate;
    this.tenent.endDate = this.endDate;
    this.tenent.rent = this.rent;

    this.epicPmsService.AssignTenent(this.tenent);

    this.epicPmsService.tenentStatusUpdate(1);

  }

}
