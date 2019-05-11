import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.prod';

@Injectable()
export class RequestInterceptor implements HttpInterceptor {

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    let request = req.clone({
      url: req.url.replace(req.url, environment.api.server + req.urlWithParams.slice(0, 22)),
      setHeaders: { 'Content-Type': 'application/json' }
    });
    return next.handle(request);
  }
}