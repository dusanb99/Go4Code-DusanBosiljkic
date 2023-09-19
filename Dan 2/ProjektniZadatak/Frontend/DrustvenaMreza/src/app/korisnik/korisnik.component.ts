import { Component, Input } from '@angular/core';

import { Korisnik } from './korisnik.model';

@Component({
  selector: 'app-korisnik',
  templateUrl: './korisnik.component.html',
  styleUrls: ['./korisnik.component.css']
})
export class KorisnikComponent {

@Input () korisnik : Korisnik = new Korisnik ('','', '', '', '');

constructor() {

}
}

