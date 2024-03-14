import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { Customer } from '../customer.model';
import { ViewcustomersService } from '../viewcustomers.service';

@Component({
  selector: 'app-viewcustomers',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, HttpClientModule ],
  templateUrl: './viewcustomers.component.html',
  styleUrl: './viewcustomers.component.css'
})
export class ViewcustomersComponent implements OnInit{
  
//   customerData: any;
//   router: any;

//   constructor(private viewcustomersService: ViewcustomersService) { }

//   fetchCustomerData(): void {
//     this.viewcustomersService.CustomerData().subscribe((data: any) => {
//       this.customerData = data;
//     }, error => {
//       console.error('Error:', error);
//     });
//   }
//   objectKeys(obj: any): string[] {
//     return Object.keys(obj);
//   }
//   goBack(): void {
//     this.router.navigate(['/customerhomepage']);
//   }
//   }
  

// // constructor(private route: ActivatedRoute, private router: Router) { }

// // ngOnInit(): void {
// //   this.route.params.subscribe(params => {
// //     const id = params['id'];
// //     this.customer = this.customers.find(customer => customer.id === id);
// //   });
// // }

// // searchCustomer(): void {
// //   this.customer = this.customers.find(customer => customer.id === this.inputId);
// // }

// customers: Customer[] = [];

// constructor(private viewcustomersService: ViewcustomersService) { }

// ngOnInit(): void {
//   this.loadCustomers();
// }

// loadCustomers(): void {
//   this.viewcustomersService.getAllCustomers()
//     .subscribe(customers => {
//       this.customers = customers;
//     });
// }
// }


CustomerData: any[] | undefined;
// customers = [
//   { ID: 1, Name: 'meghana', Email:'meghana@gmail.com', PhoneNumber: 8937873738, Address: 'Banglore', UserName: 'meg', Password: 'bat'},
//   { ID: 2, Name: 'praharshini',Email:'praharshini@gmail.com',PhoneNumber: 8654321090, Address: 'Vizag', UserName: 'pra', Password: 'map'},
// ];



//   this.http.get<any[]>(apiUrl).subscribe(
//     (data) => {
//       this.CustomerData = data;
//     },
//     (error) => {
//       console.error('Error fetching customer data:', error);
//     }
//   );
// }


constructor() { }

  ngOnInit(): void {
    // You can perform any additional initialization logic here if needed
  }
}