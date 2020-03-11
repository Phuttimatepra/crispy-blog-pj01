import { TestBed } from '@angular/core/testing';

import { FirstTimesService } from './first-times.service';

describe('FirstTimesService', () => {
  let service: FirstTimesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FirstTimesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
