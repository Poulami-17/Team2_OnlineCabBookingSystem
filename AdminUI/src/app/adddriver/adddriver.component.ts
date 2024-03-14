import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { ManagedriversService } from '../managedrivers.service';
import { ManagedriversComponent } from '../managedrivers/managedrivers.component';

@Component({
  selector: 'app-adddriver',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule, ManagedriversComponent, ReactiveFormsModule],
  templateUrl: './adddriver.component.html',
  styleUrl: './adddriver.component.css',
  providers:[ManagedriversService]

})
export class AdddriverComponent{
 // driverForm: any;
  // constructor(private managedriversService: ManagedriversService, private router: Router){}
  // onSubmit() {
    // Check if the form is valid
    // if (this.form.valid) {
    //   console.log(this.form.value);
    //   this.adminloginService.login(this.form.value);



    // } else {
      // If form is invalid, do not proceed with submission
  //     alert("Form is invalid. Please fill in all required fields.");
  //   }

  // }

  // newdriver: any = {};

  // constructor() { }

  // adddriver(formValue: any): void {
  //   console.log('Form submitted with values:', formValue
  
  
  // driverForm: FormGroup;
  // managedriverService: any;
  //constructor(private fb: FormBuilder, private managedriversService: ManagedriversService, private router: Router){ 
    //driverForm: FormGroup;  
    //this.driverForm = this.fb.group({  
    // Drivers: any = {
    // LicenseNumber: ['', Validators.required],  
    // Password: ['', Validators.required],  
    // Email: ['', [Validators.required, Validators.email]],
    // PhoneNumber: ['', Validators.required],    
    // Name: ['', Validators.required],      
    // UserName: ['', Validators.required],    
    // Gender: ['', Validators.required],
    // AadharNumber: ['', Validators.required],
    // Vehicle : ['', Validators.required],};}
  //ngOnInit(): void {
    //throw new Error('Method not implemented.');
  //}
 
//     onSubmit()
//      {
//        if (this.driverForm.valid)
//       { 
        
//         const formValues = this.driverForm.value;      
//         console.log(formValues);
     
//      }
//      alert("submitted successfully")
// }
 
// }

// onSubmit() {
//   if (this.driverForm.valid) {
//     const formValues = this.driverForm.value;
//     this.managedriversService.addDriver(formValues).subscribe(
//       response => {
//         console.log('Driver added successfully:', response);
//         alert('Driver added successfully');
//         // Clear the form after successful submission if needed
//         this.driverForm.reset();
//       },
//       error => {
//         console.error('Error occurred while adding driver:', error);
//         alert('Error occurred while adding driver');
//       }
//     }
//   }
// }

// adddrivers() {
//   this.managedriversService.addVehicle(this.Drivers)
//     .subscribe(
//       response => {
//         console.log('Driver added successfully:', response);
//         // Clear form or handle success as needed
//       },
//       error => {
//         console.error('Error adding Driver:', error);
//         // Handle error
//       }
//     );
// }
// }






// driverForm: FormGroup;
//   onSubmitFlag: boolean = false;

//   constructor(
//     private fb: FormBuilder,
//     private driverService: ManagedriversService
//   ) {
//     this.driverForm = this.fb.group({
//       LicenseNumber: ['', Validators.required],
//       Password: ['', Validators.required],
//       Email: ['', [Validators.required, Validators.email]],
//       PhoneNumber: ['', Validators.required],
//       Name: ['', Validators.required],
//       UserName: ['', Validators.required],
//       Gender: ['', Validators.required],
//       AadharNumber: ['', Validators.required],
//       Vehicle: ['', Validators.required]
//     });
//   }

//   onSubmit() {
//     this.onSubmitFlag = true;
//     if (this.driverForm.valid) {
//       const formValues = this.driverForm.value;
//       this.driverService.addDriver(formValues).subscribe(
//         response => {
//           console.log('Driver added successfully:', response);
//           alert('Driver added successfully');
//           // Clear the form after successful submission if needed
//           this.driverForm.reset();
//         },
//         error => {
//           console.error('Error occurred while adding driver:', error);
//           alert('Error occurred while adding driver');
//         }
//       );
//     }
//   }
// }





// driverForm: FormGroup;
//   submitted: boolean = false;

//   constructor(
//     private fb: FormBuilder,
//     private driverService: ManagedriversService,
//     private router: Router
//   ) {
//     this.driverForm = this.fb.group({
//       Name: ['', Validators.required],
//       // Add other form fields with corresponding validators
//     });
//   }

//   onSubmit() {
//     this.submitted = true;
//     if (this.driverForm.valid) {
//       const formValues = this.driverForm.value;
//       this.driverService.PostDrivers(formValues).subscribe(
//         (response) => {
//           console.log('Submitted successful', response);
//           alert('Submitted successful');
//           this.router.navigate(['/viewdrivers']);
//         },
//         (error) => {
//           console.error('Submission failed', error);
//           alert('Submission failed');
//         }
//       );
//     }
//   }
// }





driverForm: FormGroup;
driverDetails: any = {}; 

  constructor(private fb: FormBuilder, private service: ManagedriversService, private router: Router) {
    this.driverForm = this.fb.group({
      LicenseNumber: ['', Validators.required],
      Password: ['', Validators.required],
      Email: ['', [Validators.required, Validators.email]],
      PhoneNumber: ['', Validators.required],
      Name: ['', Validators.required],
      UserName: ['', Validators.required],
      Gender: ['', Validators.required],
      AadharNumber: ['', Validators.required],
      Vehicle: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.driverForm.valid) {
      this.driverDetails = this.driverForm.value; // Assign form values to driverDetails
      this.service.adddriver(this.driverDetails).subscribe(
        response => {
          console.log('Submitted successfully', response);
          alert('Submitted successfully');
          this.router.navigate(['/viewdrivers']);
        },
        error => {
          console.error('Submission failed', error);
          alert('Submission failed');
        }
      );
    }
}
}

