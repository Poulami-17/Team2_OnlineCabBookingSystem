import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { timeStamp } from 'console';
import { ManagevehiclesService } from '../managevehicles.service';

@Component({
  selector: 'app-managevehicles',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule],
  templateUrl: './managevehicles.component.html',
  styleUrl: './managevehicles.component.css'
})
export class ManagevehiclesComponent {
//  constructor(private managevehicleService: ManagevehicleService, private router: Router) { }
//  showVehicleOptionsFlag: boolean = false;
//  showVehicleOptions(){
//   this.showVehicleOptionsFlag = true;
//  }
// addVehicle(){
//   this.router.navigate(['/addVehicle'])
// }
// updateVehicle(){
//   this.router.navigate(['/modifyVehicle'])
// }
// deleteVehicle(){
//   this.router.navigate(['/deleteVehicle'])
// }
// viewVehicles(){
//   this.router.navigate(['/viewVehicle'])
// }


// vehicleDetails: any = {
//   make: '',
//   model: '',
//   year: ''
// };



// addVehicle() {
//   this.managevehicleService.addVehicle(this.vehicleDetails)
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
// }





showVehicleOptionsFlag: boolean = false;

  constructor(private managevehiclesService: ManagevehiclesService, private router: Router) { }

  showVehicleOptions() {
    this.showVehicleOptionsFlag = true;
  }

  addVehicle() {
    this.router.navigate(['/addVehicle']);
  }

  updateVehicle() {
    this.router.navigate(['/modifyvehicle']);
  }

  deleteVehicle() {
    this.router.navigate(['/deleteVehicle']);
  }

  viewVehicles() {
    this.router.navigate(['/viewVehicle']);
  }

  vehicleDetails: any = {
    make: '',
    model: '',
    year: ''
  };

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



  AddVehicles() {
    this.managevehiclesService.PostVehicle(this.vehicleDetails)
      .subscribe(
        response => {
          console.log('Vehicle added successfully:', response);
          // Clear form or handle success as needed
        },
        error => {
          console.error('Error adding vehicle:', error);
          // Handle error
        }
      );
  }
}




  

