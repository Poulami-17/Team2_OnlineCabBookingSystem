import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { HomepageComponent } from '../homepage/homepage.component';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [CommonModule, RouterModule, HomepageComponent],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  loggedIn: boolean = false;
  // constructor(private router: Router){}
  // homepage()
  // {
  //   this.router.navigate(['/homepage']);
  // }
  // contact()
  // {
  //   this.router.navigate(['/contact']);
  // }
  // abouts()
  // {
  //   this.router.navigate(['/abouts']);
  // }


  constructor(private router: Router) {}
  homepage()
  {
this.router.navigate(['/homepage']);
  }
  contact()
  {
    this.router.navigate(['/contact']);
  }
  abouts()
  {
    this.router.navigate(['/abouts']);
  }
  customerlogin()
  {
    this.router.navigate(['/customerlogin']);
  }
 adminlogin()
  {
    this.router.navigate(['/adminlogin']);
  }
 
}
 

