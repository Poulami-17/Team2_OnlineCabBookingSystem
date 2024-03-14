import { TestBed } from '@angular/core/testing';

import { ManagedriversService } from './managedrivers.service';

describe('ManagedriversService', () => {
  let service: ManagedriversService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ManagedriversService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
