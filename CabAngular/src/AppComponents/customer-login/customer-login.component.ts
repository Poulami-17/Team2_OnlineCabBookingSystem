import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CustomerLoginService } from '../../app/customer-login.service';
import { CustomerSignupComponent } from '../customer-signup/customer-signup.component';

@Component({
  selector: 'app-customer-login',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule,HttpClientModule],
  templateUrl: './customer-login.component.html',
  styleUrl: './customer-login.component.css'
})
export class CustomerLoginComponent {
  CustomerLogin: FormGroup;

  constructor(private customerAccess: CustomerLoginService, private router: Router) {

    this.CustomerLogin = new FormGroup({

      'email': new FormControl('', [
        Validators.required,
        Validators.email
      ]),
      'password': new FormControl('', [
        Validators.required
      ])
    });
  }


  login() {
    // Check if the form is valid
    if (this.CustomerLogin.valid) {
      console.log(this.CustomerLogin.value);
      this.customerAccess.login(this.CustomerLogin.value);
    } else {
      // If form is invalid, do not proceed with submission
      alert("Form is invalid. Please fill in all required fields.");
    }

  }
}
