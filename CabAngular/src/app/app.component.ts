import { HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CustomerLoginComponent } from '../AppComponents/customer-login/customer-login.component';
import { CustomerSignupComponent } from '../AppComponents/customer-signup/customer-signup.component';
import { DriverDetailsComponent } from '../AppComponents/driver-details/driver-details.component';
import { NavbarComponent } from './navbar/navbar.component';
import { PaymentComponent } from './payment/payment.component';
import { RideBookComponent } from './ride-book/ride-book.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CustomerSignupComponent,CustomerLoginComponent,RideBookComponent,DriverDetailsComponent,HttpClientModule, NavbarComponent,PaymentComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'CabAngular';
}
