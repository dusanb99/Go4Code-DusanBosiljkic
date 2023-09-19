import { Component, EventEmitter, Output } from '@angular/core';
import { Korisnik } from '../korisnik/korisnik.model';



@Component({
  selector: 'app-create-korisnik',
  templateUrl: './create-korisnik.component.html',
  styleUrls: ['./create-korisnik.component.css']
})
export class CreateKorisnikComponent {
@Output() addKorisnikEventEmitter: EventEmitter<Korisnik> = new EventEmitter<Korisnik>();

newIme : string = '';
newPrezime : string = '';
newUsername : string = '';
newEmail : string = '';
newPassword : string = '';

onAddKorisnik () {

  console.log("U eventu sam...");
  let korisnik = new Korisnik (this.newIme, this.newPrezime, this.newEmail, this.newUsername, this.newPassword);
  this.addKorisnikEventEmitter?.emit(korisnik);
}
}
