import { Routes } from '@angular/router';
import { AcceptRideComponent } from './accept-ride/accept-ride.component';
import { DriverLoginComponent } from './driver-login/driver-login.component';

export const routes: Routes = [
    {path : "" ,component : DriverLoginComponent},
    {path:"Accept", component:AcceptRideComponent}
];
