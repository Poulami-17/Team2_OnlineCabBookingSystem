import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-deletevehicle',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule],
  templateUrl: './deletevehicle.component.html',
  styleUrl: './deletevehicle.component.css'
})
export class DeletevehicleComponent {
  vehicles: any[] = []; // Assuming this array holds the vehicles
  vehicleIdToDelete: any; // Assuming you have some way of getting the ID of the vehicle to delete

  deleteVehicle(): void {
    // Find the index of the vehicle to delete
    const index = this.vehicles.findIndex(vehicle => vehicle.id === this.vehicleIdToDelete);
    
    if (index !== -1) {
      // Remove the vehicle from the array
      this.vehicles.splice(index, 1);
      console.log('Vehicle deleted successfully');
      // Perform any other necessary actions after deletion
    } else {
      console.error('Vehicle not found');
    }
}
}
