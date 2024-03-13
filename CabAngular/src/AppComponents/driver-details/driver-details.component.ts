import { Component } from '@angular/core';
import {IVehicleDetails } from './VehicleDetails.component.model';
import {IDriverDetails } from './driverdetails.component.model';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { PaymentComponent } from '../../app/payment/payment.component';

@Component({
  selector: 'app-driver-details',
  standalone: true,
  imports: [CommonModule,FormsModule,PaymentComponent],
  templateUrl: './driver-details.component.html',
  styleUrl: './driver-details.component.css'
})
export class DriverDetailsComponent {
  driverDetails: IDriverDetails[] =
    [
      {
      DriverName:'Demo Driver',
      DriverPhoto:'/assets/DriverImg.png',
      DriverPhoneNumber:9876543210
      }
    ]
 
    vehicleDetails:IVehicleDetails[]=[
      {vehicleType:'i20',
        vehicleNumber:'WB-1608',
        vehicleImage:'/assets/VehicleImg.png'
      }
    ]
  
    constructor(private router: Router){}
    payment()
    {
      this.router.navigate(['/payment']);
    }
    Cancel(){
      this.router.navigate(['/rideBook']);
    }
}
