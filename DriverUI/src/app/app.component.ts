import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { AcceptRideComponent } from './accept-ride/accept-ride.component';
import { DriverLoginComponent } from './driver-login/driver-login.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,DriverLoginComponent,HttpClientModule,FormsModule,CommonModule,ReactiveFormsModule,AcceptRideComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'DriverUI';
}
