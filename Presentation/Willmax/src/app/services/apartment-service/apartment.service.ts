import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Apartment } from '../../models/Apartaments';
import { environment } from '../../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class ApartmentService {
    url:string;

    constructor(private http: HttpClient) {
        this.url = environment.apiUrl + '/Apartment';
    }

  public getAll() : Observable<Apartment[]>{
    return this.http.get<Apartment[]>(this.url);
  }

  public create(apt: Apartment){
    this.http.post(this.url, apt).subscribe(
        data => {
            console.log(data)
        },
        err => {
            console.log(err)
        },
        () => {
            console.log("Completed")
        });
  }
}