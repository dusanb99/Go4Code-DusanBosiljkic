import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateObjavaComponent } from './create-objava.component';

describe('CreateObjavaComponent', () => {
  let component: CreateObjavaComponent;
  let fixture: ComponentFixture<CreateObjavaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CreateObjavaComponent]
    });
    fixture = TestBed.createComponent(CreateObjavaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
