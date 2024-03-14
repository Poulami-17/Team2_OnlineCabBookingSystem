import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
  selector: 'app-customerlogin',
  standalone: true,
  imports: [CommonModule, RouterModule, NavbarComponent, FormsModule],
  templateUrl: './customerlogin.component.html',
  styleUrl: './customerlogin.component.css'
})
export class CustomerloginComponent {
  username: string | undefined;
  password: string | undefined;

  constructor(private router: Router) {}

  onSubmit(formvalues:any) {
    console.log('username',formvalues.username)
    console.log('password',formvalues.password)
    
    // Example validation - Replace with your actual validation logic
    if (this.username === "customer" && this.password === "password") {
      // Navigate to admin dashboard or any other route on successful login
      alert('Success Login');
      // this.router.navigate(['/customer-dashboard']); // Replace '/admin-dashboard' with the route for your admin dashboard
    } else {
      // Handle invalid login
      formvalues.username='';
      formvalues.password='';
      alert("Invalid username or password");
    }
  }
}
