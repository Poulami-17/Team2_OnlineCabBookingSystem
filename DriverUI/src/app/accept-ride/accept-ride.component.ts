import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AcceptService } from '../accept.service';
import { IRideDetails } from './rideDetails.component.model';

@Component({
  selector: 'app-accept-ride',
  standalone: true,
  imports: [CommonModule,FormsModule,ReactiveFormsModule],
  templateUrl: './accept-ride.component.html',
  styleUrl: './accept-ride.component.css'
})
export class AcceptRideComponent implements OnInit{
  rideDetails: any[] = []
  
  constructor(private rideAccept:AcceptService){}
 
  ngOnInit():void{
    this.rideAccept.getAllBookingRequest().subscribe((rideDetails:any[]) => 
    {this.rideDetails=rideDetails
      console.log(this.rideDetails);
    })
  }
  }
