import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { AdminhomepageComponent } from '../adminhomepage/adminhomepage.component';


@Component({
  selector: 'app-manageroutes',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, AdminhomepageComponent],
  templateUrl: './manageroutes.component.html',
  styleUrl: './manageroutes.component.css'
})
export class ManageroutesComponent {
  constructor(private router: Router) { }
  showRoutesOptionsFlag: boolean = false;
  showRoutesOptions() {
    this.showRoutesOptionsFlag = true;
  }

  addroutes() {
    this.router.navigate(['/addroutes']);
  }

  deleteroutes() {
    this.router.navigate(['/deleteroutes']);
  }

  viewroutes() {
    this.router.navigate(['/viewroutes']);
  }

  // vehicleDetails: any = {
  //   make: '',
  //   model: '',
  //   year: ''
  // };

  // Method to add a vehicle
  // AddVehicles() {
  //   this.managevehiclesService.addVehicle(this.vehicleDetails)
  //     .subscribe(
  //       response => {
  //         console.log('Vehicle added successfully:', response);
  //         // Clear form or handle success as needed
  //       },
  //       error => {
  //         console.error('Error adding vehicle:', error);
  //         // Handle error
  //       }
  //     );
  // }



  // AddVehicles() {
  //   this.managevehiclesService.PostVehicle(this.vehicleDetails)
  //     .subscribe(
  //       response => {
  //         console.log('Vehicle added successfully:', response);
  //         // Clear form or handle success as needed
  //       },
  //       error => {
  //         console.error('Error adding vehicle:', error);
  //         // Handle error
  //       }
  //     );
  // }
}




  



