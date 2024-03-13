import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { CustomerLoginComponent } from '../../AppComponents/customer-login/customer-login.component';
import { RideBookComponent } from '../ride-book/ride-book.component';

@Component({
  selector: 'app-last-page',
  standalone: true,
  imports: [FormsModule,CommonModule,RideBookComponent],
  templateUrl: './last-page.component.html',
  styleUrl: './last-page.component.css'
})
export class LastPageComponent {
  constructor(private router: Router){}
  rideBook(){
  this.router.navigate(['/rideBook']);
 }
}
