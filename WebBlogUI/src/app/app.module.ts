import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FirstTimesComponent } from './components/first-times/first-times.component';
import { HttpClientModule } from '@angular/common/http';
import { HeaderComponent } from './components/master/header/header/header.component';
import { FooterComponent } from './components/master/footer/footer/footer.component';
import { Page2Component } from './components/page2/page2/page2.component';

@NgModule({
  declarations: [
    AppComponent,
    FirstTimesComponent,
    HeaderComponent,
    FooterComponent,
    Page2Component
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule, // call app-routing.module.ts
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
