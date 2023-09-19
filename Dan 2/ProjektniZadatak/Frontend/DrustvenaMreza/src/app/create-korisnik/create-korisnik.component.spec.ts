import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateKorisnikComponent } from './create-korisnik.component';

describe('CreateKorisnikComponent', () => {
  let component: CreateKorisnikComponent;
  let fixture: ComponentFixture<CreateKorisnikComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CreateKorisnikComponent]
    });
    fixture = TestBed.createComponent(CreateKorisnikComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
