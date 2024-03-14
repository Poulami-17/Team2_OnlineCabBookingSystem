import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-addroutes',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule],
  templateUrl: './addroutes.component.html',
  styleUrl: './addroutes.component.css'
})
export class AddroutesComponent {
  route: any={};

  constructor(private router: Router) { }

  ngOnInit(): void {
    
  }
  onSubmit()
  {
    //logic to handle form submission (sending data to backend API)
    alert('Route Added Successfully.');
    console.log(this.route);
    //logic to reset the form after 
    this.router.navigate(['/routeshomepage']);
    
  }
  goBack() {
    this.router.navigate(['/routeshomepage']);
  }
}


