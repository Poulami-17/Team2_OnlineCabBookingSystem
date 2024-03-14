import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { CommonEngine } from '@angular/ssr';
import { NavbarComponent } from '../navbar/navbar.component';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [CommonModule, RouterModule, NavbarComponent, FormsModule ],
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.css'
})
export class ContactComponent {
  model: Contact = new Contact();
  constructor(private router: Router) { }
  onSubmit() {
    alert('Submitted');
    this.router.navigate(['/homepage']);
  }
}
 
class Contact {
  name: string | undefined;
  email: string | undefined;
  subject: string | undefined;
  message: string | undefined;
}
