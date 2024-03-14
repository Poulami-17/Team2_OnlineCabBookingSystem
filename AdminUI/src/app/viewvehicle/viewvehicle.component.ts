import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-viewvehicle',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule ],
  templateUrl: './viewvehicle.component.html',
  styleUrl: './viewvehicle.component.css'
})
export class ViewvehicleComponent implements OnInit{
  // ngOnInit(): void {
  //   throw new Error('Method not implemented.');
  // }
vehicles = [
  {
    id: '1',
    VehicleNumber: "Vehicle Name 1",
    //VehiclePhoto:
    Brand: "tata",
    Color:"white",
    VehicleType: 4,
    Title: "Seden",
    Description: "Spacious and clean",
    PerKmCharge: 30.0
  },
  {
    id: '2',
    VehicleNumber: "Vehicle Name 1",
    //VehiclePhoto:
    Brand: "tata",
    Color:"white",
    VehicleType: 4,
    Title: "Seden",
    Description: "Spacious and clean",
    PerKmCharge: 30.0
  },
  {
    id: '3',
    VehicleNumber: "Vehicle Name 1",
    //VehiclePhoto:
    Brand: "tata",
    Color:"white",
    VehicleType: 4,
    Title: "Seden",
    Description: "Spacious and clean",
    PerKmCharge: 30.0
  }
];

vehicle: any;
inputId: string | undefined;

constructor(private route: ActivatedRoute, private router: Router) { }

ngOnInit(): void {
  this.route.params.subscribe(params => {
    const id = params['id'];
    this.vehicle = this.vehicles.find(vehicle => vehicle.id === id);
  });
}

searchVehicle(): void {
  this.vehicle = this.vehicles.find(vehicle => vehicle.id === this.inputId);
}

goBack(): void {
  this.router.navigate(['/vehiclehomepage']);
}
}

