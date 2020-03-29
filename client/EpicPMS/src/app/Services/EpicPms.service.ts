import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()

export class EpicPmsService {
    constructor(private http: HttpClient) {

    
     }

     getConfig() {
        return this.http.get("https://localhost:44372/api/onebeds");
      }


  }