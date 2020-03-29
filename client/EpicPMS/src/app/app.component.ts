import { Component, Injectable } from '@angular/core';
import {EpicPmsService} from './Services/EpicPms.service';
import { from } from 'rxjs';

@Injectable()

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})


export class AppComponent {

  constructor(private epicPmsService:EpicPmsService){

  }
  title = 'EpicPMS';

  dothis()
  {
    
    this.epicPmsService.getConfig().subscribe(data=>alert(data[0]['rent']));
  }



}
