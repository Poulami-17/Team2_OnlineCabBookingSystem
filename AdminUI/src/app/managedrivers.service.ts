import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ManagedriversService {
//   adddriver(driverDetails: any) {
//     throw new Error('Method not implemented.');
//   }
//   private apiUrl = 'http://localhost:5173/api/AdminManageDriver';
 
//   constructor(private http: HttpClient) { }
 
//   addDriver(driverDetails: any): Observable<any> {
//     return this.http.post<any>(this.apiUrl, driverDetails);
//   } 
// }


private apiUrl = 'http://localhost:5173/api/AdminManageDriver';

constructor(private http: HttpClient) {}

adddriver(driverDetails: any): Observable<any> {
  return this.http.post<any>(this.apiUrl, driverDetails);
}

private apiUrl1 = 'https://cabappapi20240313181918.azurewebsites.net/api/vehicles';
 
 // constructor(private http: HttpClient) { }
 
  PostVehicle(vehicleDetails: any): Observable<any> {
    return this.http.post<any>(this.apiUrl1, vehicleDetails);

  }
  deleteDriver(driverId: number): Observable<void> {
    const url = `${this.apiUrl}/${driverId}`;
    return this.http.delete<void>(url);
  }
}

