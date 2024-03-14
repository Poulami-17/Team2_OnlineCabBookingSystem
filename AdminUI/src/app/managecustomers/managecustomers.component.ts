import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-managecustomers',
  standalone: true,
  imports: [RouterModule, CommonModule, FormsModule],
  templateUrl: './managecustomers.component.html',
  styleUrl: './managecustomers.component.css'
})
export class ManagecustomersComponent {
  constructor(private router: Router) { }
  showCustomerOptionsFlag: boolean = false;
  showCustomerOptions(){
   this.showCustomerOptionsFlag = true;
 }
 viewcustomers(){
  this.router.navigate(['/viewcustomers'])
}

}
