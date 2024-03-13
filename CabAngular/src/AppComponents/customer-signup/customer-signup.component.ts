import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CustomerSignupService } from '../../app/customer-signup.service';

@Component({
  selector: 'app-customer-signup',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './customer-signup.component.html',
  styleUrl: './customer-signup.component.css'
})
export class CustomerSignupComponent {
  CustomerSignup: FormGroup;
 
  constructor(private http: HttpClient, private router: Router, private customerSignupAccess: CustomerSignupService) {
    this.CustomerSignup = new FormGroup({
      'Name': new FormControl('', [
        Validators.required,
        Validators.minLength(3),
        Validators.maxLength(50)
      ]),
      'Email': new FormControl('', [
        Validators.required,
        Validators.email
      ]),
      'Password': new FormControl('', [
        Validators.required
 
      ]),
      'Phone': new FormControl('', [
        Validators.required,
        Validators.pattern(/^\d{10}$/)
      ]),
    });
  }
 
  signup() {
    // Check if the form is valid
    if (this.CustomerSignup.valid) {
      console.log(this.CustomerSignup.value);
      this.customerSignupAccess.signup(this.CustomerSignup.value);
 
    } else {
      // If form is invalid, do not proceed with submission
      alert("Form is invalid. Please fill in all required fields.");
    }
 
    this.router.navigate(['']);
  }
  
}