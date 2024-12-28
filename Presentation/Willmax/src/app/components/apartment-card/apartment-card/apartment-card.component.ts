import { Component, Input } from '@angular/core';
import { Apartment } from '../../../models/Apartaments';
import { RouterLink } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-apartment-card',
  imports: [CommonModule, RouterLink],
  templateUrl: './apartment-card.component.html',
  styleUrl: './apartment-card.component.css'
})
export class ApartmentCardComponent {
  constructor(private router: RouterLink){

  }
  @Input() apartment!: Apartment;

  navigate(){
      this.router.routerLink;
  }
}
