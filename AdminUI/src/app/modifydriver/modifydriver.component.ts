import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { driverlist } from '../driverlist.model';
import { ManagedriversComponent } from '../managedrivers/managedrivers.component';

@Component({
  selector: 'app-modifydriver',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule, ManagedriversComponent],
  templateUrl: './modifydriver.component.html',
  styleUrl: './modifydriver.component.css'
})
export class ModifydriverComponent implements OnInit {
  driver: any = {}; // Assuming you have the vehicle object available

  constructor() { }

  ngOnInit(): void {
    // If needed, you can initialize data or fetch it from a service here
  }

  updatedriver(): void {
    // Implement your update logic here
    console.log('Updated driver:', this.driver);
  }

  // drivers: driverlist[] = [];
  // constructor(private router: Router) { }
  // ngOnInit(): void {
  //   throw new Error('Method not implemented.');
  // }
}



