import { Component } from '@angular/core';
import { ApartmentService } from '../../../services/apartment-service/apartment.service';
import { Apartment } from '../../../models/Apartaments';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-apartment-create',
  imports: [FormsModule],
  templateUrl: './apartment-create.component.html',
  styleUrl: './apartment-create.component.css'
})
export class ApartmentCreateComponent {
    constructor(private service: ApartmentService){ }

    apt:Apartment = new Apartment();

    submit() {
        this.service.create(this.apt);
    }

}