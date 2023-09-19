import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObjavaComponent } from './objava.component';

describe('ObjavaComponent', () => {
  let component: ObjavaComponent;
  let fixture: ComponentFixture<ObjavaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ObjavaComponent]
    });
    fixture = TestBed.createComponent(ObjavaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
