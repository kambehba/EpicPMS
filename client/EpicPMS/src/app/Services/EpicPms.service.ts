import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {Apartment, Tenent} from '../models';
import { Observable } from 'rxjs';

@Injectable()

export class EpicPmsService {
 

    constructor(private http: HttpClient) {

    
     }

     getOneBeds() {
        return this.http.get<Apartment[]>("https://localhost:44372/api/apartments/onebeds");
      }

      getTwoBeds() {
        return this.http.get<Apartment[]>("https://localhost:44372/api/apartments/twobeds");
      }

      getThreeBeds() {
        return this.http.get<Apartment[]>("https://localhost:44372/api/apartments/threebeds");
      }

      
      AssignTenent(tenent:Tenent) {
        return this.http.post<Tenent>("https://localhost:44372/api/Tenents/AssignTenent",tenent).subscribe
        ({
          next:data=>alert('Mr.' + tenent.firstName + ' is Assigned to apartment number:' + tenent.apartmentNumber),
          error:error=>console.error('An Error Has Occured',error)
        });

      }

      
  }