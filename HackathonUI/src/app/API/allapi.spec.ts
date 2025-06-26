import { TestBed } from '@angular/core/testing';

import { Allapi } from './allapi';

describe('Allapi', () => {
  let service: Allapi;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Allapi);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
