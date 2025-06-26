import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Createstaff } from './createstaff';

describe('Createstaff', () => {
  let component: Createstaff;
  let fixture: ComponentFixture<Createstaff>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Createstaff]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Createstaff);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
