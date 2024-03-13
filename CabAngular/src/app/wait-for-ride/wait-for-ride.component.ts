import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { DriverDetailsComponent } from '../../AppComponents/driver-details/driver-details.component';

@Component({
  selector: 'app-wait-for-ride',
  standalone: true,
  imports: [CommonModule, RouterModule,DriverDetailsComponent],
  templateUrl: './wait-for-ride.component.html',
  styleUrl: './wait-for-ride.component.css'
})
export class WaitForRideComponent {
  constructor(private router: Router){}
  getDriverDetails()
  {
    this.router.navigate(['/driverDetails']);
  }

}
