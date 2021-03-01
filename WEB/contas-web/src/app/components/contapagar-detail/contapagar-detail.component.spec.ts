import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContapagarDetailComponent } from './contapagar-detail.component';

describe('ContapagarDetailComponent', () => {
  let component: ContapagarDetailComponent;
  let fixture: ComponentFixture<ContapagarDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContapagarDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContapagarDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
