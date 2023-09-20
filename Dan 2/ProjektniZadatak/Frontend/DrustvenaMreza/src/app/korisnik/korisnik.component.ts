import { Component } from '@angular/core';

import { Korisnik } from './korisnik.model';
import { KorisnikService } from '../services/korisnik.service';

import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, Subscription } from 'rxjs';
import { map, filter, catchError } from 'rxjs/operators';

@Component({
  selector: 'app-korisnik',
  templateUrl: './korisnik.component.html',
  styleUrls: ['./korisnik.component.css']
})
export class KorisnikComponent {

korisnici : Korisnik [] = [];
korisnikIme : string = "Korisnikovo ime";
korisnikPrezime: string = "Korisnikovo prezime";
korisnikEmail : string = "Korisnikov email";
korisnikUsername : string = "Korisnikov username";
korisnikPassword : string = "Korisnikov password";

constructor(private korisnikService: KorisnikService) {}

ngOnInit () {
 // var korisnikParam = new Korisnik (this.korisnikIme, this.korisnikPrezime, this.korisnikEmail, this.korisnikUsername, this.korisnikPassword);

  //this.korisnikService.createKorisnik(korisnikParam).subscribe({
 //   next: (data) => {
  //   console.log(data);
   //   this.korisnici.push(data);
   // }
 // })
  this.fetchAndSetKorisnici();

}
fetchAndSetKorisnici () : void {
  this.korisnikService.fetchKorisnici().subscribe((data => {
    this.korisnici = data;
  }))
}



}

