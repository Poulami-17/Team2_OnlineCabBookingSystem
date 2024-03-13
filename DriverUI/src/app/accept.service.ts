import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AcceptService {

  constructor(private httpClient:HttpClient) { }

  getAllBookingRequest():Observable<any>{
    return this.httpClient.get<any>('http://localhost:5173/api/DriverRide');
  }

  // acceptBookingRequest():Observable<any>{
  //   return this.httpClient.post<any>('http://localhost:5173/api/AcceptRide');
  // }
}