import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Scheduleshift } from './scheduleshift';

describe('Scheduleshift', () => {
  let component: Scheduleshift;
  let fixture: ComponentFixture<Scheduleshift>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Scheduleshift]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Scheduleshift);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
