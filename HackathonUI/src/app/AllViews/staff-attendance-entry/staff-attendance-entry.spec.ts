import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StaffAttendanceEntry } from './staff-attendance-entry';

describe('StaffAttendanceEntry', () => {
  let component: StaffAttendanceEntry;
  let fixture: ComponentFixture<StaffAttendanceEntry>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [StaffAttendanceEntry]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StaffAttendanceEntry);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
