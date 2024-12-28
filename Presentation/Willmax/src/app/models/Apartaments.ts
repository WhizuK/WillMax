import { PhysicalLocation } from "./PhysicalLocation";

export class  Apartment {
    constructor() {
        this.id;
        this.price = 0;
        this.description = 'No description';
        this.image = '';
        this.location = new PhysicalLocation();
    };

    id?: string;
    price: number;
    description: string;
    image: string;
    location: PhysicalLocation;
}