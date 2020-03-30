import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Apartment} from '../models';

@Injectable()

export class EpicPmsService {
    constructor(private http: HttpClient) {

    
     }

     getConfig() {
        return this.http.get<Apartment[]>("https://localhost:44372/api/onebeds");
      }


  }