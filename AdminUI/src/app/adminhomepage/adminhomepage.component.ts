import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { CommonEngine } from '@angular/ssr';
import { FormsModule } from '@angular/forms';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
  selector: 'app-adminhomepage',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule],
  templateUrl: './adminhomepage.component.html',
  styleUrl: './adminhomepage.component.css'
})
export class AdminhomepageComponent {
  constructor(private router: Router) { }

  managedrivers()
  {
    this.router.navigate(['/managedrivers']);
  }
  managecustomers()
  {
    this.router.navigate(['/managecustomers']);
  }
  manageroutes()
  {
    this.router.navigate(['/manageroutes']);
  }
 managevehicles()
  {
    this.router.navigate(['/managevehicles']);
  }
  bookingdetails()
  {
    this.router.navigate(['/bookingdetails']);
  }  
}


