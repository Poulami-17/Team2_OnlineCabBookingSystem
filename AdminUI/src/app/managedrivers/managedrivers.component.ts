import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { ManagedriversService } from '../managedrivers.service';

@Component({
  selector: 'app-managedrivers',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, HttpClientModule],
  templateUrl: './managedrivers.component.html',
  styleUrl: './managedrivers.component.css'
})
export class ManagedriversComponent {
  constructor(private managedriversService: ManagedriversService, private router: Router) { }
  showDriverOptionsFlag: boolean = false;
  showDriverOptions(){
   this.showDriverOptionsFlag = true;
 }
 adddriver(){
   this.router.navigate(['/adddriver'])
 }
modifydriver(){
   this.router.navigate(['/modifydriver'])
 }
 deletedriver(){
   this.router.navigate(['/deletedriver'])
 }

 driverDetails: any = {
  name: '',
  licenseNumber: ''
};




 addDriver() {
  this.managedriversService.adddriver(this.driverDetails)
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