import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormComponent } from './modules/formulario/form/form.component';
import { HomeComponent } from './modules/formulario/home/home.component';
import { ListShippersComponent } from './modules/formulario/list-shippers/list-shippers.component';

@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    HomeComponent,
    ListShippersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
