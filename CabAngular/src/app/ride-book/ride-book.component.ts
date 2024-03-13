import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'app-ride-book',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './ride-book.component.html',
  styleUrl: './ride-book.component.css'
})
export class RideBookComponent {
  rideBook: FormGroup;
 
  constructor(private http: HttpClient, private router: Router) {
    this.rideBook = new FormGroup({
      'PickUp': new FormControl(''),
      'DropUp': new FormControl(''),
      'Distance': new FormControl(''),
      'VehicleCategoryId': new FormControl(),
    });
  }
  Enter() {

    var token = JSON.parse( localStorage.getItem('accessToken') || "");
    this.http.post("http://localhost:5173/api/CustomerBooking/BookCab",{...this.rideBook.value, Distance :  +this.rideBook.get("Distance")?.value},
  {headers :{Authorization :"Bearer " + token.token}}).subscribe((response:any)=>{this.rideBook=response;});

  this.router.navigate(['/wait']);
}

}
