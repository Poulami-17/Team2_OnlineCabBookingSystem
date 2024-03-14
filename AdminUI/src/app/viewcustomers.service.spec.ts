import { TestBed } from '@angular/core/testing';

import { ViewcustomersService } from './viewcustomers.service';

describe('ViewcustomersService', () => {
  let service: ViewcustomersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ViewcustomersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
