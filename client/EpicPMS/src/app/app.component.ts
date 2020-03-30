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

  constructor(private epicPmsService:EpicPmsService,private a:Apartment){
    

  }
  title = 'EpicPMS';

  dothis()
  {
    
   // this.epicPmsService.getConfig().subscribe(data=>alert(data[0]['rent']));

    this.apartments =  this.epicPmsService.getConfig();
    
  }



}

