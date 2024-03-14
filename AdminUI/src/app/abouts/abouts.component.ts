import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonEngine } from '@angular/ssr';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
  selector: 'app-abouts',
  standalone: true,
  imports: [CommonModule, RouterModule, NavbarComponent],
  templateUrl: './abouts.component.html',
  styleUrl: './abouts.component.css'
})
export class AboutsComponent {

}
