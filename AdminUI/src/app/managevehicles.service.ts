import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ManagevehiclesService {
  // private apiUrl = 'http://localhost:3000/api/vehicles';
 
  // constructor(private http: HttpClient) { }
 
  // addVehicle(vehicleDetails: any): Observable<any> {
  //   return this.http.post<any>(this.apiUrl, vehicleDetails);

  // }


private apiUrl = 'https://cabappapi20240313181918.azurewebsites.net/api/vehicles';
 
  constructor(private http: HttpClient) { }
 
  PostVehicle(vehicleDetails: any): Observable<any> {
    return this.http.post<any>(this.apiUrl, vehicleDetails);

  }
}