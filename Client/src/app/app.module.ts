import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { RepositoryService } from 'src/common/services/repository.service';
import { SessionService } from 'src/common/services/session.service';
import { RequestInterceptor } from 'src/common/interceptors/Request.interceptor';

@NgModule({
   declarations: [
      AppComponent,
   ],
   imports: [
      BrowserModule,
      BrowserAnimationsModule,
      AppRoutingModule,
      HttpClientModule,
   ],
   providers: [
      RepositoryService,
      SessionService,
      // Interceptors
      { provide: HTTP_INTERCEPTORS, useClass: RequestInterceptor, multi: true }
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
