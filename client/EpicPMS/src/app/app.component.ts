import { Component, Injectable } from '@angular/core';
import {EpicPmsService} from './Services/EpicPms.service';
import { from, Observable } from 'rxjs';
import { Apartment } from './models';
import { Tenent } from './models';

@Injectable()

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})


export class AppComponent {
  title = 'EpicPMS';

  apartments: Observable<Apartment[]>;
  tenents: Observable<Tenent[]>;
  showApartmentsList : boolean;
  showAssignTenent : boolean;
  showTenentList : boolean;

  ap : number;

  constructor(private epicPmsService:EpicPmsService,private a:Apartment){
    this.TurnOffAllViews();

  }

  ngOnInit(){
    this.epicPmsService.tenentStatus.subscribe(status=>this.UpdateView(status))
  }
  

  getOneBeds()
  {
    
    this.apartments =  this.epicPmsService.getOneBeds();
    this.UpdateView(1);
   
  }

  getTwoBeds()
  {
    this.apartments =  this.epicPmsService.getTwoBeds();
    this.UpdateView(1);
  }

  getThreeBeds()
  {
    this.apartments =  this.epicPmsService.getThreeBeds();
    this.UpdateView(1);
   
  }

  Assign(apartmentNumber : number)
  {
    this.ap = apartmentNumber;
    this.UpdateView(2);
   
  }

  getthis() : number{
    return this.ap;

  }

  UpdateView(viewIndex:number){
    switch(viewIndex)
    {
      case 1:
        this.showApartmentsList = true;
        this.showAssignTenent = false;
        this.showTenentList = false;
        break;

        case 2:
          this.showApartmentsList = false;
          this.showAssignTenent = true;
          this.showTenentList = false;
        break;
        
        case 3:
          this.showApartmentsList = false;
          this.showAssignTenent = false;
          this.showTenentList = true;
        break;

    }

  }

  TurnOffAllViews(){
    this.showApartmentsList = false;
    this.showAssignTenent = false;
    this.showTenentList = false;

  }

  getTenents(){
    this.tenents =  this.epicPmsService.getTenents();
    this.UpdateView(3);
  }



}

