import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FirstTimesComponent } from './first-times.component';

describe('FirstTimesComponent', () => {
  let component: FirstTimesComponent;
  let fixture: ComponentFixture<FirstTimesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FirstTimesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FirstTimesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
