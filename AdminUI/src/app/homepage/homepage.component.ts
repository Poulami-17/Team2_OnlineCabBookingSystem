import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { DeletevehicleComponent } from '../deletevehicle/deletevehicle.component';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
  selector: 'app-homepage',
  standalone: true,
  imports: [CommonModule, RouterModule, NavbarComponent],
  templateUrl: './homepage.component.html',
  styleUrl: './homepage.component.css'
})
export class HomepageComponent {
  constructor(private router: Router) {}
  customerlogin() {
    this.router.navigate(['/customerlogin']);
  }
  adminlogin() {
    this.router.navigate(['/adminlogin']);
  }
  addVehicle(){
    this.router.navigate(['/addVehicle']);
  }
  viewVehicle(){
    this.router.navigate(['/viewVehicle']);
  }
  deleteVehicle(){
    this.router.navigate(['/deleteVehicle']);
  }
  updateVehicle(){
    this.router.navigate(['/updateVehicle']);
  }
}
