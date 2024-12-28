import { Component } from '@angular/core';
import { Apartment } from '../../../models/Apartaments';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-apartment-view',
  imports: [CommonModule, RouterLink],
  templateUrl: './apartment-view.component.html',
  styleUrl: './apartment-view.component.css'
})
export class ApartmentViewComponent {
  apt:Apartment = new Apartment();
}
