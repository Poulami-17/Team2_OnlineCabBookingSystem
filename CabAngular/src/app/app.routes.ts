import { Routes } from '@angular/router';
import { CustomerLoginComponent } from '../AppComponents/customer-login/customer-login.component';
import { CustomerSignupComponent } from '../AppComponents/customer-signup/customer-signup.component';
import { DriverDetailsComponent } from '../AppComponents/driver-details/driver-details.component';
import { authGuard } from './auth.guard';
import { LastPageComponent } from './last-page/last-page.component';
import { PaymentComponent } from './payment/payment.component';
import { RideBookComponent } from './ride-book/ride-book.component';
import { WaitForRideComponent } from './wait-for-ride/wait-for-ride.component';

export const routes: Routes = [
    {path:'',component:CustomerLoginComponent},
    {path:'rideBook',component:RideBookComponent,canActivate:[authGuard]},
    {path:'wait',component:WaitForRideComponent,canActivate:[authGuard]},
    {path:'driverDetails', component:DriverDetailsComponent},
    {path:'signup',component:CustomerSignupComponent},
    {path:'payment',component:PaymentComponent},
    {path:'lastPage',component:LastPageComponent}
];
