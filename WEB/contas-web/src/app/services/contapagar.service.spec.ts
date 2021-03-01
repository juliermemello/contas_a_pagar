import { TestBed } from '@angular/core/testing';

import { ContapagarService } from './contapagar.service';

describe('ContapagarService', () => {
  let service: ContapagarService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ContapagarService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
