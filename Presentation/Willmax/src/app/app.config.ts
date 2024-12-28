import { ApplicationConfig, importProvidersFrom, provideZoneChangeDetection } from '@angular/core';
import { provideRouter, RouterLink } from '@angular/router';

import { routes } from './app.routes';
import { provideClientHydration, withEventReplay } from '@angular/platform-browser';
import { HTTP_INTERCEPTORS, HttpClientModule, provideHttpClient, withInterceptorsFromDi } from '@angular/common/http';
import { provideAnimations } from '@angular/platform-browser/animations';
import { LoggingInterceptor } from './services/interceptor/interceptor.service';

export const appConfig: ApplicationConfig = {
  providers: [
      RouterLink,
      provideRouter(routes),
      provideAnimations(),
      provideHttpClient(withInterceptorsFromDi()),
      { provide:HTTP_INTERCEPTORS, useClass:LoggingInterceptor, multi:true },
      importProvidersFrom(HttpClientModule)
  ]
};