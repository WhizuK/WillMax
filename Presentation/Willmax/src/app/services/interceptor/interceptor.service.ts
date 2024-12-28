import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class LoggingInterceptor implements HttpInterceptor {
    constructor() { }
    intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {


        /*
            console.log(new Date());
            const token = localStorage.getItem('token') + '';
            const decoded = jwtDecode(token);

            const expDate = decoded.exp;
            const d = new Date(0);
            d.setUTCDate(expDate!);
            console.log(d);
        */


        return next.handle(request);
    }
}