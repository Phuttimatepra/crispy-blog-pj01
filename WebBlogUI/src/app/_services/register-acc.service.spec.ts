import { TestBed } from '@angular/core/testing';

import { RegisterAccService } from './register-acc.service';

describe('RegisterAccService', () => {
  let service: RegisterAccService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RegisterAccService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
