import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { KorisnikComponent } from './korisnik/korisnik.component';
import { CommonModule } from '@angular/common';

import {MatButtonModule} from '@angular/material/button';
import { CreateKorisnikComponent } from './create-korisnik/create-korisnik.component';

import { FormsModule } from '@angular/forms';
import { ObjavaComponent } from './objava/objava.component';
import { CreateObjavaComponent } from './create-objava/create-objava.component';

@NgModule({
  declarations: [
    AppComponent,
    KorisnikComponent,
    CreateKorisnikComponent,
    ObjavaComponent,
    CreateObjavaComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    MatButtonModule,
    FormsModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
