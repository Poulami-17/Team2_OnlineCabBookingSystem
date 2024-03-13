import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { DriverLoginService } from '../driver-login.service';

@Component({
  selector: 'app-driver-login',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './driver-login.component.html',
  styleUrl: './driver-login.component.css'
})
export class DriverLoginComponent {
  DriverLogin: FormGroup;
 
  constructor(private driverLogin: DriverLoginService, private router: Router) {

    this.DriverLogin = new FormGroup({
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
    if (this.DriverLogin.valid) {
      console.log(this.DriverLogin.value);
      this.driverLogin.login(this.DriverLogin.value);

    } else {
      // If form is invalid, do not proceed with submission
      alert("Form is invalid. Please fill in all required fields.");
    }

  }
}
