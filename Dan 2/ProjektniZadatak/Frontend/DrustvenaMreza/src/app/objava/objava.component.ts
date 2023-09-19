
import { Component, Input } from '@angular/core';
import { Objava } from './objava.model';

@Component({
  selector: 'app-objava',
  templateUrl: './objava.component.html',
  styleUrls: ['./objava.component.css']
})
export class ObjavaComponent {

@Input () objava : Objava = new Objava ('','');

  constructor () {

  }
}
