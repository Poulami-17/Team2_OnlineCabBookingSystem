import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-addvehicle',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule ],
  templateUrl: './addvehicle.component.html',
  styleUrl: './addvehicle.component.css'
})
export class AddvehicleComponent {
  //    loginForm: FormGroup;
  // constructor(private fb: FormBuilder){     
  //   this.loginForm = this.fb.group({  
  //   VehicleNumber: ['', Validators.required],  
  //   Brand: ['', Validators.required],   
  //   color: ['', [Validators.required, Validators.email]], 
  //   type: ['', Validators.required],    
  //   CreateDate: ['', Validators.required],});}   
    


  //   addVehicle(formValue: any): void {
  //     console.log('Form submitted with values:', formValue);
    // onSubmit()
    //  { if (this.loginForm.valid) 
    //   {  const formValues = this.loginForm.value;       
    //     console.log(formValues);



  //   newVehicle: any = {};

  // constructor() { }

  // addVehicle(formValue: any): void {
  //   console.log('Form submitted with values:', formValue);
  //   // Here you can implement the logic to add the vehicle using the form values
//     // For example, you can call a service method to send the form data to the backend
//     newVehicle: any = {};

//     constructor() { }
  
//     addVehicle(formValue: any): void {
//       console.log('Form submitted with values:', formValue);
 
 
 
 
 
//   }
// }
      

newVehicle: any = {};
form: FormGroup;
photo?: any;

// Define options for VehicleType and Category
vehicleTypes = ['Car', 'Truck', 'Motorcycle']; // Update with actual enum values
categories = ['Category1', 'Category2', 'Category3']; // Update with actual enum values

constructor(private http: HttpClient, private router: Router) {
  this.form = new FormGroup({
    'VehicleNumber': new FormControl('', [Validators.required]),
    'Brand': new FormControl('', [Validators.required]),
    'Color': new FormControl(''),
    'Type': new FormControl('', [Validators.required]),
    'VehicleType': new FormControl('', [Validators.required]),
    'Category': new FormControl('', [Validators.required])
  });
}

updateFile(event: any) {
  if (event.target.files.length > 0) {
    this.photo = event.target.files[0];
  }
}

onSubmit() {
  this.form.markAllAsTouched();
  if (this.form.valid) {
    const formData = new FormData();
    var d = this.form.value;
    d.VehicleType = +d.VehicleType;
    formData.append("data",JSON.stringify(d));
    /*formData.append("VehicleNumber", this.form.get('VehicleNumber')!.value);
    formData.append("Brand", this.form.get('Brand')!.value);
    formData.append("Color", this.form.get('Color')!.value);
    formData.append("Type", this.form.get('Type')!.value);*/
    formData.append("Photo", this.photo);
    // formData.append("VehicleType", this.form.get('VehicleType')!.value);
    // formData.append("Category", this.form.get('Category')!.value);

    this.http.post<any>("http://localhost:5173/api/AdminVehicleManage", formData)
      .subscribe(
        response => {
          console.log(response);
          alert('Added successfully');
          this.router.navigate(['/managevehicles']);
        },
        error => {
          console.error(error);
          alert("Error occurred while adding vehicle.");
        }
      );
  } else {
    console.log(this.form.errors);
    alert("Form is invalid. Please fill in all required fields.");
  }
}
}





    