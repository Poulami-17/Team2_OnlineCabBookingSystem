import { TestBed } from '@angular/core/testing';

import { ManagevehiclesService } from './managevehicles.service';

describe('ManagevehiclesService', () => {
  let service: ManagevehiclesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ManagevehiclesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
