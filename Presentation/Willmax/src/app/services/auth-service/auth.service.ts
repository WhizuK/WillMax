import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment.development';
import { LoginRequest } from '../../models/LoginRequest';
import { LoginResponse } from '../../models/LoginResponse';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
    url:string;

    constructor(private http: HttpClient) {
        this.url = environment.apiUrl + '/Authentication/login';
    }

    //FIX GENERIC
    public login(body: LoginRequest) :  LoginResponse {
        console.log(body);
        this.http.post<LoginResponse>(this.url, body).subscribe(
            data => {
                localStorage.setItem('token', data.token);
                console.log(data)
                return data;
            },
            err => { console.log(err) },
            () => {
                console.log("Completed")
            });
            //THROW EXCEPTION
            return new LoginResponse();
      };
}
