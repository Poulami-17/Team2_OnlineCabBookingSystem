import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { NavbarComponent } from '../navbar/navbar.component';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { AdminloginService } from '../adminlogin.service';

@Component({
  selector: 'app-adminlogin',
  standalone: true,
  imports: [CommonModule ,RouterModule, NavbarComponent, FormsModule, HttpClientModule, ReactiveFormsModule],
  templateUrl: './adminlogin.component.html',
  styleUrl: './adminlogin.component.css'
})
export class AdminloginComponent {
  form: FormGroup;


  constructor(private adminloginService: AdminloginService, private router: Router) {

    this.form = new FormGroup({

      'email': new FormControl('', [
        Validators.required,
        Validators.email
      ]),
      'password': new FormControl('', [
        Validators.required
      ])
    });
  }


  onSubmit(formvalues:any) {
    // Check if the form is valid
    if (this.form.valid) {
      console.log(this.form.value);
      this.adminloginService.login(this.form.value);



    } else {
      // If form is invalid, do not proceed with submission
      alert("Form is invalid. Please fill in all required fields.");
    }

  }


}

