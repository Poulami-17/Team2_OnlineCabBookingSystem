import { Routes } from '@angular/router';
import { AboutsComponent } from './abouts/abouts.component';
import { AdddriverComponent } from './adddriver/adddriver.component';
import { AddroutesComponent } from './addroutes/addroutes.component';
import { AddvehicleComponent } from './addvehicle/addvehicle.component';
import { AdminhomepageComponent } from './adminhomepage/adminhomepage.component';
import { AdminloginComponent } from './adminlogin/adminlogin.component';
import { BookingdetailsComponent } from './bookingdetails/bookingdetails.component';
import { ContactComponent } from './contact/contact.component';
import { CustomerloginComponent } from './customerlogin/customerlogin.component';
import { DeletedriverComponent } from './deletedriver/deletedriver.component';
import { DeleteroutesComponent } from './deleteroutes/deleteroutes.component';
import { DeletevehicleComponent } from './deletevehicle/deletevehicle.component';
import { HomepageComponent } from './homepage/homepage.component';
import { ManagecustomersComponent } from './managecustomers/managecustomers.component';
import { ManagedriversComponent } from './managedrivers/managedrivers.component';
import { ManageroutesComponent } from './manageroutes/manageroutes.component';
import { ManagevehiclesComponent } from './managevehicles/managevehicles.component';
import { ModifydriverComponent } from './modifydriver/modifydriver.component';
import { ModifyvehicleComponent } from './modifyvehicle/modifyvehicle.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ViewcustomersComponent } from './viewcustomers/viewcustomers.component';
import { ViewroutesComponent } from './viewroutes/viewroutes.component';
import { ViewvehicleComponent } from './viewvehicle/viewvehicle.component';

export const routes: Routes = [
    {path:'', component: HomepageComponent},
    {path:'homepage', component:HomepageComponent},
    {path:'navbar', component:NavbarComponent},
    {path:'abouts', component:AboutsComponent},
    {path:'contact', component:ContactComponent},
    {path:'adminlogin', component:AdminloginComponent},
    {path:'customerlogin', component:CustomerloginComponent},
    {path:'adminhomepage', component:AdminhomepageComponent},
    {path:'managevehicles', component:ManagevehiclesComponent},
    {path:'addVehicle', component:AddvehicleComponent},
    {path:'viewVehicle', component:ViewvehicleComponent},
    {path:'deleteVehicle', component:DeletevehicleComponent},
    {path:'modifyvehicle',component:ModifyvehicleComponent},
    {path:'bookingdetails',component:BookingdetailsComponent},
   {path:'managedrivers', component:ManagedriversComponent},
    {path:'adddriver',component:AdddriverComponent},
    {path:'deletedriver', component:DeletedriverComponent},
    {path:'modifydriver', component:ModifydriverComponent},
    {path:'managecustomers', component:ManagecustomersComponent},
    {path:'viewcustomers', component:ViewcustomersComponent},
    {path:'manageroutes', component:ManageroutesComponent},
    {path:'addroutes', component:AddroutesComponent},
    {path:'viewroutes', component:ViewroutesComponent},
    {path:'deleteroutes', component:DeleteroutesComponent}
];
