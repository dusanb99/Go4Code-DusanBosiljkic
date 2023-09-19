import { Component } from '@angular/core';
import { Korisnik } from './korisnik/korisnik.model';
import { Objava } from './objava/objava.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  korisnici: Korisnik[] = [new Korisnik("Milan", "Stokic", "adadada@gmail.com", "comi123", "12345"), new Korisnik ("Marko", "Djuric", "stagod123@hotmail.com", "lanemi3212", "kaonekasifra123")]

  objave : Objava [] = [new Objava ("Siti-Zvezda", "Danas od 21h Zvezda gostuje na Etihadu... itd...."), new Objava ("14:48", "upravo je 2 sata i 48 minuta...")]

  onKorisnikAdded(korisnik: Korisnik) {
    this.korisnici.push(korisnik);
  }

  onObjavaAdded(objava: Objava) {
    this.objave.push(objava);
  }
}
