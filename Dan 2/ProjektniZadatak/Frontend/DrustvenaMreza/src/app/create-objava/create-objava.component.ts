import { Component, EventEmitter, Output} from '@angular/core';
import { Objava } from '../objava/objava.model';

@Component({
  selector: 'app-create-objava',
  templateUrl: './create-objava.component.html',
  styleUrls: ['./create-objava.component.css']
})
export class CreateObjavaComponent {

  @Output() addObjavaEventEmitter : EventEmitter<Objava> = new EventEmitter<Objava>();

  newNaslov : string = '';
  newTekst : string = '';

  onAddObjava () {
    let objava = new Objava (this.newNaslov, this.newTekst)
    this.addObjavaEventEmitter.emit(objava)
  }
}
