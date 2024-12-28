import { Component } from '@angular/core';
import { ApartmentService } from '../../../services/apartment-service/apartment.service';
import { Apartment } from '../../../models/Apartaments';
import { CommonModule } from '@angular/common';
import { ApartmentCardComponent } from '../../apartment-card/apartment-card/apartment-card.component';

@Component({
  selector: 'app-apartment-listing',
  imports: [CommonModule, ApartmentCardComponent],
  templateUrl: './apartment-listing.component.html',
  styleUrl: './apartment-listing.component.css'
})
export class ApartmentListingComponent {
  constructor(private service: ApartmentService) { }
  apartments = new Array<Apartment>();
  ngOnInit() {
      this.service.getAll()
      .subscribe(
          data => {
              this.apartments = data;
          },
          err => {
              console.log(err)
          },
          () => {
              console.log("Completed")

          });
    }
}