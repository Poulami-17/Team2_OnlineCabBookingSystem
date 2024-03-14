import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-viewroutes',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule, ReactiveFormsModule],
  templateUrl: './viewroutes.component.html',
  styleUrl: './viewroutes.component.css'
})
export class ViewroutesComponent {
  constructor(private router: Router) { } // Now using Angular's Router

  routes = [
    {
      ID: '1',
      PickUpLocation: 'Bangalore',
      DropOffLocation: 'Mysore',
      Distance: '150.34',
      Amount: '6000.0'
          // RideStatus: 'Completed',
    // PaymentType: 'Cash',
    // TransctionID: 'NA' 
    },
    {
      ID: '2',
      PickUpLocation: 'Mysore',
      DropOffLocation: 'Bangalore',
      Distance: '150.34',
      Amount: '6000.0'
    },
    {
      ID: '3',
      PickUpLocation: 'Bangalore',
      DropOffLocation: 'Chennai',
      Distance: '350.34',
      Amount: '9000.0'
    }
  ];

  goBack() {
    this.router.navigate(['/routeshomepage']);
  }

}


