import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from './customer.model';

@Injectable({
  providedIn: 'root'
})
export class ViewcustomersService {

//   customerData: any[] | undefined;

//   constructor(private http: HttpClient) { }

//   ngOnInit() {
//     // Fetch all customer data when the component initializes
//     this.fetchAllCustomerData();
//   }

//   fetchAllCustomerData() {
//     // Replace 'YOUR_API_URL' with the actual API URL from which you want to fetch all customer data
//     const apiUrl = 'YOUR_API_URL';

//     this.http.get<any[]>(apiUrl).subscribe(
//       (data) => {
//         this.customerData = data;
//       },
//       (error) => {
//         console.error('Error fetching customer data:', error);
//       }
//     );
//   }
// }
  // private apiUrl = 'http://localhost:5173/api/AdminViewCustomer/'; 
 
  // constructor(private http: HttpClient) { }
 
  // getCustomerData(): Observable<any> {
  //   return this.http.get<any[]>(this.apiUrl + '/allProducts');
  // }
    // return this.http.get(`http://localhost:5173/api/AdminViewCustomer/Customers/${id}`);
    //   return this.http.get(`${this.apiUrl}/${id}`);
 //}



// getCustomerData() :Observable<any[]> {
 // console.log('getCustomerData', localStorage.getItem('token'));
//   return this.http.get<any[]>(this.apiUrl + '/allProducts');
// }
// }


// constructor(private http: HttpClient) { }

//   private baseUrl = 'http://localhost:5173/api/AdminViewCustomer'; 


//   getAllCustomers(): Observable<Customer[]> {
//     return this.http.get<Customer[]>(`${this.baseUrl}`);
//   }
// }




private apiUrl = 'https://cabappapi20240313181918.azurewebsites.net/api/AdminViewCustomer'; // Replace 'YOUR_API_URL' with the actual API URL from which you want to fetch all customer data

  constructor(private http: HttpClient) { }

  fetchAllCustomerData(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}