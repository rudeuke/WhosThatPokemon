import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';

import { HttpClient, HttpClientModule } from '@angular/common/http';
import { AppRootComponent } from './app.component';
import { ShellModule } from './shell';
@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    ShellModule,
    AppRoutingModule,
  ],
  declarations: [AppRootComponent],
  providers: [
    {
      provide: HttpClient,
    },
  ],
  bootstrap: [AppRootComponent],
})
export class AppModule {}
