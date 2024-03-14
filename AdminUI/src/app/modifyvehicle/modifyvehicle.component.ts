import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-modifyvehicle',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule],
  templateUrl: './modifyvehicle.component.html',
  styleUrl: './modifyvehicle.component.css'
})
export class ModifyvehicleComponent implements OnInit{
  vehicle: any = {}; // Assuming you have the vehicle object available

  constructor() { }

  ngOnInit(): void {
    // If needed, you can initialize data or fetch it from a service here
  }

  updateVehicle(): void {
    // Implement your update logic here
    console.log('Updated vehicle:', this.vehicle);
  }
}