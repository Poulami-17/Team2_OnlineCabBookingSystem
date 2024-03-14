import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { driverlist } from '../driverlist.model';
import { ManagedriversService } from '../managedrivers.service';
import { ManagedriversComponent } from '../managedrivers/managedrivers.component';

@Component({
  selector: 'app-deletedriver',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule, ManagedriversComponent],
  templateUrl: './deletedriver.component.html',
  styleUrl: './deletedriver.component.css'
})
export class DeletedriverComponent {
  // driver: driverlist = {
  //   LicenseNumber: '',
  //   Name: '',
  //   Email: '',
  //   // Initialize other properties as needed
  //   Password: '',
  //   Gender: '',
  //   UserName: '',
  //   AadharNumber: 0,
  //   PhoneNumber: 0,
  //   Vehicle: ''
  // };
  // driverlist: { LicenseNumber: any; Name: any; Email: any; Password: any; Gender: any;
  // UserName: any; AadharNumber: any; PhoneNumber: any; Vehicle: any; } | undefined;
 
  // constructor(private route: ActivatedRoute, private router: Router) {}
 
  // ngOnInit(): void {
  //   this.route.queryParams.subscribe(params => {
  //     this.driverlist = {
  //       LicenseNumber: params['LicenseNumber'],
  //       Name: params['Name'],
  //       Email: params['Email'],
  //       Password: params['Password'],
  //       Gender: params['Gender'],
  //       UserName: params['UserName'],
  //       AadharNumber: params['AadharNumber'],
  //       PhoneNumber: params['PhoneNumber'],
  //       Vehicle: params['Vehicle']
       
  //       // Assign other properties as needed
  //     };
  //   });
  // }
 
//   deleteDriver() {
//     // Implement your logic to delete the driver
//     console.log('Driver deleted:', this.driver);
//     // After deleting, navigate back to the Manage Drivers page or any other appropriate page
//     this.router.navigate(['/manage-drivers']);
//   }
// }

driverId!: number;

constructor(
  private route: ActivatedRoute,
  private router: Router,
  private managedriversService: ManagedriversService
) { }

ngOnInit(): void {
  this.route.params.subscribe(params => {
    this.driverId = +params['id']; // Retrieve the driver id from the route
  });
}

deleteDriver(): void {
  this.managedriversService.deleteDriver(this.driverId).subscribe(
    () => {
      console.log('Driver deleted successfully');
      // Optionally, you can redirect the user to a different page after successful deletion
      this.router.navigate(['/managedrivers']); // Assuming '/drivers' is the route for driver list
    },
    error => {
      console.error('Error deleting driver:', error);
      // Handle error, such as displaying an error message to the user
    }
  );
}

cancelDeletion(): void {
  this.router.navigate(['/drivers']); // Navigate to the driver list page
  // Alternatively, you can navigate back to the previous page using:
   this.router.navigate(['../managedrivers']);
}
}
