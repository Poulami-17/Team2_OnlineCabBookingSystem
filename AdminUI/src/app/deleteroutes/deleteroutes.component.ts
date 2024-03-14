import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-deleteroutes',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule, ReactiveFormsModule],
  templateUrl: './deleteroutes.component.html',
  styleUrl: './deleteroutes.component.css'
})
export class DeleteroutesComponent {
  routeId: string | undefined;
  isRouteDeleted: boolean = false;

  constructor(private router: Router) { }

  onSubmit() {
    // Logic to handle route deletion
    alert('Route Deleted Successfully.');
    console.log("Route with ID " + this.routeId + " will be deleted.");
    // Assuming deletion is successful
    this.isRouteDeleted = true;
    // You can add further logic here, like calling a service to delete the route
    // After deletion, navigate back to routeshomepage
  //  setTimeout(() => {
      this.router.navigate(['/routeshomepage']);
  //  }, 2000); // Navigates after 2 seconds, you can adjust this time as needed
  }

  goBack() {
    // Navigate back to routeshomepage
    this.router.navigate(['/routeshomepage']);
  }
}


