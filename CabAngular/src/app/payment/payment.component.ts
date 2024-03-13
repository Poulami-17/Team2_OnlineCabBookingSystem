import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { LastPageComponent } from '../last-page/last-page.component';

@Component({
  selector: 'app-payment',
  standalone: true,
  imports: [CommonModule,FormsModule,LastPageComponent],
  templateUrl: './payment.component.html',
  styleUrl: './payment.component.css'
})
export class PaymentComponent {
  constructor(private router: Router){}
  payment(){
   this.router.navigate(['/lastPage']);
  }
}
