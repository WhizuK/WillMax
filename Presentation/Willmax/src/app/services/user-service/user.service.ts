import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../../models/User';
import { environment } from '../../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class UserService {
    url:string;

    constructor(private http: HttpClient) {
        this.url = environment.apiUrl + '/User';
    }

    httpHeaders: HttpHeaders = new HttpHeaders({
        Authorization: 'Bearer ' + localStorage.getItem('token')
    });

    public getAll() : Observable<User[]>{
        console.log(this.httpHeaders)
        return this.http.get<User[]>(this.url, { headers: this.httpHeaders });
    }

}