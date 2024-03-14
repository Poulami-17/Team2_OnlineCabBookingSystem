import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-bookingdetails',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule],
  templateUrl: './bookingdetails.component.html',
  styleUrl: './bookingdetails.component.css'
})
export class BookingdetailsComponent {
  booking: any = {
    customerId: 12345,
    rideId: 67890,
    customerName: 'Jane Doe',
    pickupLocation: 'Street A',
    dropOffLocation: 'Street B',
    fare: 25
  }
}
