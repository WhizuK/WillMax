import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RestClientService {
    //TODO REMOVE
    constructor(private http: HttpClient) { }

    baseUrl = 'https://localhost:7297/api';

    httpHeaders: HttpHeaders = new HttpHeaders({
        Authorization: 'Bearer '
    });

    public get<T>(endpoint: string) :  undefined {
        this.http.get<T>(this.baseUrl+endpoint).subscribe((data) => {return data;});
    };

    //CREATE OWN SERVICE FOR AUTH/USER
    public getAll<T>(endpoint: string) : Observable<T[]>{
        return this.http.get<T[]>(this.baseUrl+endpoint, { headers: this.httpHeaders });
      }

    public post<T>(endpoint: string, body: T) :  undefined {
        console.log(body);
        this.http.post(this.baseUrl+endpoint, body).subscribe(
            data => {
                localStorage.setItem('token', data.toString());
                console.log(data)
            },
            err => {
                console.log(err)
            },
            () => {
                console.log("Completed")
            });
      };
}
